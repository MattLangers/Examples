terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.24.0"
    }
    mssql = {
      source = "betr-io/mssql"
      version = "0.2.5"
    }
  }
  backend "azurerm" {
      resource_group_name  = "common"
      storage_account_name = "rk2camfja37geqj8x4kpzb09"
      container_name       = "pctfstatedev"
      key                  = "terraform.main.tfstate"
  }
}

provider "azurerm" {
  use_oidc = true
  features {}
}

provider "mssql" {
  debug = "true"
}