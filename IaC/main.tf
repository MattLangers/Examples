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

    identity {
      type = "SystemAssigned"
    }

    site_config { 
      http2_enabled     = true
      application_stack {
        current_stack     = "dotnet"
        dotnet_version    = "v6.0"
      }
    }

    app_settings = {
      "Cors__AllowedOrigins__0" = "http://${azurerm_static_site.product_catalogue.default_host_name}"
    }

    connection_string {
      name = "ProductCatalogue"
      value = local.connection_string
      type = "SQLAzure"
    }
}

resource "azurerm_mssql_server" "product_catalogue" {
  name                         = "${var.sql_instance_name}"
  resource_group_name          = azurerm_resource_group.product_catalogue.name
  location                     = azurerm_resource_group.product_catalogue.location
  version                      = "12.0"
  minimum_tls_version          = "1.2"

  azuread_administrator {
    login_username = var.sql_server_ad_admin_username
    object_id      = var.sql_server_ad_admin_object_id
    azuread_authentication_only  = true
  }
}

resource "azurerm_mssql_firewall_rule" "product_catalogue" {
  count            = 19
  name             = "${azurerm_windows_web_app.product_catalogue.name}-firewall-${count.index}"
  server_id        = azurerm_mssql_server.product_catalogue.id
  start_ip_address = "${element(azurerm_windows_web_app.product_catalogue.possible_outbound_ip_address_list, count.index)}"
  end_ip_address   = "${element(azurerm_windows_web_app.product_catalogue.possible_outbound_ip_address_list, count.index)}"

  depends_on = [
    azurerm_windows_web_app.product_catalogue
  ]
}

resource "azurerm_mssql_database" "product_catalogue" {
  name           = "${var.sql_database_name}_${var.environment_prefix}"
  server_id      = azurerm_mssql_server.product_catalogue.id
  collation      = "SQL_Latin1_General_CP1_CI_AS"
  license_type   = "LicenseIncluded"
  max_size_gb    = 2
  sku_name       = "Basic"
}

# location is not UKSouth as its not possible to create a static site in this location
resource "azurerm_static_site" "product_catalogue" {
  name                = "mrmclangley${var.environment_prefix}productcatalogue"
  resource_group_name = azurerm_resource_group.product_catalogue.name
  location            = "westeurope"
  sku_tier            = "Free"
  sku_size            = "Free"
}

locals {
  connection_string = "Server=${var.sql_instance_name}.database.windows.net; Database=${var.sql_database_name}_${var.environment_prefix};Authentication=Active Directory Default;TrustServerCertificate=True;"
}