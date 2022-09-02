resource "azurerm_resource_group" "product_catalogue" {
  location = var.resource_group_location
  name     = "${var.environment_prefix}_${var.resource_group_name}"
}

resource "azurerm_storage_account" "product_catalogue" {
    name                     = "mrmclangley${var.environment_prefix}pc"
    resource_group_name      = azurerm_resource_group.product_catalogue.name
    location                 = azurerm_resource_group.product_catalogue.location
    account_tier             = "Standard"
    account_replication_type = "LRS"
}

resource "azurerm_app_service_plan" "product_catalogue" {
    name                = "mrmclangley_${var.environment_prefix}_${var.resource_group_name}"
    location            = azurerm_resource_group.product_catalogue.location
    resource_group_name = azurerm_resource_group.product_catalogue.name
    sku {
        tier = "Standard"
        size = "F1"
    }
}

resource "azurerm_app_service" "product_catalogue" {
    name                = "mrmclangley${var.environment_prefix}productcatalogue"
    location            = azurerm_resource_group.product_catalogue.location
    resource_group_name = azurerm_resource_group.product_catalogue.name
    app_service_plan_id = azurerm_app_service_plan.product_catalogue.id
}

resource "azurerm_sql_server" "product_catalogue" {
  name                         = "g4i0tk1ulwpxtrqpds5ur87gb-lxd9ak"
  resource_group_name          = azurerm_resource_group.product_catalogue.name
  location                     = azurerm_resource_group.product_catalogue.location
  version                      = "12.0"
  administrator_login          = "${var.sql_instance_administrator_login_username}"
  administrator_login_password = "${var.sql_instance_administrator_login_password}"
}

resource "azurerm_mssql_database" "product_catalogue" {
  name           = "${var.environment_prefix}_${var.resource_group_name}"
  server_id      = azurerm_sql_server.product_catalogue.id
  collation      = "SQL_Latin1_General_CP1_CI_AS"
  license_type   = "LicenseIncluded"
  max_size_gb    = 2
  sku_name       = "Basic"
}