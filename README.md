# AI for Renters APP
Software product made @ Faculty of Organization and Informatics, University of Zagreb in collaboration with [Arbona](https://www.arbona.hr) company with mentorship of Mr Hrvoje Galić from Arbona, and Asst.prof. Zlatko Stapić, PhD from FOI.


## Project team

Name and surname | E-mail adress (FOI) | Student ID | Github username
------------     | ------------------- | -----      | ---------------------
Mario Pernar     |    mpernar@foi.hr   | 0016131362 | mpernar
Lidija Pitić     |    lpitic@foi.hr    | 0016132354 | lpitic
Josip Rosandić   |    jrosandic@foi.hr | 0016129731 | jrosandic
Zdenko Pečeňa    |     zpecena@foi.hr  | 0016146255 | zpecena

## Domain description
The general idea of the system is to be able to automatically respond to the requests sent through different channels (e.g. web form and e-mail) and to give an answer in regards with the property availability for the requested time slot. The availability is checked in the database, and if the time slot is not free the system should propose a different time slot. The system should provide the means of defining the response template in English language.

## Project specification
* Centralized database
* Module/s to receive requests from users
* Module/s to process user data
* AI module to send responses
* Desktop app to monitor the status and health of the system and requests made by users


Symbol | Name | Short description | Responsible 
------ | ----- | -----------| -------------------
F01    | Login   | Login with user credentials| Lidija Pitić
F02    | Web Form | Web Form design and implementation | Lidija Pitić, Josip Rosandić
F03    | Fetching e-mail | Fetching e-mail from e-mail server, forming ReceivedData object and forwarding object to the next module | Lidija Pitić
F04    | [AI] Extracting data | Extracting keywords from e-mail text, forming ProcessedData object and forwarding it to the next module | Josip Rosandić
F05    | Communication with database | Entity Framework data layer for communication with DB | Mario Pernar
F06    | Analisys of ProcessedData regarding database context data  | Searching database context for appropriate result according to ProcessedData and fetching result | Zdenko Pečena
F07    | WinForms app for user | Win Forms app with CRUD for entity classes (templates, units, properties) and possibility for problems resolution | Mario Pernar
F08    | Database | Database implementation | Mario Pernar

## Technologies and tools
* Microsoft Visual Studio 2019
* Microsoft SQL Server Studio 2018
* Visual Paradigm Online
* DrawIO
* GitHub code versioning system
