# AI for Renters APP
Software product made @ Faculty of Organization and Informatics, University of Zagreb in collaboration with [Arbona](https://www.arbona.hr) company with mentorship of Mr Hrvoje Galić from Arbona, and Asst.prof. Zlatko Stapić, PhD from FOI.


## Project team

Name and surname | E-mail adress (FOI) | Student ID | Github username
------------     | ------------------- | -----      | ---------------------
Mario Pernar     |    mpernar@foi.hr   | 0016131362 | mpernar
Lidija Pitić     |    lpitic@foi.hr    | 0016132354 | lpitic
Josip Rosandić   |    jrosandic@foi.hr | 0016129731 | jrosandic
Zdenko Pečeňa    |     zpecena@foi.hr  |            | zpecena

## Domain description
The general idea of the system is to be able to automatically respond to the requests sent through different channels (e.g. web form, e-mail, ...) and to give an answer in regards with the property availability for the requested time slot. The availability is checked in the database, and if the time slot is not free the system should propose a different time slot. The system should provide the means of defining the response template in English language.

**System modules:**
#| Module|Short description
-----|-----|-----
1    | ASP.NET web Form | Web UI for reserving rooms
2    | Email fetcher | Fetching emails from the server 
3    | Response processor | Processing emails and shaping requests
4    | Availability validator | Searching for optimal solution in the database and fetching appropriate template
5    | WinForms app | Contains GUI for interaction with the application and database ORM layer
6    | Database | MS SQL Server database with all needed entities




Symbol | Name | Short description | Responsible 
------ | ----- | -----------| -------------------
F01    | Login   | Login with user credentials| Lidija Pitić
F02    | Web Form | Web Form design and implementation of sending JSON data to e-mail server | Lidija Pitić
F03    | Fetching e-mail | Fetching e-mail from e-mail server, forming ReceivedData object and forwarding object to the next module | Lidija Pitić
F04    | [AI] Extracting data | Extracting keywords from e-mail text, forming ProcessedData object and forwarding it to the next module | Josip Rosandić
F05    | Communication with database | Entity Framework data layer for communication with DB | Zdenko Pečena
F06    | Analisys of ProcessedData regarding database context data  | Searching database context for appropriate result according to ProcessedData and fetching result | Zdenko Pečena
F07    | WinForms app for user | Win Forms app with CRUD for entity classes (templates, units, properties) and possibility for problems resolution | Mario Pernar
F08    | Database | Database implementation | Mario Pernar

## Technologies and tools
* Microsoft Visual Studio 2019
* Microsoft SQL Server Studio 2018
* Visual Paradigm Online
* Microsoft Office Word 
