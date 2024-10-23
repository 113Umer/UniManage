**Setting Up MS SQL Server Connection in Visual Studio Using LINQ**
This guide provides step-by-step instructions for setting up a Microsoft SQL Server connection in a Visual Studio project using Language Integrated Query (LINQ).

**Prerequisites**
Before you begin, ensure you have the following installed:
Microsoft Visual Studio (any version that supports .NET development Version 8)
Microsoft SQL Server

**Step 1: Creation of Database**
Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance.
Open the SQL Query file uploaded with the project and execute it. This should make 
a new database with the required tables.

**Step 2: Setting Up LINQ**
Open your Visual Studio project.
Right-click on the Project in Solution Explorer and select Manage NuGet Packages.
Search for Entity Framework and install it.
Use the following command in the Package Manager Console:

Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
**Note: Remember to Modify Your Visual Studio Installation to include the LINQ to SQL Tools**


**Step 3: Add Connection String**
Open the DbContext.cs file and replace 
"optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniManage;Integrated Security=True;Trust Server Certificate=True"); 
With your SQL Server connection string

Conclusion
You have successfully set up a Microsoft SQL Server connection to your Visual Studio project using LINQ. You can now utilize the power of LINQ to query and manipulate your database easily.

Troubleshooting
Ensure that your SQL Server instance is running.
Check your connection string for any errors.
Verify that your project is targeting the correct framework.
