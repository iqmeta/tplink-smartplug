using com.iqmeta.tplink_smartplug;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_tpLink_smartplug
{
    public partial class guiDashboard : Form
    {
        private string ipAddress = "";
        private dynamic plugResponse = "";
        private bool statusConnection = false;

        public guiDashboard()
        {
            InitializeComponent();
        }

        private void tryConnection_btn_Click(object sender, EventArgs e)
        {
            if (ipAddress_txtb.Text == "")
            {
                MessageBox.Show("Insert IP address for the smartplug");
                return;
            }
            this.ipAddress = ipAddress_txtb.Text;
            if (CheckIpAddress(this.ipAddress))
            {
                statusConnection = true;
                try
                {

                    this.plugResponse = Utils.SendToSmartPlugOrSwitch(ipAddress, Commands.SysInfoAndEmeter());
                    var outputData = JsonConvert.SerializeObject(this.plugResponse, Formatting.Indented);
                    infoDevice_lb.Text = outputData;
                    
                }
                catch (Exception ex)
                {
                    statusConnection = false;
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("IP address not valid");
                ipAddress_txtb.Text = "";
            }
        }

        private void turnOn_btn_Click(object sender, EventArgs e)
        {
            if (this.ipAddress != "")
            {
                if (this.statusConnection)
                {
                    try
                    {
                        Utils.SendToSmartPlugOrSwitch(this.ipAddress, Commands.TurnOn());
                        MessageBox.Show("SmartPlug status change to on");
                    }
                    catch (Exception ex)
                    {
                        statusConnection = false;
                        MessageBox.Show("Error: " + ex.Message.ToString());
                    }
                }
                else
                    MessageBox.Show("SmartPlug not detected or connection fail");
            }
            else
                MessageBox.Show("Enter ip address or ip address not valid");
        }

        private void turnOff_btn_Click(object sender, EventArgs e)
        {
            if (this.ipAddress != "")
            {
                if (this.statusConnection)
                {
                    try
                    {
                        Utils.SendToSmartPlugOrSwitch(this.ipAddress, Commands.TurnOff());
                        MessageBox.Show("SmartPlug status change to off");
                    }
                    catch (Exception ex)
                    {
                        statusConnection = false;
                        MessageBox.Show("Error: " + ex.Message.ToString());
                    }
                }
                else
                    MessageBox.Show("SmartPlug not detected or connection fail");
            }
            else
                MessageBox.Show("Enter ip address or ip address not valid");
        }

        private bool CheckIpAddress(string ipAddress)
        {
            return Regex.IsMatch(ipAddress, "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
    }
}
