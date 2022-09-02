variable "environment_prefix" {
  default     = "local"
  description = "Environment name used for prefixing"
}

variable "resource_group_location" {
  default     = "uksouth"
  description = "Location of the resource group."
}

variable "resource_group_name" {
  default     = "product_catalogue"
}

variable "sql_instance_administrator_login_username" {
  default     = "username"
  sensitive   = true
}

variable "sql_instance_administrator_login_password" {
  default     = "password"
  sensitive   = true
}
