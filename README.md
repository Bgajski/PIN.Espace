# Vsite PIN project - Blazor crud application
VSITE.PIN.Espace is a Blazor-based template application designed for educational purposes. 
It includes CRUD operations and features to support tournament management.

# Features
CRUD Operations
Create: Allows users to add new entities to the database, such as LAN events and games.
Read: Fetch and display data from the database, providing detailed views of entities.
Update: Modify existing records in the database, ensuring data remains current and accurate.
Delete: Remove entities from the database, maintaining data integrity and relevance.
Display of Tournaments
Fetch and Display Details: The LanDisplayRepository is used to retrieve and display LAN event details, including event name, game genre, game name, number of teams, reward, start and end dates, and price.

# DataAccess
Repositories: Classes responsible for encapsulating the logic required to access data sources.
Database Context: The context class (ApplicationDbContext) that manages the database connection and is used to query and save data. It includes:
DbSet<LanEvent>: Represents LAN events in the database.
DbSet<LanGame>: Represents LAN games in the database.
Relationships and configurations are defined in OnModelCreating.
Espace_tournament_server
Controllers: Handle HTTP requests and return responses to the client.
API Endpoints: Define the routes and actions available for interacting with the server-side logic.

# Logic
Services: Contain business logic and rules, acting as an intermediary between the controllers and the data access layer. For example, LanEventRepository and LanGameRepository.
Business Rules: Implement rules and procedures that dictate how the application operates.

# Models
Entities: Define the structure of data stored in the database, such as LanEvent and LanGame.
DTOs (Data Transfer Objects): Used to transfer data between the client and server.

# Prerequisites
.NET SDK 5.0 or later

# Libraries and Dependencies
Blazor: For building interactive web UIs.
Entity Framework Core: For database interactions.
Microsoft.AspNetCore.Components: For Blazor components.
Microsoft.Extensions.Logging: For logging.
Contributing
Contributions are welcome. Please fork the repository and submit pull requests.

# License
This project is licensed under the MIT License.
