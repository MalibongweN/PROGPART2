# Community Corner - Local Events 

## Overview

This is part of a larger municipal application, focusing specifically on managing and displaying local events within the community. It provides functionality for users to view, search, and receive recommendations for various community events, as well as a notification system for important community announcements.

## Key Features

1. **Event Management**: The app stores and displays a variety of local events, categorized by type (e.g., Music, Workshops, Exhibitions).

2. **Event Display**: Events are displayed as cards in a scrollable panel, showing the event name, date, category, and an associated image.

3. **Search Functionality**: Users can search for events by category.

4. **Recommendations**: The app recommends event categories based on the user's search history.

5. **Notification System**: Displays important community announcements and upcoming event reminders.

## Technical Implementation

### Data Structures

- `Dictionary<string, List<Event>>`: Stores events by their categories.
- `SortedDictionary<DateTime, List<Event>>`: Stores events by their dates.
- `HashSet<string>`: Stores unique event categories.
- `Queue<Notification>`: Manages notifications in a first-in-first-out manner.

### Key Classes

1. **EventForm**: The main form class that handles the UI and logic for displaying and managing events.

2. **Event**: Represents an individual event with properties like Name, Category, Date, and ImagePath.

3. **Notification**: Represents a notification with Message, PostedDate, and EventDate.

### Main Functionalities

1. **Loading Events**: Sample events are loaded in the `LoadEvents()` method.

2. **Displaying Events**: The `DisplayEvents()` method shows all events as cards in the UI.

3. **Searching Events**: The `btnSearch_Click()` method handles searching for events by category.

4. **Recommending Events**: The `btnRecommend_Click()` method suggests event categories based on search history.

5. **Notifications**: The `DisplayNotifications()` method shows all current notifications, sorted by event date.


## Getting Started

To run this module:

1. Ensure you have the necessary dependencies installed (e.g., .NET Framework).
2. Clone the repository and open the solution in Visual Studio.
3. Build and run the application.
4. Use the search bar to find events by category, click the "Recommendation" button for suggestions, and the "Notifications" button to view community announcements.


