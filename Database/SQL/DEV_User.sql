CREATE USER [mrmclangleydevproductcatalogue] FROM EXTERNAL PROVIDER 

ALTER ROLE db_datareader ADD MEMBER [mrmclangleydevproductcatalogue]
ALTER ROLE db_datawriter ADD MEMBER [mrmclangleydevproductcatalogue]