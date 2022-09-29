IF NOT EXISTS 
    (SELECT [name] FROM sys.database_principals where [name] = 'mrmclangleydevproductcatalogue')
BEGIN
    CREATE USER [mrmclangleydevproductcatalogue] FROM EXTERNAL PROVIDER  
END

ALTER ROLE db_datareader ADD MEMBER [mrmclangleydevproductcatalogue]
ALTER ROLE db_datawriter ADD MEMBER [mrmclangleydevproductcatalogue]