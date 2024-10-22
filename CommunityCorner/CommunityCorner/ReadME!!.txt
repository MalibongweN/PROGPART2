
# Community Corner Application

## Overview
The Community Corner is a desktop application designed for municipalities and communities to report and track local issues, such as sanitation, road problems, and utilities. Users can submit reports with descriptions and attach media (images), and the data is displayed in a report view for review. The application supports the addition of categories and allows users to attach images for detailed reporting.

---

## Table of Contents
1. [System Requirements]
2. [Installation]
3. [Running the Application]
4. [Main Features]
5. [Usage]
6. [Troubleshooting]
7. [Contributing]
8. [License]

---

## System Requirements
To run the application, you will need the following:
- **Windows OS** (10 or higher)
- **Visual Studio 2022 or later** with:
  - .NET Framework 4.7.2 or higher
  - Windows Forms development package installed
- Minimum **4GB RAM**
- **50MB free disk space**

---

## Installation

### Step 1: Clone or Download the Repository
Clone the repository from the version control system or download the `.zip` file containing the project files and extract them.

### Step 2: Open in Visual Studio
1. Open **Visual Studio**.
2. Go to `File -> Open -> Project/Solution`.
3. Navigate to the project folder and select the `CommunityCorner.sln` file.

### Step 3: Install Dependencies
Ensure that the necessary dependencies for Windows Forms and .NET Framework are installed:
- In **Visual Studio**, go to `Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution`.
- If necessary, restore any missing NuGet packages.

---

## Running the Application

### Step 1: Build the Project
Before running the app:
1. In **Visual Studio**, go to `Build -> Build Solution`.
2. Ensure that there are no build errors.

### Step 2: Run the Application
1. In **Visual Studio**, press `F5` or click the `Start` button (green play button) in the toolbar to run the application.
2. The **Community Corner** app will launch.

---

## Main Features
- **Report Issue**: Users can fill out a form with the issue location, category, and description, and optionally attach media (images) to provide visual evidence.
- **View Reports**: Users can view all the submitted reports in a grid format, including the location, category, and description. Clicking on a report allows users to view any attached media.
- **Submit Media**: Users can attach images in supported formats (JPG, PNG, BMP) when submitting an issue.
- **Navigation**: The application allows users to return to the main form or exit after submitting a report.

---

## Usage

### Reporting an Issue
1. Launch the **Community Corner** app.
2. In the **Report Issue** section:
   - Enter the **Location** of the issue.
   - Select the **Category** from the dropdown menu (e.g., Sanitation, Roads, Utilities, Other).
   - Enter a **Description** of the issue.
   - Attach an image using the **Attach Media** button (optional).
   - Click **Submit**.
3. After submission, you will be redirected back to the main form.

### Viewing Reports
1. Click on the **View Reports** button from the main form.
2. A data grid will show all the submitted reports.
3. Click on a report to see more details or open any attached media by clicking the media column.

---

## Troubleshooting

### Common Issues

- **Error Opening Media Files**:
  - Ensure that the attached file path exists. If the media cannot be found, check the file path stored in the report or verify if the file was correctly attached.

- **Application Crashes**:
  - Check if all dependencies are properly installed and that the .NET Framework version is compatible.
  - Ensure Visual Studio is set to use the correct architecture (x86 or x64) depending on your system configuration.

---

## Contributing
If you'd like to contribute to this project, please follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch-name`).
3. Make your changes and commit them (`git commit -am 'Add a new feature'`).
4. Push your changes to the branch (`git push origin feature-branch-name`).
5. Open a Pull Request.

---

## License
This project is licensed under the IIE Varsity College License. 

---

## Contact
For issues or feature requests, please reach out to the development team via email or through the repository's issue tracker.

-