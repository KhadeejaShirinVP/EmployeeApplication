Employee API (.NET 8)
📌 Project Overview

This is a simple Employee Management API built using ASP.NET Core Web API.
It supports basic CRUD operations and is structured using clean architecture principles.

🚀 Features
Get all employees
Get employee by ID
Add new employee
Update employee
Delete employee
Swagger UI integration
🧱 Tech Stack
.NET 8 Web API
C#
Swagger (Swashbuckle)
Dependency Injection
📁 Project Structure

EmployeeApi/
│
├── Controllers/
├── Models/
├── Repository/
├── Services/
├── Program.cs

▶️ How to Run
Clone the repository:
git clone https://github.com/KhadeejaShirinVP/EmployeeApplication.git
Navigate to project:
cd EmployeeApi
Run the project:
dotnet run
Open Swagger:
https://localhost:<port>/swagger
🔗 API Endpoints
Method	Endpoint	Description
GET	/api/employee	Get all employees
GET	/api/employee/{id}	Get employee by ID
POST	/api/employee	Add new employee
PUT	/api/employee	Update employee
DELETE	/api/employee/{id}	Delete employee
