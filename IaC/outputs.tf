output "resource_group_name" {
  value = azurerm_resource_group.product_catalogue.name
}

output "api_app_name" {
  value = azurerm_windows_web_app.product_catalogue.name
}

output "app_outbound_ips" {
  value = azurerm_windows_web_app.product_catalogue.possible_outbound_ip_address_list
  sensitive = true
}

output "sql_instance_name" {
  value = azurerm_mssql_server.product_catalogue.name
  sensitive = true
}

output "sql_instance_id" {
  value = azurerm_mssql_server.product_catalogue.id
  sensitive   = true  
}

output "sql_database_name" {
  value = azurerm_mssql_database.product_catalogue.name
  sensitive   = true
}

output "static_website_name" {
  value = azurerm_static_site.product_catalogue.name
}