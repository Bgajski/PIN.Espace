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

Database Context: The context class (ApplicationDbContext) that manages the database connection and is used to query and save data. It includes:

# Prerequisites
.NET SDK 5.0 or later

# Libraries and Dependencies
Blazor: For building interactive web UIs.

Entity Framework Core: For database interactions.

Microsoft.AspNetCore.Components: For Blazor components.

Microsoft.Extensions.Logging: For logging.

# License
This project is licensed under the MIT License.
