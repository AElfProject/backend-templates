# ABP Framework + Orleans Backend Template

Template project for ABP Framework and Orleans backend.

- [About The Project](#about-the-project)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Running the Application](#running-the-application)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)

## About The Project

A template project for ABP 8 Framework and Orleans 7 backend.
## Getting Started

### Prerequisites

- .NET 8.0 SDK
- MongoDB
- Redis

## Configuration

1. Update the `appsettings.json` file in the Silo project with your specific configurations (e.g., connection strings, Orleans clustering configurations).

    ```json
    {
      "ConnectionStrings": {
        "Default": "mongodb://localhost:27017/MyTemplate"
      },
      "Orleans": {
        "ClusterId": "MyTemplateSiloCluster",
        "ServiceId": "MyTemplateBasicService",
        "AdvertisedIP": "127.0.0.1",
        "GatewayPort": 20001,
        "SiloPort": 10001,
        "MongoDBClient": "mongodb://localhost:27017/?maxPoolSize=555",
        "DataBase": "MyTemplateDb",
        "DashboardUserName": "admin",
        "DashboardPassword": "123456",
        "DashboardCounterUpdateIntervalMs": 1000,
        "DashboardPort": 8080,
        "EventStoreConnection": "ConnectTo=tcp://localhost:1113; HeartBeatTimeout=500",
        "ClusterDbConnection": "127.0.0.1:6379",
        "ClusterDbNumber": 0,
        "GrainStorageDbConnection": "127.0.0.1:6379",
        "GrainStorageDbNumber": 0
      }
    }
    ```

2. Update the `appsettings.json` file in the HttpApi.Host project with your specific configurations (e.g., connection strings, Orleans clustering configurations).

    ```json
    {
      "ConnectionStrings": {
        "Default": "mongodb://localhost:27017/MyTemplate"
      },
      "Orleans": {
        "ClusterId": "MyTemplateSiloCluster",
        "ServiceId": "MyTemplateBasicService",
        "MongoDBClient": "mongodb://localhost:27017/?maxPoolSize=555",
        "DataBase": "MyTemplateDb"
      }
    }
    ```

### Running the Application

1. Go to the `src` folder
    ```shell
    cd src
    ```
2. Run the `<Your Project Name>.DbMigrator` project to create the initial database from `src`.
    ```shell
    cd <Your Project Name>.DbMigrator
    dotnet run
    ```
3. Run the `<Your Project Name>.Silo` project to start the Orleans Silo from `src`.
    ```shell
    cd ../<Your Project Name>.Silo
    dotnet run
    ```
4. Run the `<Your Project Name>.HttpApi.Host` project to start the API from `src`.
    ```shell
    cd ../<Your Project Name>.HttpApi.Host
    dotnet run
    ```

## Examples

You can find examples from the `Books` or `Authors` folders in respective projects.

## Contributing

If you encounter a bug or have a feature request, please use the [Issue Tracker](https://github.com/AElfProject/aelf-dapp-factory/issues/new). The project is also open to contributions, so feel free to fork the project and open pull requests.

## License

Distributed under the Apache License. See [License](LICENSE) for more information.
Distributed under the MIT License. See [License](LICENSE) for more information.
