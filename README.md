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

## Project specification
* Centralized database
* API to store and retrieve the data
* Module/s to receive requests from users
* AI module to send responses
* Desktop app to monitor the status and health of the system and requests made by users
* Mobile and/or web app (with similar features as the desktop one)



Symbol | Name | Short description | Responsible 
------ | ----- | -----------| -------------------
F01    | Login   | Login with user credentials| Lidija Pitić
F02    | Web Form | Web Form design and implementation of fetching data| Lidija Pitić
F03    | Fetching e-mail | Fetching e-mail from e-mail server and forwarding it to the next module | Lidija Pitić
F04    | [AI] Extracting data | Extracting keywords from e-mail text and forwarding it to the next module | Josip Rosandić
F05    | API1 - processing form data | Receiving data from web form and shaping it into proper response | Zdenko Pečena
F06    | API2 - processing data from email | Processing e-mail data and shaping it into proper response | Zdenko Pečena
F07    | API3 - DB | Communication with database | Josip Rosandić
F08    | WinForm1 - Win Forms app for user | Win Forms app with templates and possibility for problems resolution | Mario Pernar
F09    | WinForm2 - CRUD properties | Creating and deleting properties and units | Mario Pernar
F10    | WinForm3 - CRUD templates | Creating and deleting email templates | Mario Pernar
F11    | Database | Database implementation | Mario Pernar

## Technologies and tools
* Microsoft Visual Studio 2019
* Microsoft SQL Server Studio 2018
* Visual Paradigm Online
* Microsoft Office Word 
