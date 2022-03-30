# ProductsApi

## description
this is an initial .net6 web api which connects a PostgreSQL db running in a Docker container

developed on Visual Studio Code by using dotnet webapi template

## commands
type commands on Visual Studio Code to run the tests

    * cd dotnet-test-xunit\TickTackService.Tests
    * dotnet watch test
	
	

## commands
type commands in an appropriate folder to generate the project

    * mkdir clones
    * cd clones
    * dotnet new webapi -n ProductsApi
    * cd ProductsApi
    * code .
    * dotnet run
    * https://localhost:<portNumber>/swagger/index.html


type commands to create PosgreSQL and its administrator app pgAdmin as a docker container

    * dotnet dev-certs https --trust
    * docker-compose up -d
    * http://localhost:5050/login for pgAdmin
    * Use pgAdmin to create a database with the values in docker-compose.yml


type commands to add dependencies to project and install necessary net6 tools
    * dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
    * dotnet add package Microsoft.EntityFrameworkCore.Design
    * dotnet tool install --global dotnet-ef
    * dotnet ef migrations add InitialMigration
    * dotnet ef database update