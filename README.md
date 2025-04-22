# 📚 Student API — My First ASP.NET Core Web API  

A simple **ASP.NET Core Web API** for managing student records. Built for learning RESTful APIs, documentation, and best practices. Uses an **in-memory database** (no setup required!).


## ✨ Features

- ✅ **Get all students**
- 🎯 **Filter students** (passed/failed)
- 🔍 **Find a student by ID**
- ➕ **Add new students**
- ✏️ **Update existing student records**
- 🗑️ **Delete students by ID**


## 🔍 What’s Inside?  
**Endpoints to play with:**  

| Action          | Endpoint                     | Method |
|-----------------|------------------------------|--------|
| Get all students | `/api/students`             | `GET`  |
| Get passed students | `/api/students/passed`  | `GET`  |
| Get failed students | `/api/students/failed`  | `GET`  |
| Find by ID      | `/api/students/{id}`         | `GET`  |
| Add a student   | `/api/students`             | `POST` |
| Update a student| `/api/students/{id}`         | `PUT`  |
| Delete a student| `/api/students/{id}`         | `DELETE` |


## 🛠️ Technologies Used

- **ASP.NET Core Web API** (RESTful design)
- **Visual Studio IDE**
- **Postman** (API testing)
- **Swagger** (API documentation & testing)


## 🎯 How to Run  
1. Clone the repo:  
2. Start the API:  

✨ **Tip**: Use Postman or Swagger to test endpoints!  



## 🧠 Key Learnings  
- **RESTful routing**: Structured URLs like `GET /api/students/{id}`  
- **Separation of concerns**: Controllers vs. services  
- **Swagger**: Auto-generated API docs  


## 🌱 Next Learning Steps  
- Add validation (e.g., "Grade must be 0–100")  
- Experiment with authentication  
