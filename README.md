# Examples

## What
This is an example repository to provide some example work to hopefully future colleagues.

I decided to create a simple product catalogue for a sweats company. This consists of a 
lightweight .net 6 API. There is also a Publisher console application for putting new 
Products onto a queue. 

## Why
My reasoning for chosing these system types:
* I've got lots of experience building distributed systems
* It also give's you an idea of style of coding, and the approach taken to build different systems
from the ground up
* I've got lots of experience working with azure functions, but I haven't created a lightweight API 
before, so a good opportunity try this out. 


## Highlights
I would like to highlight the following:
* I have created a SQL schema, constructed using entity framework core, code first
* I have used the specification pattern to search for products
* I have created some unit tests, but I would like to provide more coverage.

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