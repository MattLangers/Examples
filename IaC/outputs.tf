output "resource_group_name" {
  value = azurerm_resource_group.product_catalogue.name
}

output "app_name" {
  value = azurerm_app_service_plan.product_catalogue.name
}

output "sql_instance_name" {
  value = azurerm_sql_server.product_catalogue.name
}

output "sql_database_name" {
  value = azurerm_mssql_database.product_catalogue.name
}