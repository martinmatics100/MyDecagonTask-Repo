 ContactBook_API_monolithic (week10_task)
 ------------------------------------
Intro:

This task is aimed at evaluating your understanding and implementation of API using ASP.NET Core.

Challenge

You are required to create a Contact-book Application to manage contacts information using API ASP.NET Core Framework.

Task requirements

- Implement Identity membership system

- Implement Photo storage on Cloudinary

- Implement pagination

- Implement Swagger-UI for data visualization and access to the API

- Implement JWT authentication system for authentication

- The data storage required for this project is either SQLite or SQL-Server database.

- Use EFCore and LINQ to abstract ADO.NET data access

- The application should have the following endpoints to manage CRUD on Users records

· GET: http:localhost:[port]/User/all-users?Page=[current number]

· GET: http:localhost:[port]/User/[id]

· GET: http:localhost:[port]/User/[email]

· POST: http:localhost:[port]/User/add-new

· PUT: http:localhost:[port]/User/update/[id]

· DELETE: http:localhost:[port]/User/delete/[id]

· PATCH: http:localhost:[port]/User/photo/[id]

- All functional requirements should be completed.

- Task should be submitted on or before Wednesday, July 26th, 2023.

- Submission should be made to this GitHub classroom https://classroom.github.com/a/yXKSm1q3

User Roles

- Admin

- Regular

Functional requirements

As an Admin User

- Should be able to add new contacts

- Should be able to get paginated records of existing contacts.

- Should be able to get single record of existing contact either by id, email

- Should be able to update contacts

- Should be able to delete contacts

As a Regular User

- Should be able to get single record of existing contacts either by id, email

- Should update record to add photo
