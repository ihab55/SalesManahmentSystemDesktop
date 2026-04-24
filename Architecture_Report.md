# Sales Management System - Architecture Report

## 1. Overview

**Project Name:** SalesManahmentSystem  
**Application Type:** Windows Forms Desktop Application  
**Language:** C# (.NET)  
**Database:** Microsoft SQL Server  
**Architecture Pattern:** Three-Layer Architecture (DAL, BLL, PL) with Repository and Service patterns

---

## 2. Project Structure (3-Layer Architecture)

### 2.1 Layer Organization

```
SalesManahmentSystem/
├── SalesManahmentSystemDAL/        # Data Access Layer
├── SalesManahmentSystemBLL/        # Business Logic Layer
└── SalesManahmentSystemPL/         # Presentation Layer
```

### 2.2 Layer Responsibilities

| Layer | Responsibility | Key Components |
|-------|---------------|----------------|
| **DAL** | Database operations, connection management | Models, DataBaseHelper |
| **BLL** | Business logic, data transformation | Services, Interfaces, DTOs |
| **PL** | User interface, user interactions | Forms, Controls |

---

## 3. Data Access Layer (DAL)

### 3.1 Location
`d:\Courses\Projects\SalesManahmentSystem\SalesManahmentSystemDAL\`

### 3.2 Components

#### Models (Entity Classes)
| Model | Description |
|-------|-------------|
| `Category.cs` | Product category entity |
| `Customer.cs` | Customer information entity |
| `Product.cs` | Product details entity |
| `SaleOrder.cs` | Sales order header entity |
| `SaleOrderProduct.cs` | Sales order line items entity |
| `Stock.cs` | Stock/Cash box entity |
| `StockDetails.cs` | Stock transactions entity with enum for transaction types |

#### DataBaseHelper (Singleton Pattern)
**File:** `DataBaseHelper.cs`

**Pattern:** Singleton with Double-Check Locking

**Key Features:**
- Single database connection instance across application
- Thread-safe implementation using `lock`
- Connection string with SQL Server authentication
- Support for parameterized queries (Dapper)
- Transaction support for multi-command operations

**Connection String:**
```csharp
Server=.; Database=SSTOREONLINE; USER ID=sa; PASSWORD=123456;
Trusted_Connection=True; TrustServerCertificate=True;
```

**Methods:**
- `ExecuteSelect<T>()` - SELECT queries returning collections
- `QuerySingleOrDefualt<T>()` - Single record queries
- `ExecuteDML()` - INSERT, UPDATE, DELETE operations
- `ExecuteTransaction()` - Multi-command transactions

---

## 4. Business Logic Layer (BLL)

### 4.1 Location
`d:\Courses\Projects\SalesManahmentSystem\SalesManahmentSystemBLL\`

### 4.2 Components

#### 4.2.1 DTOs (Data Transfer Objects)
**Location:** `DTOs/`

| DTO | Purpose |
|-----|---------|
| `CategoryReadBasicDTO.cs` | Minimal category data for dropdowns |
| `CustomerReadBasicDTO.cs` | Minimal customer data for dropdowns |
| `LoginBasicDTO.cs` | Login credentials DTO |
| `ProductReadBasicDTO.cs` | Minimal product data for dropdowns |
| `ProductsViewDTO.cs` | Full product with category name |
| `SalesOrderReadProductDTO.cs` | Sales order with product details |
| `StockBasicDTO.cs` | Minimal stock data for dropdowns |
| `StockDetailsDTO.cs` | Stock transaction details |

#### 4.2.2 Service Interfaces
**Location:** `ServicesInterface/`

**Pattern:** Interface Segregation Principle

| Interface | Methods |
|-----------|---------|
| `ICategoryService` | CRUD operations for categories |
| `ICustomerService` | CRUD + search for customers |
| `ILoginService` | Authentication operations |
| `IProductService` | CRUD + search + basic read for products |
| `ISaleOrderProductService` | Sales order reporting |
| `ISaleOrderService` | Sales order CRUD operations |
| `IStockDetailsService` | Stock details operations |
| `IStockService` | Stock CRUD + basic read |

#### 4.2.3 Service Implementations
**Location:** `Services/`

**Pattern:** Service Layer with Async/Await

**Common Service Pattern:**
```csharp
public class CustomerService : ICustomerService
{
    // Uses DataBaseHelper.Instance for data access
    // Returns Task<T> for async operations
    // Uses Dapper for parameterized queries
}
```

---

## 5. Presentation Layer (PL)

### 5.1 Location
`d:\Courses\Projects\SalesManahmentSystem\SalesManahmentSystemPL\`

### 5.2 Forms (UI Components)

| Form | Purpose |
|------|---------|
| `frmLogin.cs` | User authentication with Remember Me option |
| `frmMain.cs` | Main navigation hub |
| `frmCatagory.cs` | Category management |
| `frmProduct.cs` | Product management with category dropdown |
| `frmCustomer.cs` | Customer management |
| `frmStock.cs` | Stock/Cash box management |
| `frmStockDetails.cs` | Stock transaction details with filtering |
| `frmSaleOrder.cs` | Sales order creation with stock & type selection |
| `frmSaleOrderReport.cs` | Sales reporting by date/customer |

### 5.3 UI Design Principles

**Applied Patterns:**
- **RTL (Right-to-Left) Layout** - Arabic language support
- **Panel-based Layout** - Organized sections (Header, Input, Buttons, DataGrid, Footer)
- **Consistent Color Scheme** - Teal (45, 85, 95) as primary color
- **Dubai Font** - Consistent typography across forms
- **Modern DataGridView** - Custom styling with teal headers, light green selection
- **ErrorProvider** - Validation feedback

---

## 6. Libraries & NuGet Packages

### 6.1 Dapper (Micro-ORM)
**Purpose:** Object-relational mapping for database operations
**Features Used:**
- `QueryAsync<T>()` - Async query execution
- `ExecuteAsync()` - Async DML operations
- `QuerySingleOrDefaultAsync<T>()` - Single record retrieval
- Automatic object mapping from SQL results
- Parameterized query support (SQL injection prevention)

### 6.2 Microsoft.Data.SqlClient
**Purpose:** SQL Server database connectivity
**Features:**
- `SqlConnection` for database connections
- Support for SQL Server authentication
- Connection string with `TrustServerCertificate=True` for development

### 6.3 System.Data
**Purpose:** Core ADO.NET functionality
**Features Used:**
- `IDbConnection` interface
- `IDbTransaction` for transaction management
- Data types for database operations

---

## 7. Design Patterns Used

### 7.1 Creational Patterns

#### Singleton Pattern
**Implementation:** `DataBaseHelper`
**Purpose:** Single database connection instance
**Implementation Details:**
- Private constructor
- Static `Instance` property
- Double-check locking for thread safety
- Lazy initialization

### 7.2 Structural Patterns

#### Repository Pattern
**Implementation:** Services in BLL
**Purpose:** Abstract data access logic
**Benefits:**
- Separation of concerns
- Testability
- Centralized data access logic

#### DTO (Data Transfer Object) Pattern
**Implementation:** DTOs folder in BLL
**Purpose:** Transfer data between layers without exposing full entities
**Benefits:**
- Reduced data transfer
- Security (hide sensitive fields)
- Custom views for specific use cases

### 7.3 Behavioral Patterns

#### Service Layer Pattern
**Implementation:** `IService` interfaces and implementations
**Purpose:** Encapsulate business logic
**Benefits:**
- Separation of business logic from UI
- Reusability across forms
- Easier unit testing

#### Dependency Injection (Manual)
**Implementation:** Constructor injection in forms
**Example:**
```csharp
public frmProduct(IProductService productService, ICategoryService categoryService)
{
    _productService = productService;
    _categoryService = categoryService;
}
```

### 7.4 UI Patterns

#### MVP (Model-View-Presenter) - Partial
**Implementation:** Forms act as Views, Services as Presenters
**Separation:**
- View (Forms) - UI only
- Presenter (Services) - Business logic
- Model (DTOs/Entities) - Data structures

---

## 8. Database Architecture

### 8.1 Database System
**Microsoft SQL Server** with Windows Authentication mixed mode

### 8.2 Tables (Inferred from Models)

| Table | Purpose |
|-------|---------|
| `CATEGORIES` | Product categories |
| `CUSTOMERS` | Customer information |
| `PRODUCTS` | Product catalog |
| `SALEORDERS` | Sales order headers |
| `SALEORDERPRODUCTS` | Sales order line items |
| `STOCKS` | Cash boxes / vaults |
| `STOCKDETAILS` | Stock transactions |

### 8.3 Relationships
- Products → Categories (Many-to-One)
- SaleOrderProducts → Products (Many-to-One)
- SaleOrderProducts → SaleOrders (Many-to-One)
- StockDetails → Stocks (Many-to-One)

---

## 9. Asynchronous Programming

### 9.1 Async/Await Pattern
**Usage:** All service methods use async/await
**Benefits:**
- Non-blocking UI during database operations
- Better responsiveness
- Scalability

### 9.2 Implementation Example
```csharp
public async Task<IEnumerable<Customer>> GetAllCustomers()
{
    return await DataBaseHelper.Instance.ExecuteSelect<Customer>(query);
}
```

---

## 10. Security Features

### 10.1 SQL Injection Prevention
**Method:** Dapper parameterized queries
**Example:**
```csharp
var result = await DataBaseHelper.Instance.ExecuteSelect<Customer>(
    "SELECT * FROM CUSTOMERS WHERE NAME LIKE @Pattern",
    new { Pattern = $"%{pattern}%" }
);
```

### 10.2 Login Security
**Implementation:** frmLogin with hardcoded credentials (for demo)
**Features:**
- Password masking (● characters)
- Show/Hide password toggle
- Remember Me option with event logging
- Logs stored in `Logs/LoginLogs.txt`

---

## 11. Configuration & Settings

### 11.1 Database Connection
**Location:** `DataBaseHelper.cs` (hardcoded for development)
**Configuration:**
```csharp
Server=.; Database=SSTOREONLINE; 
USER ID=sa; PASSWORD=123456;
Trusted_Connection=True; 
TrustServerCertificate=True;
```

### 11.2 Application Entry Point
**File:** `Program.cs`
**Flow:**
1. Initialize application configuration
2. Show login dialog
3. If successful, run main form

---

## 12. Form Features Summary

### 12.1 Common Features (All Forms)
- **Header Panel:** Teal color with title
- **RTL Layout:** Arabic language support
- **Dubai Font:** Consistent typography
- **ErrorProvider:** Input validation
- **DataGridView:** Custom styled with teal headers

### 12.2 Specific Form Features

| Form | Key Features |
|------|--------------|
| **frmLogin** | Hardcoded auth (Ehab/1234), Remember Me checkbox, Password visibility toggle, Event logging |
| **frmCatagory** | Category CRUD, Search by name |
| **frmProduct** | Product CRUD, Category dropdown, Numeric price fields |
| **frmCustomer** | Customer CRUD, Search by name/ID |
| **frmStock** | Stock CRUD, Total price calculation |
| **frmStockDetails** | Stock transaction view, Filter by date/type/stock |
| **frmSaleOrder** | Multi-product orders, Stock selection, Transaction type (Sale/Purchase/Expense), Running total |
| **frmSaleOrderReport** | Date range search, Customer/ID search, Total calculation |

---

## 13. Event Logging

### 13.1 Login Logging
**File:** `Logs/LoginLogs.txt`
**Format:**
```
[yyyy-MM-dd HH:mm:ss] User 'Ehab' logged in with 'Remember Me' checked.
```

---

## 14. Technology Stack Summary

| Category | Technology |
|----------|------------|
| **Platform** | .NET (Windows Forms) |
| **Language** | C# |
| **Database** | Microsoft SQL Server |
| **ORM** | Dapper |
| **UI Framework** | Windows Forms |
| **Architecture** | 3-Layer with Repository & Service patterns |
| **Async** | async/await |
| **Language Support** | Arabic (RTL) |

---

## 15. Key Architectural Decisions

1. **3-Layer Architecture** - Clear separation of concerns
2. **Singleton DataBaseHelper** - Single connection instance
3. **Service Interfaces** - Dependency injection support
4. **DTO Pattern** - Custom data views for UI
5. **Dapper over EF** - Lightweight, fast, raw SQL control
6. **Async Operations** - Non-blocking UI
7. **Manual DI** - Service injection into forms
8. **Panel-based UI** - Consistent, maintainable layouts

---

## 16. Project Files Summary

| Project | Files | Key Components |
|---------|-------|----------------|
| **DAL** | 8 models + DataBaseHelper | Entities, Database access |
| **BLL** | 8 DTOs + 8 Interfaces + 8 Services | Business logic, Data transformation |
| **PL** | 9 Forms + Program.cs | User interface |

**Total Forms:** 9 (Login, Main, Category, Product, Customer, Stock, StockDetails, SaleOrder, SaleOrderReport)

---

## 17. Summary

The SalesManahmentSystem implements a clean, layered architecture with:
- **Clear separation** between data, business logic, and presentation
- **Modern patterns** (Repository, Service, DTO, Singleton)
- **Async operations** for responsive UI
- **Security considerations** (parameterized queries)
- **Consistent UI design** (RTL, Dubai font, teal theme)
- **Comprehensive CRUD** for all business entities
- **Reporting capabilities** with filtering

This architecture provides a solid foundation for a sales management system with room for future enhancements like:
- Entity Framework migration
- Dependency injection container (Unity/Autofac)
- Configuration files for connection strings
- User management system
- Role-based access control
