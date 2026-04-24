Technical Implementation Overview:

The project follows a strict 3-Layer Architecture focusing on scalability and the SOLID design principles.

Data Access Layer (DAL): Implemented using the Singleton Pattern for DatabaseHelper. It leverages Dapper for high-performance data mapping and Entity Framework Core for complex data tracking.

Business Logic Layer (BLL): Utilizes DTOs for decoupled data transfer, and Interfaces to implement Dependency Injection, ensuring the system adheres to the Open/Closed Principle.

Presentation Layer (PL): A WinForms-based UI with robust validation logic.

Advanced Exception Handling: Developed a custom Static Extension Class for the Exception type. Using LINQ-based recursion, this utility flattens nested Inner Exceptions into a manageable collection, significantly improving error logging and diagnostic capabilities via EventLog.

Security: Integrated Guest Events (or Credential Management) for secure handling of User Authentication.