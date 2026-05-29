# 🛒 Online Shopping System

![VB.NET](https://img.shields.io/badge/Visual_Basic_.NET-100%25-512BD4?logo=dotnet&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow)

A desktop-based **Online Shopping System** built with **Visual Basic .NET** for the frontend and **SQL** for the backend database. An end-to-end platform that simulates a real-world e-commerce experience — browse products, manage a cart, and place orders — all from a desktop application.

---

## 📌 Overview

This project is a Windows Forms application that replicates the core functionality of an online shopping platform. Users can browse available products, add items to a shopping cart, and complete purchases — without needing to visit a physical store. The system manages product data, customer information, and order records through a structured SQL database.

---

## 🎯 Features

- 🛍️ **Product Browsing** — view available items with details and pricing
- 🛒 **Shopping Cart** — add, update, and remove items before checkout
- 👤 **Customer Management** — register and manage customer profiles
- 📦 **Order Processing** — place and track orders through the system
- 🗄️ **SQL Database Integration** — all data persisted in a relational database
- 🖥️ **Windows Forms UI** — clean desktop interface built with VB.NET

---

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| Visual Basic .NET | Frontend — Windows Forms desktop UI |
| SQL Server | Backend — relational database for products, orders, customers |
| .NET Framework | Application runtime |
| Visual Studio | IDE & solution management |

---

## 🗂️ Project Structure

```
online-shopping-system/
│
├── online shopping system/     # Main VB.NET project folder
│   ├── Forms/                  # Windows Forms (.vb UI files)
│   ├── Modules/                # Business logic and DB connection
│   └── Resources/              # Images and assets
│
├── online shopping system.sln  # Visual Studio solution file
├── .gitattributes
├── .gitignore
└── README.md
```

---

## ⚙️ Getting Started

### Prerequisites

- Windows OS
- Visual Studio (2019 or later recommended)
- SQL Server or SQL Server Express
- .NET Framework 4.x

### 1️⃣ Clone the repository

```bash
git clone https://github.com/bettykgeorge/online-shopping-system.git
```

### 2️⃣ Set up the database

- Open **SQL Server Management Studio (SSMS)**
- Create a new database (e.g. `OnlineShoppingDB`)
- Run the SQL scripts to create tables for products, customers, and orders

### 3️⃣ Configure the connection string

In the project's database module, update the connection string to point to your SQL Server instance:

```vb
Dim connStr As String = "Data Source=YOUR_SERVER;Initial Catalog=OnlineShoppingDB;Integrated Security=True"
```

### 4️⃣ Open and run the project

- Open `online shopping system.sln` in Visual Studio
- Build the solution (`Ctrl+Shift+B`)
- Run the application (`F5`)

---

## 🖥️ Screenshots

   <img width="960" height="558" alt="image" src="https://github.com/user-attachments/assets/82af9b33-129c-416e-acfb-88df07ab41d3" />
<img width="960" height="575" alt="image" src="https://github.com/user-attachments/assets/e1e6e93d-621b-4b14-b535-7d24e65c6f19" />
<img width="960" height="634" alt="image" src="https://github.com/user-attachments/assets/0763445f-1091-4217-928d-6cbe97642f25" />
<img width="960" height="433" alt="image" src="https://github.com/user-attachments/assets/54ee99d6-b50f-49a1-a3d5-b50a1a2245df" />
<img width="960" height="433" alt="image" src="https://github.com/user-attachments/assets/cab0e768-b475-4274-a238-f8afd4cb9fde" />
<img width="960" height="515" alt="image" src="https://github.com/user-attachments/assets/3bdb5aac-0f12-46fb-875e-36bd767747c5" />
<img width="960" height="617" alt="image" src="https://github.com/user-attachments/assets/2f835269-66ba-48af-aed1-15c84f58abab" />
<img width="960" height="632" alt="image" src="https://github.com/user-attachments/assets/af1eb329-59fa-44f4-aa7b-02ffec0c2d12" />
<img width="960" height="601" alt="image" src="https://github.com/user-attachments/assets/cfe31020-01c5-43a9-ae93-0ce80f151c2f" />
<img width="960" height="584" alt="image" src="https://github.com/user-attachments/assets/181ec8b0-a3fd-47b0-833d-0393671047aa" />
<img width="960" height="537" alt="image" src="https://github.com/user-attachments/assets/cef94b00-cc4d-4301-b88d-5d7275bcfa46" />
<img width="960" height="568" alt="image" src="https://github.com/user-attachments/assets/e2d04074-d743-4780-b288-56ba91c0f223" />
<img width="960" height="568" alt="image" src="https://github.com/user-attachments/assets/8921ce87-2e70-46e3-97de-945194a6d836" />


## 🔮 Future Improvements

- [ ] Add user authentication and login system
- [ ] Implement search and filter for products
- [ ] Generate order receipts / invoices as PDF
- [ ] Migrate to a web-based frontend
- [ ] Add admin panel for inventory management

---

## 🧠 Key Concepts Demonstrated

- Windows Forms application development with VB.NET
- CRUD operations with SQL Server (Create, Read, Update, Delete)
- Database connectivity using ADO.NET
- Relational database design (products, customers, orders)
- Event-driven programming with form controls

---

## 👩‍💻 Author

**Betty K George**

[![GitHub](https://img.shields.io/badge/GitHub-bettykgeorge-181717?logo=github)](https://github.com/bettykgeorge)

---

## 📌 License

This project is for academic and learning purposes.
