# Restaurant Management System

## Overview
The Restaurant Management System is a comprehensive, feature-rich desktop application designed to streamline the management of restaurant operations. It offers a centralized platform for handling tasks like menu management, order processing, employee management, sales tracking, and customer data management. Built with C# Forms and the .NET Framework 4.72, this application also integrates a SQL Server database for efficient data storage and retrieval.

## Features

### Admin Dashboard
- **Centralized Management**: Admins can oversee all operations and manage system configurations from a single dashboard.
- **Employee Management**:
  - Add, edit, and delete employee records.
  - Monitor employee activities and manage their roles and permissions.
- **Food Item Management**:
  - Add, update, or remove food items from the menu.
  - Set prices, manage stock levels, and update item availability.
- **Sales Tracking**:
  - Monitor daily, weekly, and monthly sales data.
  - View reports on sales trends and food item performance.
- **Customer Management**:
  - View customer profiles, preferences, and feedback.
  - Track customer orders and visit history.

### Seller Dashboard
- **Food Item Management**:
  - Sellers can add, update, or remove items from the menu.
  - Update prices and availability based on stock levels.
- **Order Management**:
  - Create and modify customer orders quickly.
  - Track the status of customer orders (pending, in progress, completed).
- **Billing**:
  - Generate invoices and manage payments.
  - Track payment history and outstanding invoices.

### Authentication System
- **Login & User Authentication**:
  - The system supports login functionality for multiple users with distinct roles.
  - Admin and seller accounts have different levels of access.
  
### Reporting and Analytics
- **Sales Reports**:
  - Admins can generate detailed reports about total sales, revenue, and product performance.
- **Customer Feedback**:
  - Gather customer feedback through their order history to improve service and offerings.

## Technologies Used
- **C# Forms**: For creating the user interface and handling system logic.
- **.NET Framework 4.72**: To build the application with a stable and powerful framework.
- **SQL Server**: For data storage, including user credentials, sales records, and food inventory.


# Authors
- [Abdullah Shishir](https://github.com/shishir786)


# Installation Guide
### Prerequisites
Before running the system, make sure you have the following installed:
- **Visual Studio 2019 or later** (with support for C# and .NET Framework 4.72).
- **SQL Server**: You can use either SQL Server Express or a full version of SQL Server.
- **SQL Server Management Studio (SSMS)**: For managing the database.

### Steps to Install
1. **Clone the Repository**:
   Clone this repository to your local machine using Git or by downloading it as a ZIP file:
```bash
   git clone https://github.com/shishir786/Restaurant-Management-System.git
   ```


2. **Open the Project in Visual Studio**:
Open the solution (`.sln`) file in Visual Studio. It may prompt you to restore NuGet packages, click **Restore** to proceed.

3. **Set Up SQL Server Database**:
- Create a new database in SQL Server using **SQL Server Management Studio** (SSMS).
- Execute the provided SQL scripts in the `database/` folder to create the necessary tables and stored procedures.

4. **Configure Database Connection**:
- Open the project in Visual Studio.
- Locate the connection string in the project’s settings (usually in `App.config` or `Web.config`).
- Replace the default connection string with the details for your local SQL Server instance:
  ```bash
  <connectionStrings>
    <add name="RestaurantDBConnectionString" 
         connectionString="Server=localhost;Database=RestaurantDB;User Id=myUsername;Password=myPassword;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```

5. **Build the Solution**:
Build the solution in Visual Studio to compile the project. Make sure there are no errors.

6. **Run the Application**:
Press **F5** or click on **Start** to run the application. This will launch the desktop application where you can start managing your restaurant operations.


## Default Credentials for Testing

Use these credentials to explore the system:

| User    | ID  | Password |
|---------|-----|----------|
| Manager | ds  | 786      |
| Seller  | a   | 001      |


## How to Use

### Admin Dashboard
- **Login as Manager**: Enter the Manager credentials and access the Admin Dashboard.
- **Employee Management**: Navigate to the Employee Management section to view, add, and edit employee details.
- **Food Item Management**: Update the menu by adding or modifying food items and managing their stock and pricing.
- **Sales Tracking**: Monitor the performance of the restaurant, track daily sales, and generate reports.
- **Customer Management**: Access customer information and provide better services by analyzing their preferences and feedback.

### Seller Dashboard
- **Login as Seller**: Enter the Seller credentials to access the Seller Dashboard.
- **Create Orders**: Use the order management system to quickly create and modify customer orders.
- **Billing**: Generate bills and keep track of payments. Sellers can also mark orders as completed or pending.
- **Food Item Management**: Update the food items available on the menu.


# Screenshots
Here are some screenshots of the application in action:

## Admin Dashboard
![Admin Dashboard](https://github.com/user-attachments/assets/54773a12-1085-4396-9ae7-ea06b350e177)
### Employee Management
![Employee_Details](https://github.com/user-attachments/assets/4dc12509-80c9-4fc5-a964-ed6c88e8845f)
### Food Item Management
![food_itel](https://github.com/user-attachments/assets/86a38f39-14ca-456a-906a-08c1926247d7)
### Sells Infoirmatiom 
![sell_info](https://github.com/user-attachments/assets/e3ff04ec-bb1c-4750-b906-1820ca350893)
### Customer's Information 
![customerinfo](https://github.com/user-attachments/assets/9fb8b441-e8af-432c-a7ec-1519901a8de6)

## Seller Dashboard
![sellar_dashboard](https://github.com/user-attachments/assets/80a7d9b4-0a01-47f7-9d64-5c004cd06b91)
### Order Management
![order_foor](https://github.com/user-attachments/assets/1ed4f7ff-80ca-4ff7-84b9-4390a9d65a02)
### Food Item Management
![food_itel](https://github.com/user-attachments/assets/86a38f39-14ca-456a-906a-08c1926247d7)



## Contributing

We welcome contributions to the project! If you’d like to contribute, please follow these steps:
1. Fork the repository.
2. Create a new branch with a descriptive name.
3. Make your changes or add features.
4. Submit a pull request to the main branch.

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.


## Acknowledgments
- Thanks to the contributors, developers, and the open-source community for inspiration and support in building this system.
- A special mention to the creators of C# Forms, .NET Framework, and SQL Server for providing the tools to make this project a reality.

## Support
If you encounter any issues or need help with the setup, please create an issue on the repository or contact the author directly.
