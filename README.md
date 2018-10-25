# PRODUCER
## Tools
* VisualStudio Code
* Postman
* Kafka Tool

## Prerequisites
* Install dotnet SDK 2.1.202
* Install dotnet Runtime 2.0.9
* Install dotnet ASP.NET
* Install Apache zookeeper
* Install Apache Kafka

## Build and runnning instructions:
1) Start up zookeeper
2) Start up Kafka
3) Open Visual Studio Code
4) Click in the option: File -> Open Folder 
5) Select folder PersonaAPI
6) Click in the option: View -> Integrated Terminal
7) In the Terminal run commands: 
...
dotnet restore
...
...
dotnet build
...
...
dotnet run
...

This application is sending messages the topic: test-topic
