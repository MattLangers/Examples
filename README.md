# Examples
A public repository to provide some example work.

I have created a simple product catalogue for a sweats company. 
For spead of development I have chosen to create a .net 6 lightweight API, 
and within this I want to highlight the following areas:
* Entity framework core
** code first database schema


After downloading the repository, please run the following commands to create the database on your local machine
```
update-database
```

When running the publisher locally, you will need to startup the azurite emulator - follow these steps:

* Create a folder on c drive to host the persisted data that azurite will create
** New-Item C:\azurite
* pull azurite docker image
** docker pull mcr.microsoft.com/azure-storage/azurite
* check image exists
** docker image ls
* run azurite from docker image
** docker run -p 10000:10000 -p 10001:10001 -p 10002:10002 -v c:/azurite:/data mcr.microsoft.com/azure-storage/azurite