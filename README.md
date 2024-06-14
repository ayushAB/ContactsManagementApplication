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
4. The API will start running on `https://localhost:44356` (HTTPS) by default if selected IIS Express.
5. The API will start running on `https://localhost:7145` (HTTPS) by default if selected Https.

## Testing the API

1. You can test the API using tool Swagger or by integrating it with a front-end application.

2. Use the following endpoints to interact with the API:
- GET: `/api/contacts` - Get all contacts
- GET: `/api/contacts/{id}` - Get contact by ID
- POST: `/api/contacts` - Create a new contact
- PUT: `/api/contacts/{id}` - Update an existing contact
- DELETE: `/api/contacts/{id}` - Delete a contact

## Running Test
Running Tests with Visual Studio Test Explorer
- Open your .NET Core solution in Visual Studio.

- Build your solution (Ctrl + Shift + B) to ensure that all projects are up to date.

- Open Test Explorer from the Visual Studio menu: Test > Test Explorer (Ctrl + E, T).

- Test Explorer will automatically discover and display all unit tests in your solution.

- Click the "Run All" button in Test Explorer to execute all tests.

- Alternatively, you can run individual tests or groups of tests by selecting them in Test Explorer and clicking the "Run Selected Tests" button.

- After running the tests, Test Explorer will display the test results, including passed, failed, and skipped tests. You can also see detailed information about each test by clicking on it in Test Explorer.

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
