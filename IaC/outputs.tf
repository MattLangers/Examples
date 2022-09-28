output "resource_group_name" {
  value = azurerm_resource_group.product_catalogue.name
}

output "api_app_name" {
  value = azurerm_windows_web_app.product_catalogue.name
}

output "static_website_name" {
  value = azurerm_static_site.product_catalogue.name
}

output "static_website_name_default_host_name" {
  value = azurerm_static_site.product_catalogue.default_host_name
}