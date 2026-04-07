**Features Implemented as Part of Learning**

📌 Project Title
# Employee Management API

📖 Description
This is a .NET Web API project for managing employees with secure authentication and role-based authorization.
The project follows a layered architecture and includes JWT authentication, validation, and global exception handling.

🚀 Features
- Employee CRUD operations
- JWT Authentication
- Role-based Authorization (Admin/User)
- User Registration & Login
- Password Hashing using BCrypt
- FluentValidation for input validation
- Global Exception Handling
- Standard API Response Model
- Swagger API Documentation

🛠️ Tech Stack
- .NET 8 Web API
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- FluentValidation
- BCrypt.Net
- Swagger (Swashbuckle)

📂 Project Structure
Controllers/
Services/
Repository/
Data/
Models/
DTOs/
Common/
Middleware/

🔐 Authentication
- Login to get JWT token
- Use token in Swagger Authorize button:
Bearer <your_token>

📌 API Endpoints
### Auth
POST /api/auth/register
POST /api/auth/login

### Employees
GET /api/employee
GET /api/employee/{id}
POST /api/Add employee   (Admin only)
PUT /api/Update employee
DELETE /api/Delete employee/{id}

▶️ How to Run
1. Clone the repository
2. Configure PostgreSQL connection string in appsettings.json
3. Run migrations:
   dotnet ef database update
4. Run the project:
   dotnet run
5. Open Swagger:
   https://localhost:7093/swagger

