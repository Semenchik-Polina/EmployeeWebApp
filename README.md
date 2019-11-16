# Employee Web App

EmployeeWebApp is a single page application with lists of candidates and employees.

### Tech

* Three-tier architecture
* Microsoft ASP .NET MVC5
* Microsoft SQL
* Entity Framework
* Automapper
* Ninject
* React.js
* React Router


### Installation

EmployeeWebApp requires [Node.js](https://nodejs.org/) to run.

1. Clone or download the repository.
2. Open command line in EmployeeWebApp folder.
3. Run command:

```sh
$ npm start
```
4. Run the app.

If you're getting message: 
>A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 50 - Local Database Runtime error occurred. Cannot create an automatic instance. See the Windows Application event log for error details.

Try to change Web.config: 

```sh
$ <connectionStrings>
$   <add name="Employees" connectionString="Data Source=(localdb)\mssqllocaldb; ...
```

