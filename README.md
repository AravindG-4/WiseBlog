# 📝 Blazor Blogging Platform

A feature-rich blogging platform built with **.NET**, **Blazor WebAssembly**, **MudBlazor**, and **ASP.NET Core API**. This platform enables users to create, manage, and interact with blogs efficiently, featuring AI-powered tools and seamless authentication using **Supabase and JWT session management**.

---

## 🌟 Features

- **🔐 User Authentication & Management**  
  - Supabase authentication with JWT session management  
  - User profile management  

- **📰 Blogging System**  
  - Create, edit, and delete blogs  
  - AI-powered blog summarization & blog writing helper using **Mistral API**  
  - Rich text editing with **Quill.js**  

- **👥 Social Features**  
  - Follow/unfollow other users  
  - Followers & following lists  

- **🏠 Home & Blog Pages**  
  - **RSS Feed Integration** for the latest blog updates  
  - Individual blog detail pages  

- **📦 Data Storage**  
  - **MongoDB Atlas** for user & application-related data storage  
  - MongoGridFS for optimized image storage  

---

## ⚡ Tech Stack

| Technology  | Purpose |
|-------------|---------|
| **.NET 8**  | Core framework |
| **Blazor WebAssembly** | Frontend UI |
| **MudBlazor** | UI components & styling |
| **Bootstrap** | Additional responsive design |
| **ASP.NET Core API** | Backend & business logic |
| **Supabase** | User authentication & session management |
| **MongoDB Atlas** | Database for blogs, users, and metadata |
| **Mistral AI API** | AI-powered blog writing & summarization |
| **Quill.js** | Rich text editor for blog creation |

---

## 🚀 Installation & Setup

### **Prerequisites**
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- [MongoDB Atlas Account](https://www.mongodb.com/atlas/database)  
- [Supabase Account](https://supabase.com/)  

1️⃣ Clone the Repository
```sh
git clone https://github.com/AravindG-4/WiseBlog.git
cd WiseBlog

2️⃣ Configure Environment Variables
Create an appsettings.json file inside the Server project and add the following:

{
  "Supabase": {
    "Url": "https://your-supabase-url.supabase.co",
    "Key": "your-supabase-key"
  },
  "MongoDB": {
    "ConnectionString": "your-mongodb-connection-string",
    "DatabaseName": "BlogDB"
  },
  "AI": {
    "MistralAPIKey": "your-mistral-api-key"
  },
  "JWT": {
    "Secret": "your-jwt-secret",
    "Issuer": "your-app",
    "Audience": "your-app-users"
  }
}

3️⃣ Build & Run the Application
Backend (ASP.NET Core API)

cd Server
dotnet run
Frontend (Blazor WebAssembly)

cd Client
dotnet run

The application will be available at:
👉 Frontend: http://localhost:7166
👉 Backend API: http://localhost:7289

🤝 Contributing
Contributions are welcome! Feel free to submit a pull request.

Let me know if you need any modifications! 🚀😊






