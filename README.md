Human Resource Management System (HRMS)
Project Overview
The Human Resource Management System (HRMS) streamlines HR processes through two components:

Admin Site: Manage employee data, leave requests, payroll, and HR operations.
User Site: Employees can access their profiles, submit leave requests, and view payroll info.
The system uses .NET Core for the backend, Next.js for the frontend, and JWT-based authentication with role-based authorization.

Features
Employee management
Leave request approval/rejection
Payroll management
Role-based access control (Admin, Employee)
Technology Stack
Backend: .NET Core, C#, Entity Framework Core, SQL Server
Frontend: Next.js, TypeScript
Authentication: JWT Bearer Authentication
Password Hashing: BCrypt
Setup Instructions
Prerequisites
.NET 6 SDK
SQL Server
Node.js
npm or pnpm
1. Clone the Repository
bash
Copy code
git clone https://github.com/your-username/hr-management-system.git
cd hr-management-system
2. Backend Setup
Configure the connection string in HRManagementAPI/appsettings.json:
json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HRManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Run database migrations:
bash
Copy code
cd HRManagementAPI
dotnet ef database update
Start the backend:
bash
Copy code
dotnet run
3. Frontend Setup
Navigate to the frontend folder and install dependencies:
bash
Copy code
cd HRManagementFrontend
npm install
Update the API URL in .env.local:
arduino
Copy code
NEXT_PUBLIC_API_URL=http://localhost:5000
Start the frontend:
bash
Copy code
npm run dev
4. Access the Application
Backend API: http://localhost:5000
Frontend: http://localhost:3000
Authentication
Use JWT tokens for authentication. Include the token in the Authorization header for protected routes.

Example:

makefile
Copy code
Authorization: Bearer <your-jwt-token>
Development Phases
Database design and implementation
Backend API development
Frontend integration
JWT-based authentication
Testing and debugging
License
This project is licensed under the MIT License.
