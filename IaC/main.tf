resource "azurerm_resource_group" "product_catalogue" {
  location = var.resource_group_location
  name     = "${var.environment_prefix}_${var.resource_group_name}"
}

resource "azurerm_service_plan" "product_catalogue" {
    name                = "mrmclangley_${var.resource_group_name}_${var.environment_prefix}"
    location            = azurerm_resource_group.product_catalogue.location
    resource_group_name = azurerm_resource_group.product_catalogue.name
    os_type             = "Windows"
    sku_name            = "B1"
}

resource "azurerm_windows_web_app" "product_catalogue" {
    name                = "mrmclangley${var.environment_prefix}productcatalogue"
    location            = azurerm_resource_group.product_catalogue.location
    resource_group_name = azurerm_resource_group.product_catalogue.name
    service_plan_id     = azurerm_service_plan.product_catalogue.id
    https_only          = true

    site_config { 
      http2_enabled     = true
      application_stack {
        current_stack     = "dotnet"
        dotnet_version    = "v6.0"
      }
    }
}

resource "azurerm_mssql_server" "product_catalogue" {
  name                         = "${var.sql_instance_name}"
  resource_group_name          = azurerm_resource_group.product_catalogue.name
  location                     = azurerm_resource_group.product_catalogue.location
  version                      = "12.0"
  administrator_login          = "${var.sql_instance_administrator_login_username}"
  administrator_login_password = "${var.sql_instance_administrator_login_password}"
  minimum_tls_version          = "1.2"
}

resource "azurerm_mssql_database" "product_catalogue" {
  name           = "productCatalogue${var.environment_prefix}"
  server_id      = azurerm_mssql_server.product_catalogue.id
  collation      = "SQL_Latin1_General_CP1_CI_AS"
  license_type   = "LicenseIncluded"
  max_size_gb    = 2
  sku_name       = "Basic"
}

resource "azurerm_static_site" "product_catalogue" {
  name                = "mrmclangley${var.environment_prefix}productcatalogue"
  resource_group_name = azurerm_resource_group.rg.name
  location            = var.resource_group_location
  sku_tier            = "Free"
  sku_size            = "Free"
}