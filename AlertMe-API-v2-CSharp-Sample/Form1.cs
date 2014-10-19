using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookComputing.XmlRpc;

namespace JustinCredible.AlertMeAPIv2CSharpSample
{
    public partial class Form1 : Form
    {
        private IAlertMeApi _api = null;

        public Form1()
        {
            InitializeComponent();

            _api = XmlRpcProxyGen.Create<IAlertMeApi>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.Login(tbParameters.Text.Split('|')[0], tbParameters.Text.Split('|')[1], tbParameters.Text.Split('|')[2]);
                tbSessionId.Text = tbResponse.Text;
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.Logout(tbSessionId.Text);
                tbSessionId.Text = "";
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetUserInfo(tbSessionId.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllHubs_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllHubs(tbSessionId.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnSetHub_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.SetHub(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetHubStatus_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                if (String.IsNullOrEmpty(tbParameters.Text))
                    tbResponse.Text = _api.GetHubStatus(tbSessionId.Text);
                else
                    tbResponse.Text = _api.GetHubStatus(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllDevices_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllDevices(tbSessionId.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetDeviceDetails_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetDeviceDetails(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllDeviceChannels_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllDeviceChannels(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetDeviceChannelValue_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                if (tbParameters.Text.Split('|').Length == 2)
                    tbResponse.Text = _api.GetDeviceChannelValue(tbSessionId.Text, tbParameters.Text.Split('|')[0], tbParameters.Text.Split('|')[1]);
                else
                    tbResponse.Text = _api.GetDeviceChannelValue(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllDeviceChannelValues_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllDeviceChannelValues(tbSessionId.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.SendCommand(tbSessionId.Text, tbParameters.Text.Split('|')[0], tbParameters.Text.Split('|')[1]);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllServices_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllServices(tbSessionId.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetAllServiceStates_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                tbResponse.Text = _api.GetAllServiceStates(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }

        private void btnGetCurrentServiceStates_Click(object sender, EventArgs e)
        {
            _api.Url = tbURL.Text;

            try
            {
                if (String.IsNullOrEmpty(tbParameters.Text))
                    tbResponse.Text = _api.GetCurrentServiceState(tbSessionId.Text);
                else
                    tbResponse.Text = _api.GetCurrentServiceState(tbSessionId.Text, tbParameters.Text);
            }
            catch (Exception exception)
            {
                tbResponse.Text = exception.Message;
            }
        }
    }
}
