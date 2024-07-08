# ABP Framework + Orleans Backend Template

Template project for ABP Framework and Orleans backend.

- [About The Project](#about-the-project)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Startup](#startup)
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

### Startup

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
