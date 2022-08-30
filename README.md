# Portfolio

## Introduction
I have created this example repository, to help provide future colleagues example of my programming abilities as a .net developer. 
Therefore, this is not a finished product, features are light.

I have decided to create a product catalogue for a sweats company, consisting of a 
.net 6 lightweight API. And a console application, for publishing new 
products onto a queue, so consumers can process these outside of the main API thread.

## Why

* I've got lots of experience building monolithic applications, and distributed microservices, for example:
   * API's
   * Multi-tenant full stack .net applications: .net 4/.net core
   * Console applications
   * Azure Serverless functions
   * ETL pipelines using SSDT, serverless functions 
   * API integrations
   * low/no code: Logic-Apps
   * publishers/consumers working with queues
* How do you build something that is lightweight in effort, that will provide a good example of my abilities?
* I thought a fictious application would be a good place to start, to allow you the reviewer to asses my coding style and approach.

## Highlights
* I have created a SQL schema, using entity framework core, code first
* I have used the specification pattern to search for products.   
* Unit-testing:
 - Use Moq.AutoMock to instansiate unit under test: saves time as there is no need to create mocks, and if a constructor call signiture change there is no additional work to fix broken tests
 - Use  [Nunit.Framework.ValuesAttribute](https://github.com/MattLangers/Portfolio/blob/c3ffa861bea1df0132df632212f3abe9d2f94e52/Database.Tests/Enums/MapEnumToEnum/MapProductToProductType/EnsureAllProductsAreMapped.Tests.cs#L11) to allow a test to scale with the Enum we are testing - protection if a new enum value is added and the engineer doesn't see the need to extend mapping logic.
* Middleware: Exception handling to capure any exceptions that bubble up to the route of the API
* Github pipelines for Continuous integration
* Postman Requests with tests checking:
  - status code
  - Content-type is JSON
  - Schema
* IaC: Terraform files to create cloud resources for this project 

## Honest appraisal
* Specification pattern: I am a bit unhappy with the amount of if statements in the [database search orchestration layer](https://github.com/MattLangers/Portfolio/blob/c3ffa861bea1df0132df632212f3abe9d2f94e52/Database/Search/DatabaseSearchOrchestrator.cs#L24). Overall I think its the best approach, and good enough for a first pass, and I will hopeully improve this in the future, and write tests to cover this.
* Overll the unit-test coverage should be better.
* IoC: I should state that this is not production ready.
* Observability should be better: need to create more logs for analysis when in higher environments.

## Instructions

### For setting up your local database
After downloading the repository, please run the following commands to create 
the database on your local machine
```
update-database
```

### Publisher requires the azurite emulator to be running
When running the publisher locally, you will need to startup the azurite emulator, 
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

### Ifrastructure as Code
We are using terraform to create the required infrastructure in Azure. To execute locally, you will need:
* install terraform: https://learn.hashicorp.com/tutorials/terraform/install-cli?in=terraform/azure-get-started
* install Azure CLI: https://docs.microsoft.com/en-us/cli/azure/install-azure-cli-windows?tabs=azure-cli
* login to azure via the Azure CLI
```powershell
az login
```
* We need to create a terraform tfvars file - to replace sensitive variables at execution time: name the file terraform.tfvars, and add to this the following variables:
```terraform
sql_instance_administrator_login_username = "place a suitable username here"
sql_instance_administrator_login_password = "place a strong password here"
```
* now we need to run the following terraform commands to create the resources in azure
```terraform
terraform init
terraform plan -out main.tfplan
terraform apply main.tfplan
```
* when we are done we should clean up the resources
```terraform
terraform destroy -auto-approve
```