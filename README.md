# Animal Shelter
#### _By John Diggins_
<br>

## Technologies Used
* Asp.Net Core
* EF Core
* C#
* Swashbuckle/ Swagger
* RestSharp
* Newtonsoft

## Description
This program is a basic API for accessing data on a database.  More specifically it accesses pets at a shelter.  You can get their name, age, gender and species (cat or dog).

## Versioning
Versioning has been implemented in a very basic way.  V1 animals search can take 2 search parameters: `name` and `species`.  V2 adds a search parameter for `minimumAge`, so a search can be made specific to querying for older pets. V1 and V2 can easily be selected from the dropdown menu at the top of Swagger, or from entering it in the URL as demonstrated below under _Endpoints_; as a $`curl` command or from Postman. 
 

## Running This Project
1. Clone this project.
2. Navigate to the project folder AnimalShelter.Solution/ShelterAPI
3. Create appsettings.json and make sure to add your password where indicated:
```
{
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=ShelterApi;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
```
4. enter $`dotnet ef database update`.
5. enter $`dotnet watch run`.


## Making API Calls
* Make API calls from the command line with $`curl`; from your browser with swagger, which should load automatically when you run the program; or from Postman. 

### Endpoints
- (v1) GET http://localhost/api/v1/animals [includes optional search query parameters `name` and `species`]
- (v1) POST http://localhost/api/v1/animals
- (v1) GET http://localhost/api/v1/animals/{id}
- (v1) PUT http://localhost/api/v1/animals/{id}
- (v1) DELETE http://localhost/api/v1/animals/{id}
- (v2) GET http://localhost/api/v2/animals [includes `name`, `species`, and additionally `minimumAge`]
- (v2) [all remaining verbs have the same functionality as v1]


### Optional Query String Parameters for GET Request
|**Parameter**  | **Type**   | **Required** | **Description**                               |
|-------------|--------|----------|-------------------------------------------|
| name     | String     | no         | Returns animals with matching name value  
| species        | String     | no         | Returns animals with matching species value
| minimumAge  |Int         | no         | _**v2 only**_  Returns only animals older than entered value

* `{id}` should be replaced by the int id of the animal to apply the action to.
* for PUT requests, make sure to include the {id} you intend to change and any optional values you'd like to change. 
* for POST requests, the {id} can be left at 0 as it will self increment.  The rest of the body is required. 

## Known Bugs
none

#### License
##### [MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)
##### Copyright (c) 2023 John Diggins
