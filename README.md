# Human Resource Management System (HRMS)
A simple Web API for Human Resource Management System
## Project Overview
The Human Resource Management System (HRMS) streamlines HR processes through two components:
  - Admin Site: Manage employee data, leave requests, payroll, and HR operations
  - User Site: Employees can access their profiles, submit leave requests, and view payroll info<br>

The system uses .NET Core for the backend, and JWT-based authentication with role-based authorization
## Features
- Employee management
- Leave request approval/rejection
- Payroll management
- Role-based access control (Admin, Employee)
## Technology Stack
- Backend: .NET Core, C#, Entity Framework Core, SQL Server
- Authentication: JWT Bearer Authentication
- Password Hashing: BCrypt
- API Documentation: Swagger
## Setup Instructions
 **Prerequisites**
* .NET 8 SDK
* SQL Server
  
**1.** **Clone the Repository**

    git clone https://github.com/your-username/hr-management-system.git
    cd hr-management-system

**2.** **Backend Setup**
* Configure the connection string in HRManagementAPI/appsettings.json:

        "ConnectionStrings": {
            "DefaultConnection": "Server=YOUR_SERVER;Database=HRManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true"
        }
  
* Run database migrations:

        cd HRManagementAPI
        dotnet ef database update
* Start the backend:
  
        dotnet run

**3** **Access the Application**

- Backend API: http://localhost:5000 (Default)

## License
This project is licensed under the MIT License.


