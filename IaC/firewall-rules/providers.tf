terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.7.0"
    }
  }
  backend "azurerm" {
      resource_group_name  = "common"
      storage_account_name = "rk2camfja37geqj8x4kpzb09"
      container_name       = "pctfstatedev"
      key                  = "terraform.fwr.tfstate"
  }
}

provider "azurerm" {
  use_oidc = true
  features {}
}