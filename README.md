# Contact Management Application

This is a simple Contact Management application built using .NET Core API with a repository pattern for data access.

## Installation

1. Clone the repository to your local machine:

2. Navigate to the project directory:

3. Restore NuGet packages:


## Running the Application

1. Open the solution file `ContactManagement.sln` in Visual Studio or your preferred IDE.

2. Set the startup project to `ContactManagement.API`.

3. Press F5 or click on the Run button to start the API.

4. The API will start running on `https://localhost:44356` (HTTPS) by default.

## Testing the API

1. You can test the API using tool Swagger or by integrating it with a front-end application.

2. Use the following endpoints to interact with the API:
- GET: `/api/contacts` - Get all contacts
- GET: `/api/contacts/{id}` - Get contact by ID
- POST: `/api/contacts` - Create a new contact
- PUT: `/api/contacts/{id}` - Update an existing contact
- DELETE: `/api/contacts/{id}` - Delete a contact

## Technologies Used

- .NET Core 8.0
- Repository Pattern

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
