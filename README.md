# Examples

## Introduction
This is an example repository to provide some example work to hopefully future colleagues.

I decided to create a simple product catalogue for a sweats company. This consists of a 
lightweight .net 6 API. There is also a Publisher console application for putting new 
Products onto a queue. 

## Why
* I've got lots of experience building distributed systems: API's, console applications, serverless functions, ETL pipelines, API integrations, queues, no/low code, monolithic multi-tenant applications. And I feel that these two applications are a good representation of back-end systems.  
* Hopefully you will get a good impression of my coding style, and my approach taken to build these systems from the ground up
* I haven't created a lightweight API before, so a good opportunity try this out. 

## Highlights
* I have created a SQL schema, constructed using entity framework core, code first
* I have used the specification pattern to search for products. This was my first time using this software pattern. I chose this because I have created an un-scallable solution in the past, when I read about this approach on Medium it sparked my curiosity to try. I will admit that I am a bit unhappy with the amount of if statements in the [database search orchestration layer](/blob/main/Database/Search/DatabaseSearchOrchestrator.cs). Its good enough for a first pass, and I will hopfully improve this in the future.   
* Unit-testing: I have developed applications using test driven development in the past, but I don't really code like this anymore. My current approach is to sprinkle tests in areas I think warrent them as I go. When the application becomes more stable (towards the tail end of the development stage), I will review and backfill the application where I see fit. At present these applications don't have enough coverage. 

## Instructions

### API
After downloading the repository, please run the following commands to create 
the database on your local machine
```
update-database
```

### Publisher
When running the publisher locally, you will need to startup the azurite emulator - 
follow these steps:

Create a folder on c drive to host the persisted data that azurite will create
```powershell
New-Item C:\azurite
```
pull azurite docker image
```powershell
docker pull mcr.microsoft.com/azure-storage/azurite
```
check image exists
```powershell
docker image ls
```
run azurite from docker image
```powershell
docker run -p 10000:10000 -p 10001:10001 -p 10002:10002 -v c:/azurite:/data mcr.microsoft.com/azure-storage/azurite
```
