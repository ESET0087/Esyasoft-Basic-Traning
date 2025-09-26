# Problem

Build a simple MVC application to manage a list of products.  
Tasks: Create a Product model with properties: Id, Name, Description, Price.  
Create a ProductController with actions for: Listing all products (Index) Viewing product details (Details).  
Read the data from SQL Database to display on webpage. 

Implement basic routing so URLs follow RESTful conventions.

# Key Endpoints

The application is configured to the Product List page. All product data access follows strict RESTful conventions under the `/products` route.

| HTTP Method | Route | Purpose |
| :--- | :--- | :--- |
| **GET** | `localhost:[port]/` or `/products` | **View Product List** (`Index` action) |
| **GET** | `/products/{id}` | **View Product Details** (`Details` action) |

# Project Structure Overview 

| Folder/File | Purpose |
| :--- | :--- |
| `Models/` | Contains the `Product.cs` data class. |
| `Controllers/` | Contains the `ProductController.cs` (handling routing and logic). |
| `Views/Product/` | Contains `Index.cshtml` (list view) and `Details.cshtml` (single item view). |
| `Data/` | Contains `IProductRepository.cs` and `ProductRepository.cs` for data abstraction. |
| `ApplicationDbContext.cs` | The EF Core class linking models to the SQL database. |
| `Program.cs` | The main configuration file: Sets up the database connection, registers services, and defines the default routing. |
| `appsettings.json` | Stores the SQL Server connection string. |

# Important

This project folder don't have wwwroot folder.
