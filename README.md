# HotelsAPI
Hotel Booking System API
The Hotel Booking System API is a project developed for XYZHotels, a renowned hotel chain operating globally. The API provides a streamlined reservation process and efficient booking experience for customers. It includes CRUD operations, filtering capabilities, count functionality, JWT token authentication, and handles the one-to-many relationship between hotels and rooms.

Features
CRUD Operations: The API supports creating, reading, updating, and deleting hotel information, allowing hotel staff to manage hotel details effectively.

Filtering: Customers can search and filter hotels based on criteria such as location, price range, or amenities to find their desired accommodations easily.

Count Functionality: Users can retrieve the count of available rooms in specific hotels, providing insights into room availability for better decision-making.

JWT Token Authentication: The API implements secure authentication using JWT tokens to ensure that only authorized users can access the API endpoints, protecting customer and hotel data.

One-to-Many Relationship: The API efficiently handles the one-to-many relationship between hotels and rooms, allowing each hotel to have multiple rooms for effective room management.

Exception Handling: The API incorporates try-catch blocks to handle exceptions gracefully, providing meaningful error messages and ensuring system stability.

Repository Pattern: The project follows the repository pattern to separate the data access layer from the business logic, promoting code modularity and maintainability.


Getting Started
To get started with the Hotel Booking System API, follow these steps:

Clone the repository to your local machine.

Ensure you have the necessary dependencies installed, including .NET and Entity Framework.

Configure the database connection in the appsettings.json file with the appropriate connection string.

Run the database migrations to create the necessary tables and schema using Entity Framework.

Build and run the application.

Access the API endpoints using a tool like Postman or any API testing tool of your choice.






