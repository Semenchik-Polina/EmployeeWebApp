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
3. Run commands:

```sh
$ npm install --save-dev @babel/cli @babel/core @babel/plugin-proposal-class-properties @babel/preset-env @babel/preset-react babel-loader webpack webpack-cli webpack-notifier
$ npm install react react-dom axios
$ npm start
```
4. Open EmployeeWebApp/EmployeeWeb.csproj file with Notepad and add the following peace of code before the last <Import Project=...>

```sh
<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>
```
5. Launch the app.

If you're getting message: 
>A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 50 - Local Database Runtime error occurred. Cannot create an automatic instance. See the Windows Application event log for error details.

Try to change Web.config: 

```sh
$ <connectionStrings>
$   <add name="Employees" connectionString="Data Source=(localdb)\mssqllocaldb; ...
```

