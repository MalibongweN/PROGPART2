using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CommunityCorner
{
    public partial class EventForm : Form
    {
        //Dictionary, to store events by their categories
        private Dictionary<string, List<Event>> eventCategories = new Dictionary<string, List<Event>>();
        //Dictionary to track search history
        private Dictionary<string, int> searchHistoryCount = new Dictionary<string, int>();
        //Sorted Dictionary, stores events by their dates
        private SortedDictionary<DateTime, List<Event>> eventDates = new SortedDictionary<DateTime, List<Event>>();
        //Set, stores unique categories
        private HashSet<string> uniqueCategories = new HashSet<string>();
        //List, track order of searches
        private List<string> searchHistoryOrder = new List<string>();

        //notification class
        private class Notification
        {
            public string Message { get; set; }
            public DateTime PostedDate { get; set; }
            public DateTime EventDate { get; set; }

            public Notification(string message, DateTime eventDate)
            {
                Message = message;
                PostedDate = DateTime.Now;
                EventDate = eventDate;
            }
        }

        //queue to notifications
        private Queue<Notification> notifications = new Queue<Notification>();

        public EventForm()
        {
            InitializeComponent();
            LoadEvents();
            InitializeNotifications();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            //so you can scroll through the events
            flowLayoutPanel1.AutoScroll = true;

            txtSearchCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecommend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void LoadEvents()
        {
            //sample events
            Event e1 = new Event("Music Festival", "Music", new DateTime(2024, 12, 25), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\festival.jpg");
            Event e2 = new Event("Tech Workshop", "Workshops", new DateTime(2024, 11, 10), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\tech.jpeg");
            Event e3 = new Event("Art Expo", "Exhibitions", new DateTime(2024, 10, 15), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\art.jpg");
            Event e4 = new Event("Food Fair", "Food", new DateTime(2024, 12, 05), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\food.jpg");
            Event e5 = new Event("Startup Pitch", "Entrepreneurship", new DateTime(2024, 11, 25), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\startup.jpg");
            Event e6 = new Event("Coding Marathon", "Competitions", new DateTime(2024, 10, 18), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\code.jpg");
            Event e7 = new Event("Charity Walk", "Charity", new DateTime(2024, 11, 08), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\walk.jpg");
            Event e8 = new Event("Jazz Night", "Music", new DateTime(2024, 12, 28), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\jazz.jpg");
            Event e9 = new Event("Book Fair", "Literature", new DateTime(2024, 11, 12), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\book.jpg");
            Event e10 = new Event("Science Expo", "Exhibitions", new DateTime(2024, 10, 22), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\science.jpg");
            Event e11 = new Event("Career Fair", "Workshops", new DateTime(2024, 12, 15), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\fair.jpg");
            Event e12 = new Event("Film Screening", "Entertainment", new DateTime(2024, 12, 30), "C:\\Users\\lab_services_student\\Downloads\\CommunityCorner\\CommunityCorner\\images\\film.jpg");

            AddEvent(e1);
            AddEvent(e2);
            AddEvent(e3);
            AddEvent(e4);
            AddEvent(e5);
            AddEvent(e6);
            AddEvent(e7);
            AddEvent(e8);
            AddEvent(e9);
            AddEvent(e10);
            AddEvent(e11);
            AddEvent(e12);

            DisplayEvents();
        }

        //storing event to appropriate data structure
        private void AddEvent(Event ev)
        {
            if (!eventCategories.ContainsKey(ev.Category))
            {
                eventCategories[ev.Category] = new List<Event>();
            }
            eventCategories[ev.Category].Add(ev);

            if (!eventDates.ContainsKey(ev.Date))
            {
                eventDates[ev.Date] = new List<Event>();
            }
            eventDates[ev.Date].Add(ev);

            uniqueCategories.Add(ev.Category);
        }

        //display events
        private void DisplayEvents()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var dateEvent in eventDates)
            {
                foreach (var ev in dateEvent.Value)
                {
                    AddEventCard(ev); //adds each event 
                }
            }
        }

        //method to add event cards
        private void AddEventCard(Event ev)
        {
            Panel eventCard = new Panel
            {
                Size = new Size(250, 350),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                BackColor = Color.White
            };

            PictureBox eventImage = new PictureBox
            {
                Size = new Size(200, 150),
                Image = Image.FromFile(ev.ImagePath),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label eventDetails = new Label
            {
                Text = $"{ev.Name}\n{ev.Date.ToShortDateString()}\nCategory: {ev.Category}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Bottom
            };

            eventCard.Controls.Add(eventImage);
            eventCard.Controls.Add(eventDetails);

            flowLayoutPanel1.Controls.Add(eventCard);
        }

        //search by category
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCategory = txtSearchCategory.Text.ToLower();

            if (eventCategories.Keys.Any(category => category.ToLower() == searchCategory))
            {
                if (!searchHistoryCount.ContainsKey(searchCategory))
                {
                    searchHistoryCount[searchCategory] = 0;
                }
                searchHistoryCount[searchCategory]++;

                flowLayoutPanel1.Controls.Clear();
                List<Event> events = eventCategories.FirstOrDefault(pair => pair.Key.ToLower() == searchCategory).Value;
                foreach (var ev in events)
                {
                    AddEventCard(ev);
                }
            }
            else
            {
                MessageBox.Show("No events found in this category.");
            }
        }

        //recommend button click
        private void btnRecommend_Click(object sender, EventArgs e)
        {
            string recommendedCategory = GetMostSearchedCategory();
            if (!string.IsNullOrEmpty(recommendedCategory))
            {
                if (eventCategories.ContainsKey(recommendedCategory))
                {
                    MessageBox.Show($"Based on your searches, we recommend events in: {recommendedCategory}");
                    flowLayoutPanel1.Controls.Clear();
                    List<Event> recommendedEvents = eventCategories[recommendedCategory];
                    foreach (var ev in recommendedEvents)
                    {
                        AddEventCard(ev);
                    }
                }
                else
                {
                    MessageBox.Show($"Based on your searches, we recommend visiting: {recommendedCategory}");
                }
            }
            else
            {
                MessageBox.Show("No categories have been searched yet.");
            }
        }

        private string GetMostSearchedCategory()
        {
            if (searchHistoryCount.Count == 0)
            {
                return string.Empty;
            }

            return searchHistoryCount.OrderByDescending(pair => pair.Value).First().Key;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DisplayEvents();
        }

        //notification methods
        private void InitializeNotifications()
        {
            // Add sample notifications with dates
            AddNotification("Beware of heavy weather approaching", DateTime.Now.AddDays(1));
            AddNotification("Road maintenance scheduled", DateTime.Now.AddDays(3));
            AddNotification("Mayor presentation of park", DateTime.Now.AddDays(7));
        }

        private void AddNotification(string message, DateTime eventDate)
        {
            notifications.Enqueue(new Notification(message, eventDate));
        }

        private void DisplayNotifications()
        {
            if (notifications.Count == 0)
            {
                MessageBox.Show("No new notifications.");
                return;
            }

            string allNotifications = "";
            var sortedNotifications = notifications.OrderBy(n => n.EventDate).ToList();

            foreach (var notification in sortedNotifications)
            {
                allNotifications += $"• {notification.Message}\n";
                allNotifications += $"  Posted on: {notification.PostedDate:MM/dd/yyyy}\n";
                allNotifications += $"  Event date: {notification.EventDate:MM/dd/yyyy}\n\n";
            }

            MessageBox.Show(allNotifications.TrimEnd(), "Notifications");

           
            notifications.Clear();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            DisplayNotifications();
        }
    }

    //Event Class 
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }

        public Event(string name, string category, DateTime date, string imagePath)
        {
            Name = name;
            Category = category;
            Date = date;
            ImagePath = imagePath;
        }
    }
}