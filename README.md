# Animal Shelter

### By Eusebie Siebenberg

## Description

Independent Code Review project: Build an API for a local animal shelter to list available cats and dogs, using C#/.NET technologies, with full CRUD functionality, also implementing Further Exploration objectives such as API Versioning, Pagination.
This API allows the user to Get, Create, Update and Delete availabe listings.

[API Usage](#using-this-api)

[API Query Table](#example-urls-for-a-get-request-on-animals-these-urls-have-v2-as-the-api-version-simply-change-this-to-v1-to-use-versioning)

[Example JSON Snippets](#example-for-a-post-request-post-httpslocalhost5001apiv2animals)

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MVC
* Entity Framework Core
* Pomelo Entity Framework Core
* EF Core Migrations
* Swashbuckle
* Swagger
* MySQL
* API Versioning
* API Pagination

## Setup/Installation Requirements

1. Open your shell of choice (e.g., Terminal or GitBash) and run these commands in order:
2. Clone this repository by running $ `git clone https://github.com/user/examplerepo.git` (replace url with link copied from github)
3. Navigate to the root directory call `AnimalShelterApi.Solution`, Create a `.gitignore` file with $ `touch .gitignore`, copy/paste this into the .gitignore file:
```
obj
bin
appsettings.json
```
4. Navigate to this project's production directory called `AnimalShelterApi` with $ `cd AnimalShelterApi`.
5. Within the production directory create a new file called `appsettings.json` with $ `touch appsettings.json`.
6. Within `appsettings.json`, paste in the following code, replacing `user-id`, and `password` with your own username and password for MySQL Workbench.
(remove square brackets when inputting your details):
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[user-id];pwd=[password];"
  }
}
  ```
7. Set up the **Database**:
  * Within the production directory `AnimalShelterApi` run: $ `dotnet ef database update` to generate the database
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench on refresh called `animal_shelter_api`

8. In the production directory run `dotnet watch run`
  * It should open automatically open SwaggerUI in your browswer, and also give you access to the API in Postman: 
  * If it does not open Swagger automatically, simply paste this in your broswer: https://localhost:5001/swagger/index.html 
  * Use the Swagger GUI to navigate the API
  * To access the API in **Postman**, use the URLs listed below for each query.

## Using This API

* Further Exploration 1 - `API Versioning` is enabled, which defaults to API v2 when Swagger opens. Simply use the Swagger `Select a definition` drop down options list to select API v1. Versioning is important because when we make breaking changes in the future, we can push these changes to a new version, and retain an original version for enterprises that can't update to Version 2 just yet.
* To access API v1 in Postman: `https://localhost:5001/api/v1/animals/` 
* To access API v2 in Postman: `https://localhost:5001/api/v2/animals/`

* Further Exploration 2 - `Pagination` is also enabled for this API. This feature makes it possible to streamline accessing a database which may have thousands of records, with Pagination, we can return only a selection of the results.
* Endpoint examples for Page Number and Page Size are given in the table below to test this feature, where: the `pageNumber` parameter will specify how many pages will return, the `pageSize` parameter will specify how many animal results per page are displayed.
* NOTE - `Pagination` is **ONLY** enabled for API v2! We are making this feature change only available to companies who can update their API to v2.

```
Endpoints:
GET /api/v2/animals/
GET /api/v2/animal/{id}
POST /api/v2/animals/
PUT /api/v2/animals/{id}
DELETE /api/v2/animals/{id}
```
## Example URLs for a GET Request on **Animals**: (these URLs have `v2` as the API version, simply change this to `v1` to use Versioning) 

| Parameter  | Type   | Required     | Description                                      | Sample Url  |
|----------- |-----   | ---------    | -------------                                    | ----------  |
| Animals    | List   | not required | Returns a list of all animals in database        | https://localhost:5001/api/v2/animals |
| Name       | String | not required | Returns animals with a matching name value       | https://localhost:5001/api/v2/animals?name={ANIMALNAME} |
| ID         | Int    | required     | Returns animals with a matching ID               | https://localhost:5001/api/v2/animals/{ID} |
| Species    | String | not required | Returns animals with a matching species value    | https://localhost:5001/api/v2/animals?species={SPECIES} |
| Breed      | String | not required | Returns animals with a matching climate value  | https://localhost:5001/api/v2/animals?breed={BREED} |
| Age        | Int    | not required | Returns animals with a matching age value | https://localhost:5001/api/v2/animals?age={NUMBER} |
| Random     | boolean| not required | Returns a random animal, Default is False       | https://localhost:5001/api/v2/animals?random={TRUE} |
| Page Number + Page Size | int, int | not required | Returns an animals list with user selected page number & page size | https://localhost:5001/api/v2/animals?pageNumber={PAGENUMBER}&pageSize={PAGESIZE} |

### Example for a POST request: POST https://localhost:5001/api/v2/animals

  * When using POST (create), a body with populated fields is required:
  * Note: when using POST in Swagger, be sure to remove the `"animalId": ,"` field, as it is automatically added at the top of the body. In POSTMAN, simply copy/paste the below example with your own paramaters to add an animal to the database:
      ```
      { 
        "name": "Whiskers",
        "species": "Cat",
        "breed": "Bengal",
        "age": 4
      }
      ```
### Example for a PUT request: PUT https://localhost:5001/api/v2/animals/{ID}

  * When using PUT (to update or modify an existing database entry), the ID of the entry is required at the end of the URL, and in the body, along with updated fields:
      ```
      { 
        "animalId": 10,
        "name": "Bicker",
        "species": "Dog",
        "breed": "Chihuahua",
        "age": 11 
      }
      ```
### To simply DELETE an entry, include the ID at the end of the url: DELETE https://localhost:5001/api/v2/animals/{ID}

[Back to Top](#animal-shelter)

## Known Bugs

No known bugs as of 6/9/23

## [MIT](https://opensource.org/license/mit/) License 

Copyright © 2023 Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

If you have any questions, comments, or concerns, please reach out to me at: siebenee@gmail.com