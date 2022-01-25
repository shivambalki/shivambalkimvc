# shivambalkimvc
My first Model View Controller application to perform CRUD operation.

This is a User Details web form which comes with functionalites that are used to record user responses and store it in database.


## Model View Controller:
- Model represents the domain specific data and business logic in MVC architecture. It maintains the data of application.
	
- View is a user Interface , view displays the data from the model to the user.
	
- Controller and its actions method handles incoming browser requests, retrieves necessary model data and returns appropriate responses.


# Asp.Net Core Web app using C#

Learnings:
 - How to create Web app  in Asp.Net Core(MVC) in Visual Studio.
 - Use Case of Model , View and Controller in Asp.Net Core.
 - To validate user input over parameters such as (Required field and custom validation)
 - Working live on aspx , Web UI and setting up Javascript and Bootstrap.
 - Database connectivity and events on aspx design and study pf Edmx file and managing Data.


## Controls:




| Parameter | Type     | Description                | Regex|
| :-------- | :------- | :------------------------- | :-------------|
| Required Field | `Validator ` | Field cannot be empty|*
| Email Field | `Validator ` | Field cannot be empty|\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*
| Range Field | `Validator ` | Field cannot be empty| min value,max value
| Mobile Number | `Validator ` | Field cannot be empty| ^([7-9]{1})([0-9]{9})$

#### Asp controls used:

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| Label | `Element ` | To display Field name
| TextBox | `Element ` | To retrieve User input
| Button| `Element ` | To create Crud operation buttons
| Calender Control | `Element ` | To get user DOB input
| datatolist()| `Element ` | For displaying User's Input from Database





### Screenshots
## UI:
![datainput](https://user-images.githubusercontent.com/78531352/150919150-0c391981-877b-4bc8-a79b-1304b46abd40.PNG)

![Shivam MVC](https://user-images.githubusercontent.com/78531352/150919193-3e82a9ef-b9bb-40d3-844e-e08cefa78f2f.png)


## ASP controls-

![edit](https://user-images.githubusercontent.com/78531352/150919175-bdf5ab30-7c7d-4900-aff8-cff5ad727fb6.PNG)

## Validation-

![validd](https://user-images.githubusercontent.com/78531352/150920374-46335344-f15c-4931-9b37-265b48c7cc4a.png)

![emphvalid](https://user-images.githubusercontent.com/78531352/150920350-f80bd3a7-f8ea-4a6b-b1e0-3610b1e447e8.png)


## Database-
![db](https://user-images.githubusercontent.com/78531352/150919169-aa8e5abd-da51-4ef5-8796-7a847a4b6d02.png)


![Model1 edmx](https://user-images.githubusercontent.com/78531352/150919181-1e7a032f-be15-4e88-835e-ca217a7bc021.png)


## Authors

- [@shivambalki](https://www.github.com/shivambalki)

