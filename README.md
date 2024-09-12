<!-- # prog7312-part-1-ST10048211 -->
<h1 align="center">Welcome to ST10048211 PROG7312 POE 👋</h1>

## Municipal Service Reporting System (CityEngage)

### Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Setup Instructions](#setup-instructions)
  - [1. Clone the Repository](#clone-the-repository)
  - [2. Restore NuGet Packages](#restore-nuget-packages)
  - [3. Build and Run the Application](#build-and-run-the-application)
  - [4. Run the Application from the Executable](#run-the-application-from-the-executable)
- [Using the Application](#using-the-application)
  - [1. Report an Issue](#report-an-issue)
  - [2. View Reported Issues](#view-reported-issues)
- [License](#license)
- [Contributors](#contributors)
- [Author](#author)
- [References](#references)

## Introduction
The **Municipal Service Reporting System** is a C# .NET Framework Windows application that allows residents to report municipal issues, such as potholes, water leaks, and power outages. The system features file attachment, progress tracking, and issue status updates. A local SQL Server database is used to manage reported issues (The IIE, 2024).

This document provides instructions on how to set up, compile, run, and use the application.
<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

## Prerequisites
Before you start, ensure you have the following installed:
- **Visual Studio 2022** with the .NET Framework workload.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

## Setup Instructions

### 1. Clone the Repository
To clone the repository to your local machine, run the following command:

` git clone https://github.com/your-username/municipal-service-system.git `

### 2. Restore NuGet Packages

Open the solution in Visual Studio. Right-click on the solution in the Solution Explorer and select `Restore NuGet Packages` to download the required packages.


### 3. Build and Run the Application

1.  In Visual Studio, set the main project as the startup project.
2.  Build the solution by pressing `Ctrl + Shift + B` or by selecting `Build Solution` from the `Build` menu.
3.  Run the application by pressing `F5` or clicking the `Start` button.

### 4. Run the Application from the Executable

After building the application, you can run it directly from the `.exe` file:

1.  Navigate to the `bin\Debug\net8.0-windows` folder within the project directory.
      
2.  Find the `.exe` file (e.g., `ST10048211_PROG7312_POE_PART_1.exe`).
    
3.  Double-click the file to run the application.
    
<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

## Using the Application

### 1. Report an Issue

-   Navigate to the "Report New Issue" section.
-   Fill in the location, category, and description of the issue.
-   Attach a file (e.g., a photo or pdf).
-   Click `Submit` to log the issue. The progress bar will show the submission status.

### 2. View Reported Issues
- Once submitted the issue, useres will have the option to display existing issues, which will open the Display Window once clicked.
-   You will see a list of all previously reported issues, including location, category, description, and any attached files.


<p align="right">(<a href="#table-of-contents">back to top</a>)</p>


## License

This project is licensed under the MIT License. See the LICENSE file for more details.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>


## Contributors

Thanks to my lecturer, who supported and assisted in creating this project through these class example projects.

Thanks to Othneil Drew (Drew, 2022) for the Readme file template.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

<!-- CONTRIBUTORS --


<!-- AUTHOR -->
## Author

👤 **Anjali Sunil Morar**

- Github: [@ST10048211](https://github.com/ST10048211)
### - Part 1:
- Project Link: [https://github.com/VCSTDN/prog6212-part-1-ST10048211.git](https://github.com/VCSTDN/prog6212-part-1-ST10048211.git)
- YouTube Link:  https://youtu.be/jDoMSRV6XcU

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

## References

-   [Microsoft Learn - C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
-   [Entity Framework Documentation](https://learn.microsoft.com/en-us/ef/)
- Anandmeg _et al._ 2022. _Tutorial: Open a project from a repo in Visual Studio - Visual Studio (windows)_, _in Visual Studio - Visual Studio (Windows) | Microsoft Learn_. [Online]. Available at: https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022 (Accessed 28 August 2024).

- Drew, O. 2022. _Best-readme-template/readme.md at master · othneildrew/best-readme-template_, _GitHub_. [Online]. Available at: https://github.com/othneildrew/Best-README-Template/blob/master/README.md (Accessed 28 August 2024).

- GeeksforGeeks. 2022. _What is readme.md file?_, _GeeksforGeeks_. GeeksforGeeks. [Online]. Available at: https://www.geeksforgeeks.org/what-is-readme-md-file/ (Accessed 28 August 2024).

- The IIE. 2024. PROG7321 [Portfolio Of Evidence]. The Independent Institute of Education: Unpublished.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>	
<!-- REFERENCES -->
