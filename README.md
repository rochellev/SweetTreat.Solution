# Sweet Treat Bakery Web App
### By Rochelle Roberts
-----

## Description
* Sweet Treat Bakery website uses ASP.NET Core MVC framefork and MySQL database to manage a many-to-many relationship between treats and flavors offered. 

## Technologies Used
* C#/.NET
* ASP.NET Core MVC
* HTML
* CSS
* Bootstrap
* MySQL
* Identity

## Installation and Run
* From the terminal, follow the steps below. 
* Click on the local host link (Ctrl + click )

```sh
$ git clone https://github.com/rochellev/SweetTreat.Solution.git
$ cd 
$ dotnet restore
$ dotnet run
```

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |------------| --------------|
| All users can view all treats in the Bakery | navigate to treat page | list of all current treats |
| All users can click on a treat to see it's flavors | clink on treat name | routed to view of the given treat's flavors |
| Homepage will have link to for new users to register | new user enters registration info | user info saved in database |
| A User must log in to gain access to create, update and delete treat functionality | user log in successfully | user now has rights to create, update and delete treats |
