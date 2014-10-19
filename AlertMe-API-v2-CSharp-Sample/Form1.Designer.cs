namespace JustinCredible.AlertMeAPIv2CSharpSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbSessionId = new System.Windows.Forms.TextBox();
            this.tbParameters = new System.Windows.Forms.TextBox();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.btnGetAllHubs = new System.Windows.Forms.Button();
            this.btnSetHub = new System.Windows.Forms.Button();
            this.btnGetHubStatus = new System.Windows.Forms.Button();
            this.btnGetDeviceDetails = new System.Windows.Forms.Button();
            this.btnGetAllDevices = new System.Windows.Forms.Button();
            this.btnGetAllDeviceChannels = new System.Windows.Forms.Button();
            this.btnGetDeviceChannelValue = new System.Windows.Forms.Button();
            this.btnGetAllDeviceChannelValues = new System.Windows.Forms.Button();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.btnGetAllServices = new System.Windows.Forms.Button();
            this.btnGetAllServiceStates = new System.Windows.Forms.Button();
            this.btnGetCurrentServiceStates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbResponse
            // 
            this.tbResponse.Location = new System.Drawing.Point(15, 182);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(687, 204);
            this.tbResponse.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(18, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(99, 392);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbSessionId
            // 
            this.tbSessionId.Location = new System.Drawing.Point(483, 9);
            this.tbSessionId.Name = "tbSessionId";
            this.tbSessionId.Size = new System.Drawing.Size(220, 20);
            this.tbSessionId.TabIndex = 3;
            // 
            // tbParameters
            // 
            this.tbParameters.Location = new System.Drawing.Point(15, 64);
            this.tbParameters.Multiline = true;
            this.tbParameters.Name = "tbParameters";
            this.tbParameters.Size = new System.Drawing.Size(687, 96);
            this.tbParameters.TabIndex = 4;
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Location = new System.Drawing.Point(180, 392);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetUserInfo.TabIndex = 5;
            this.btnGetUserInfo.Text = "GetUserInfo";
            this.btnGetUserInfo.UseVisualStyleBackColor = true;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // btnGetAllHubs
            // 
            this.btnGetAllHubs.Location = new System.Drawing.Point(18, 422);
            this.btnGetAllHubs.Name = "btnGetAllHubs";
            this.btnGetAllHubs.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllHubs.TabIndex = 6;
            this.btnGetAllHubs.Text = "GetAllHubs";
            this.btnGetAllHubs.UseVisualStyleBackColor = true;
            this.btnGetAllHubs.Click += new System.EventHandler(this.btnGetAllHubs_Click);
            // 
            // btnSetHub
            // 
            this.btnSetHub.Location = new System.Drawing.Point(99, 422);
            this.btnSetHub.Name = "btnSetHub";
            this.btnSetHub.Size = new System.Drawing.Size(75, 23);
            this.btnSetHub.TabIndex = 7;
            this.btnSetHub.Text = "SetHub";
            this.btnSetHub.UseVisualStyleBackColor = true;
            this.btnSetHub.Click += new System.EventHandler(this.btnSetHub_Click);
            // 
            // btnGetHubStatus
            // 
            this.btnGetHubStatus.Location = new System.Drawing.Point(180, 422);
            this.btnGetHubStatus.Name = "btnGetHubStatus";
            this.btnGetHubStatus.Size = new System.Drawing.Size(85, 23);
            this.btnGetHubStatus.TabIndex = 8;
            this.btnGetHubStatus.Text = "GetHubStatus";
            this.btnGetHubStatus.UseVisualStyleBackColor = true;
            this.btnGetHubStatus.Click += new System.EventHandler(this.btnGetHubStatus_Click);
            // 
            // btnGetDeviceDetails
            // 
            this.btnGetDeviceDetails.Location = new System.Drawing.Point(109, 451);
            this.btnGetDeviceDetails.Name = "btnGetDeviceDetails";
            this.btnGetDeviceDetails.Size = new System.Drawing.Size(102, 23);
            this.btnGetDeviceDetails.TabIndex = 9;
            this.btnGetDeviceDetails.Text = "GetDeviceDetails";
            this.btnGetDeviceDetails.UseVisualStyleBackColor = true;
            this.btnGetDeviceDetails.Click += new System.EventHandler(this.btnGetDeviceDetails_Click);
            // 
            // btnGetAllDevices
            // 
            this.btnGetAllDevices.Location = new System.Drawing.Point(18, 451);
            this.btnGetAllDevices.Name = "btnGetAllDevices";
            this.btnGetAllDevices.Size = new System.Drawing.Size(85, 23);
            this.btnGetAllDevices.TabIndex = 10;
            this.btnGetAllDevices.Text = "GetAllDevices";
            this.btnGetAllDevices.UseVisualStyleBackColor = true;
            this.btnGetAllDevices.Click += new System.EventHandler(this.btnGetAllDevices_Click);
            // 
            // btnGetAllDeviceChannels
            // 
            this.btnGetAllDeviceChannels.Location = new System.Drawing.Point(18, 509);
            this.btnGetAllDeviceChannels.Name = "btnGetAllDeviceChannels";
            this.btnGetAllDeviceChannels.Size = new System.Drawing.Size(121, 23);
            this.btnGetAllDeviceChannels.TabIndex = 11;
            this.btnGetAllDeviceChannels.Text = "GetAllDeviceChannels";
            this.btnGetAllDeviceChannels.UseVisualStyleBackColor = true;
            this.btnGetAllDeviceChannels.Click += new System.EventHandler(this.btnGetAllDeviceChannels_Click);
            // 
            // btnGetDeviceChannelValue
            // 
            this.btnGetDeviceChannelValue.Location = new System.Drawing.Point(145, 509);
            this.btnGetDeviceChannelValue.Name = "btnGetDeviceChannelValue";
            this.btnGetDeviceChannelValue.Size = new System.Drawing.Size(145, 23);
            this.btnGetDeviceChannelValue.TabIndex = 12;
            this.btnGetDeviceChannelValue.Text = "GetDeviceChannelValue";
            this.btnGetDeviceChannelValue.UseVisualStyleBackColor = true;
            this.btnGetDeviceChannelValue.Click += new System.EventHandler(this.btnGetDeviceChannelValue_Click);
            // 
            // btnGetAllDeviceChannelValues
            // 
            this.btnGetAllDeviceChannelValues.Location = new System.Drawing.Point(296, 509);
            this.btnGetAllDeviceChannelValues.Name = "btnGetAllDeviceChannelValues";
            this.btnGetAllDeviceChannelValues.Size = new System.Drawing.Size(154, 23);
            this.btnGetAllDeviceChannelValues.TabIndex = 13;
            this.btnGetAllDeviceChannelValues.Text = "GetAllDeviceChannelValues";
            this.btnGetAllDeviceChannelValues.UseVisualStyleBackColor = true;
            this.btnGetAllDeviceChannelValues.Click += new System.EventHandler(this.btnGetAllDeviceChannelValues_Click);
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(18, 538);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(97, 23);
            this.btnSendCommand.TabIndex = 14;
            this.btnSendCommand.Text = "SendCommand";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // btnGetAllServices
            // 
            this.btnGetAllServices.Location = new System.Drawing.Point(18, 480);
            this.btnGetAllServices.Name = "btnGetAllServices";
            this.btnGetAllServices.Size = new System.Drawing.Size(97, 23);
            this.btnGetAllServices.TabIndex = 15;
            this.btnGetAllServices.Text = "GetAllServices";
            this.btnGetAllServices.UseVisualStyleBackColor = true;
            this.btnGetAllServices.Click += new System.EventHandler(this.btnGetAllServices_Click);
            // 
            // btnGetAllServiceStates
            // 
            this.btnGetAllServiceStates.Location = new System.Drawing.Point(121, 480);
            this.btnGetAllServiceStates.Name = "btnGetAllServiceStates";
            this.btnGetAllServiceStates.Size = new System.Drawing.Size(122, 23);
            this.btnGetAllServiceStates.TabIndex = 16;
            this.btnGetAllServiceStates.Text = "GetAllServiceStates";
            this.btnGetAllServiceStates.UseVisualStyleBackColor = true;
            this.btnGetAllServiceStates.Click += new System.EventHandler(this.btnGetAllServiceStates_Click);
            // 
            // btnGetCurrentServiceStates
            // 
            this.btnGetCurrentServiceStates.Location = new System.Drawing.Point(249, 480);
            this.btnGetCurrentServiceStates.Name = "btnGetCurrentServiceStates";
            this.btnGetCurrentServiceStates.Size = new System.Drawing.Size(140, 23);
            this.btnGetCurrentServiceStates.TabIndex = 17;
            this.btnGetCurrentServiceStates.Text = "GetCurrentServiceStates";
            this.btnGetCurrentServiceStates.UseVisualStyleBackColor = true;
            this.btnGetCurrentServiceStates.Click += new System.EventHandler(this.btnGetCurrentServiceStates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Session ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Response";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(52, 9);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(309, 20);
            this.tbURL.TabIndex = 22;
            this.tbURL.Text = "https://api.irissmarthome.com/webapi/v2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 569);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetCurrentServiceStates);
            this.Controls.Add(this.btnGetAllServiceStates);
            this.Controls.Add(this.btnGetAllServices);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.btnGetAllDeviceChannelValues);
            this.Controls.Add(this.btnGetDeviceChannelValue);
            this.Controls.Add(this.btnGetAllDeviceChannels);
            this.Controls.Add(this.btnGetAllDevices);
            this.Controls.Add(this.btnGetDeviceDetails);
            this.Controls.Add(this.btnGetHubStatus);
            this.Controls.Add(this.btnSetHub);
            this.Controls.Add(this.btnGetAllHubs);
            this.Controls.Add(this.btnGetUserInfo);
            this.Controls.Add(this.tbParameters);
            this.Controls.Add(this.tbSessionId);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbResponse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "AlertMe API v2 - Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox tbSessionId;
        private System.Windows.Forms.TextBox tbParameters;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.Button btnGetAllHubs;
        private System.Windows.Forms.Button btnSetHub;
        private System.Windows.Forms.Button btnGetHubStatus;
        private System.Windows.Forms.Button btnGetDeviceDetails;
        private System.Windows.Forms.Button btnGetAllDevices;
        private System.Windows.Forms.Button btnGetAllDeviceChannels;
        private System.Windows.Forms.Button btnGetDeviceChannelValue;
        private System.Windows.Forms.Button btnGetAllDeviceChannelValues;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnGetAllServices;
        private System.Windows.Forms.Button btnGetAllServiceStates;
        private System.Windows.Forms.Button btnGetCurrentServiceStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbURL;
    }
}

