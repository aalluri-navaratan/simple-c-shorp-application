# Simple-c-Application
Created the simple c# Application with SQLServer

Installation Softwares: 
    1) Visual Studio 2010 and .NET Framework 4 
    2) SQL Server


I developed the Student information. A Student have id, name and mail in this application
 

I created the application for create, update, delete and show functionality for student details.

---> First open the SQL Server, Created the database name AnilDb ( backup file name is Student.bak )
   ex: SqlConnection cn = new SqlConnection("user id=sa;password=123;database=AnilDb;server=Aneel-PC");
   --- >  SQL Server user id name is 'sa'
   --- >  SQL Server password name is '123'
   --- >  SQl Server database name is 'AnilDb'
   --- >  PC name is Aneel-PC(i.e server name).

---> Created a row with Id, Name, Mail columns in Student table.

---> In this application updated mail column only based on student id.

---> Show option is activated each and every functionality. To show all tables in grid format for student.
