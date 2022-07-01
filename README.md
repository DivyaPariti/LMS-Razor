# 📚 LMS-Razor
This is a Library Management System project built using ASP.NET CORE and Razor Pages Concept. 

# ⚙️ Tools Required
In order to get this project up and running 
- Firstly, download the Zip folder and unzip it into your local system.
- Secondly install all the necessary tools for the project

- Visual Studio 2019 Community Edition 

        link to download Visual Studio Code: https://code.visualstudio.com/download

- Microsoft .NET Core Framework 3.1 

       link to download dontnet core 3.1: https://dotnet.microsoft.com/en-us/download/dotnet/3.1

- You'll be needing SQL Server in order to store the data into the database for that download:
        
        - Microsoft SQL Server 
          link to download Microsoft SQL Server: https://www.microsoft.com/en-in/sql-server/sql-server-downloads
            &
        - SQL Server Management Studio(SSMS)
          link to download  SQL Server Management Studio(SSMS): https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

- Open the file structure in the Visual Studio Code
- Open the Package Manager; Tools > NuGet Package Manager >  Manage NuGet Packages; and install the following:

      - Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
      - Microsoft.EntityFrameworkCore
      - Microsoft.EntityFrameworkCore.SqlServer
      - Microsoft.EntityFrameworkCore.Tools
      
# 👾 Steps to execute the code
- After installing the above packages run migrations(adding migrations adds the tables to your database automatically, it removes the need to add, update, delete, and manage the database tables manually.)
       
       - Commands: 
            - Open Package Manager > Package Manager Console 
            - add-migration
            - update-database

- The last step run the IIS Express and voila you have the LMS Razor application up and running successfully!!!

# 📸 Snapshots of the output screen:


     Display Screen

![LMS-1](https://user-images.githubusercontent.com/65856784/176651440-784e44cd-3fc1-438a-8c74-c5483d1d4ce6.png)


     Books List Screen:
               
![LMS-2](https://user-images.githubusercontent.com/65856784/176651512-55bbd028-4ba9-408f-b386-f3d04a459e5f.png)
    
    
     Create New Books Screen:
                
![LMS-3](https://user-images.githubusercontent.com/65856784/176651493-1379c674-515c-4474-8f29-7cfc7e6e8557.png)
 
 
     Edit Screen:
                
![LMS-4](https://user-images.githubusercontent.com/65856784/176651502-2f0e0757-9250-4f3e-83ec-d90ec2df027d.png)
   
   
    Delete Screen:
                
![LMS-5](https://user-images.githubusercontent.com/65856784/176651509-97f39689-de20-4872-ad59-ba429e2f1364.png)


# 📧 Always feel free to contact me in case of any query.
