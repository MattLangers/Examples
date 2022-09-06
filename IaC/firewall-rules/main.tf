data "terraform_remote_state" "pc" {
  backend = "azurerm"
  
  config = {
    storage_account_name = "rk2camfja37geqj8x4kpzb09"
    container_name       = "pctfstatedev"
    key                  = "terraform.main.tfstate"
    resource_group_name  = "common"
  }
}

resource "azurerm_mssql_firewall_rule" "sqlFirewallRules" {
  count            = length(data.terraform_remote_state.pc.outputs.app_outbound_ips)
  name             = "${data.terraform_remote_state.pc.outputs.app_name}-firewall-${count.index}"
  server_id        = data.terraform_remote_state.pc.outputs.sql_instance_id
  start_ip_address = "${element(data.terraform_remote_state.pc.outputs.app_outbound_ips, count.index)}"
  end_ip_address   = "${element(data.terraform_remote_state.pc.outputs.app_outbound_ips, count.index)}"
}