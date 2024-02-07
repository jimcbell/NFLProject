## NFL Play by Play Viewer

## Project Overview

### NFL Data Import
- The data for this project was initially downloaded from: [NFL Savant](https://nflsavant.com/about.php)
- Downloaded this in a csv and did data cleaning in Google Sheets.
- Using a Nuget package "CsvHelper" to take the data in the csv and convert them into Entity Objects to initially load the database
- One time import.

### NFL.Context.SqlServer
- Uses entity framework core in order to interact with the data in the database.
- Used a code first approach as I knew what the classes would look like from the csv


### Technology Used
- Sql Server 
    - Storing NFL data from a csv dump.
- Entity Framework Core (Not implemented yet)
    - Object relational mapper for Gmail Cleaner Database 
- OData
    - Implemented the OData protocol on top of the Asp.Net Core api in order to make the data easily filtered and queried by any client
- Razor Pages
    - Initial UI testing, moving on to Blazor Components now
- XUnit
    - Testing of the .Net Projects    
- Blazer (In Progress) - Radzen
    - Using Radzen an open source library for Blazor UI components, currently working on.
    - Creating the UI for the NFL Project
- Terraform (Not implemented yet)
    - Infrastructure as code used to create Azure resources


### Azure Infrastructure Used
- Azure Sql Database
    - Relational database management system
- Azure Key Vault (Not implemented yet)
    - Used to store secret configuration values
- Azure App Service (Not implemented yet)
    - Used to host the web application
