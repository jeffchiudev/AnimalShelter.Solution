<div align="center">

# Annie's Animal Shelter API v1.0

<img src="https://github.com/jeffchiudev.png" width="200px" height="auto" style="border-radius: 15px 50px;"><br>
________________________
<h3>Tracking boarded animals until they find their forever home, 22.Jan.2021</h3>
<h4> By Jeff Chiu</h4>
</div>

## About: 

### 📖 Description

Animal shelters are already doing so many things to help ownerless animals find their forever home.  Keeping a  list of the animals currently boarding at the shelter and potential fostering parents will make sure the animals are in good care until they find their new home.  

### 🕹️Technologies Used

- Windows 10
- Visual Studio Code
- C# 7.3
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Postman
- NSwag.AspNetCore

### 🐛 Known Bugs

This is a prototype API

## 🎛️ Software Requirements

### Browser Requirements: 
1. Internet browser of choice, [Chrome](https://www.google.com/chrome/?brand=CHBD&brand=FHFK&gclid=CjwKCAiA_9r_BRBZEiwAHZ_v19Z0_XYzZ8NiG2AyZJ9A8ZVQjOBCYIuyRcS3Muc41TZCA_PL0n3s6hoCiaEQAvD_BwE&gclsrc=aw.ds) recommended.
2. A code editor such as [VSCode](https://code.visualstudio.com/) or [Atom](https://atom.io/).
3. Install .NET core: [MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) & [PC](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer).
4. Install MySQL: [MacOS](https://dev.mysql.com/downloads/file/?id=484914) & [PC](https://dev.mysql.com/downloads/file/?id=484919).
5. Install MySQL Workbench: Find appropriate version [here](https://dev.mysql.com/downloads/workbench/).

### Install Postman

[Download Here](https://www.postman.com/downloads/)

### Open Locally

1. Click on the link to repository on github [here](https://github.com/jeffchiudev/AnimalShelter.Solution). 
2. Click on the green "Code" link near the top and above the README.md.
3. Alternatively open your terminal and use the command `git clone https://github.com/jeffchiudev/AnimalShelter.Solution` into the directory you would like to clone the repository.
4. Open in text editor to view code.

### Installing .NET Core

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

### AppSettings

1. Create a new file in the `AnimalShelter.Solution/AnimalShelter` directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": 
    {
        "DefaultConnection": "Server=localhost;Port=3306;database=coffee_tracker_api;uid=root;pwd=YourPassword;"
    }
}
```
3. Change server, port and Id as necessary.  

### Create Database & Launch

1. Navigate to `AnimalShelter.Solution/AnimalShelter` in terminal. 
2. Run command `dotnet ef database update` to generate database through Entity.
3. Run command `dotnet watch run` to access API within postman.


## 📝 API Documentation

Explore endpoints in Swagger, Postman or browser

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
https://localhost:5000/api/animals/1
```

#### Sample JSON
```
{
    "animalId": 3,
    "animalName": "Lester",
    "species": "Cat",
    "breed": "American Shorthair",
    "gender": "Male",
    "age": 6
}
```

### Animals 
For accessing information on animals within the shelter

#### HTTP Request Structure
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals/{id}
```
#### Path Paramters
| Parameter | Type | Default | Required | Description |
| :--: | :--: | :--: | :--: | :--: | :--: |
| Species | string | none | false | Matches by species e.g. dog |
| Breed | string | none | false | Matches by breed e.g. Spitz |
| Gender | string | none | false | Matches by gender e.g. Male |

#### Example Query
```
http://localhost:5000/api/animals/?species=dog&gender=male&breed=spitz
```
#### Sample JSON Response
```
{
    "animalId": 1,
    "animalName": "Bartleby",
    "species": "Dog",
    "breed": "Spitz",
    "gender": "Male",
    "age": 2
}
```

### Fosters
For accessing information on potential fosters

#### HTTP Request Structure
```
GET /api/fosters
POST /api/fosters
GET /api/fosters/{id}
PUT /api/fosters/{id}
DELETE /api/fosters/{id}
```
#### Sample JSON Response
```
{
    "fosterId": 1,
    "fosterName": "Jeff",
    "fosterEmail": "jeff@test.com",
    "fosterAvailability": true
}
```

## Support and Contact Details

If any errors or bugs occur please email me [here](jeffchiudev@gmail.com)

For bugs or pull requests click [here](https://github.com/jeffchiudev/AnimalShelter.Solution/issues)

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

<img src="https://apprecs.org/gp/images/app-icons/300/7c/air.capoo.jpg" width="1%" height="auto" style="border-radius: 50%"> Copyright (c) 2021 Jeff Chiu 