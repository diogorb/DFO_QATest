# DFO_QATest
DFO_QATest Challange
Author: Diogo Barbosa
This project was made as a technical challenge; i made a simple API to make the backend to User API, using in memory database.
This is a very simple project composed of an API that creates users with only 4 fields (Id, Name, Age, Address), being: ID a primary key / identity (using annotation key in the code), Name is a required field (not null), Age also a required field and Address is nullable.
Name and Address should be limited to 50 charachters, what was accomplished by the [StringLength(50)] annotation.
The Crud operations are documented in Postman collection at this same folder, accomplishing and testing the requested validations.

"Put your code on GitHub and send us the instructions to install and execute your project. "
Just run the project using VS2019 and use the Postman Collections to access endpoints.

Example of the endpoints (ports might change dinamically):
https://localhost:44384/api/Users 
https://localhost:44384/api/Users/1 

Example of body: 
{
  "name":"UserName com até 50 char, 2!",
  "age":36,
  "address":"Rua da realização, colado com o desafio"
}

OBS: Did not document the delete but it's also done.
