<div align="center">

# Annie's Animal Shelter Guest Tracker v1.0

</div>

<div align="center">
<img src="https://github.com/jeffchiudev.png" width="200px" height="auto" style="border-radius: 15px 50px;">

</div>
<h3 align="center">Tracking boarded animals until they find their forever home, 22.Jan.2021</h3>
<h4 align="center"> By Jeff Chiu</h4>


## About: 

### Description

Animal shelters are already doing so many things to help ownerless animals find thier forever home.  Keeping a  list of the animals currently boarding at the shelter will help workers determine which ones need the most attention to help get adopted.  

### Technologies Used

- Windows 10
- Visual Studio Code
- C# 7.3
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Postman
- Swagger - Swashbuckle 5.5.0

### User Stories:
| ID | User Story | Accepted |
| :--------: | :------: | :-------: |
||||

### Known Bugs

This is a prototype API.

## Software Requirements

### Browser Requirements: 
1. Internet browser of choice, [Chrome](https://www.google.com/chrome/?brand=CHBD&brand=FHFK&gclid=CjwKCAiA_9r_BRBZEiwAHZ_v19Z0_XYzZ8NiG2AyZJ9A8ZVQjOBCYIuyRcS3Muc41TZCA_PL0n3s6hoCiaEQAvD_BwE&gclsrc=aw.ds) recommended.
2. A code editor such as [VSCode](https://code.visualstudio.com/) or [Atom](https://atom.io/).
3. Install .NET core: [MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) & [PC](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer).
4. Install MySQL: [MacOS](https://dev.mysql.com/downloads/file/?id=484914) & [PC](https://dev.mysql.com/downloads/file/?id=484919).
5. Install MySQL Workbench: Find appropriate version [here](https://dev.mysql.com/downloads/workbench/).

### Install Postman

[Download Here](https://www.postman.com/downloads/)

### Open Locally

1. Click on the link to repository on github [here](https://github.com/jeffchiudev/TODO). 
2. Click on the green "Code" link near the top and above the README.md.
3. Alternatively open your terminal and use the command `git clone https://github.com/jeffchiudev/TODO` into the directory you would like to clone the repository.
4. Open in text editor to view code.

### Installing .NET Core

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

## API Documentation

Explore endpoints in Swagger, Postman or broser

### Using Swagger

1. To explore the API with Swashbuckle launch project with `dotnet watch run` within terminal.
2. Input `http://localhost:5000/swagger`

### Endpoints

Base URL: `https://localhost:5000'

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Query Example
```
https://localhost:5000/api/TODO/131
```

#### Sample JSON
```
{
    "Id": 1,
    "Key1": "Value1",
    "Key2": "Value2",
}
```
## Support and Contact Details

If any errors or bugs occur please email me [here](jeffchiudev@gmail.com).

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

<img src="https://apprecs.org/gp/images/app-icons/300/7c/air.capoo.jpg" width="1%" height="auto" style="border-radius: 50%"> Copyright (c) 2021 Jeff Chiu 