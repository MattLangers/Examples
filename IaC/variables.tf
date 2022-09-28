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

variable "sql_instance_name" {
  default     = "sqlinstancename"
}

variable "sql_database_name" {
  default     = "product_catalogue"
}

variable "sql_service_principle_client_id" {
  default     = "sql_service_principle_client_id"
}

variable "sql_service_principle_secret" {
  default     = "sql_service_principle_secret"
}

variable "sql_server_ad_admin_username" {
  default     = "sql_server_ad_admin_username"
}

variable "sql_server_ad_admin_password" {
  default     = "sql_server_ad_admin_password"
}

variable "sql_server_ad_admin_object_id" {
  default     = "sql_server_ad_admin_object_id"
}