namespace RGBController
{
    partial class RGBController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBController));
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRedOn = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonRedOff = new System.Windows.Forms.Button();
            this.buttonGreenOn = new System.Windows.Forms.Button();
            this.buttonGreenOff = new System.Windows.Forms.Button();
            this.buttonBlueOn = new System.Windows.Forms.Button();
            this.buttonBlueOff = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(243, 6);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 0;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(169, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(56, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRedOn
            // 
            this.buttonRedOn.Location = new System.Drawing.Point(13, 68);
            this.buttonRedOn.Name = "buttonRedOn";
            this.buttonRedOn.Size = new System.Drawing.Size(32, 23);
            this.buttonRedOn.TabIndex = 2;
            this.buttonRedOn.Text = "On";
            this.buttonRedOn.UseVisualStyleBackColor = true;
            this.buttonRedOn.Click += new System.EventHandler(this.buttonRedOn_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(42, 6);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "comboBox1.Text";
            // 
            // buttonRedOff
            // 
            this.buttonRedOff.Location = new System.Drawing.Point(51, 68);
            this.buttonRedOff.Name = "buttonRedOff";
            this.buttonRedOff.Size = new System.Drawing.Size(32, 23);
            this.buttonRedOff.TabIndex = 8;
            this.buttonRedOff.Text = "Off";
            this.buttonRedOff.UseVisualStyleBackColor = true;
            this.buttonRedOff.Click += new System.EventHandler(this.buttonRedOff_Click);
            // 
            // buttonGreenOn
            // 
            this.buttonGreenOn.Location = new System.Drawing.Point(107, 68);
            this.buttonGreenOn.Name = "buttonGreenOn";
            this.buttonGreenOn.Size = new System.Drawing.Size(32, 23);
            this.buttonGreenOn.TabIndex = 9;
            this.buttonGreenOn.Text = "On";
            this.buttonGreenOn.UseVisualStyleBackColor = true;
            this.buttonGreenOn.Click += new System.EventHandler(this.buttonGreenOn_Click);
            // 
            // buttonGreenOff
            // 
            this.buttonGreenOff.Location = new System.Drawing.Point(143, 68);
            this.buttonGreenOff.Name = "buttonGreenOff";
            this.buttonGreenOff.Size = new System.Drawing.Size(32, 23);
            this.buttonGreenOff.TabIndex = 10;
            this.buttonGreenOff.Text = "Off";
            this.buttonGreenOff.UseVisualStyleBackColor = true;
            this.buttonGreenOff.Click += new System.EventHandler(this.buttonGreenOff_Click);
            // 
            // buttonBlueOn
            // 
            this.buttonBlueOn.Location = new System.Drawing.Point(195, 68);
            this.buttonBlueOn.Name = "buttonBlueOn";
            this.buttonBlueOn.Size = new System.Drawing.Size(32, 23);
            this.buttonBlueOn.TabIndex = 11;
            this.buttonBlueOn.Text = "On";
            this.buttonBlueOn.UseVisualStyleBackColor = true;
            this.buttonBlueOn.Click += new System.EventHandler(this.buttonBlueOn_Click);
            // 
            // buttonBlueOff
            // 
            this.buttonBlueOff.Location = new System.Drawing.Point(233, 68);
            this.buttonBlueOff.Name = "buttonBlueOff";
            this.buttonBlueOff.Size = new System.Drawing.Size(32, 23);
            this.buttonBlueOff.TabIndex = 12;
            this.buttonBlueOff.Text = "Off";
            this.buttonBlueOff.UseVisualStyleBackColor = true;
            this.buttonBlueOff.Click += new System.EventHandler(this.buttonBlueOff_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(30, 97);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 114);
            this.trackBarRed.TabIndex = 13;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(118, 97);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 114);
            this.trackBarGreen.TabIndex = 14;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(210, 97);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 114);
            this.trackBarBlue.TabIndex = 15;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(27, 217);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(52, 13);
            this.labelRed.TabIndex = 16;
            this.labelRed.Text = "Red is : 0";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(114, 217);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(61, 13);
            this.labelGreen.TabIndex = 17;
            this.labelGreen.Text = "Green is : 0";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(207, 217);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(53, 13);
            this.labelBlue.TabIndex = 18;
            this.labelBlue.Text = "Blue is : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = " Red value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = " Green value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = " Blue value:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(324, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 87);
            this.textBox1.TabIndex = 23;
            // 
            // RGBController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.buttonBlueOff);
            this.Controls.Add(this.buttonBlueOn);
            this.Controls.Add(this.buttonGreenOff);
            this.Controls.Add(this.buttonGreenOn);
            this.Controls.Add(this.buttonRedOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.buttonRedOn);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonDisconnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RGBController";
            this.Text = "RGB-Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRedOn;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonRedOff;
        private System.Windows.Forms.Button buttonGreenOn;
        private System.Windows.Forms.Button buttonGreenOff;
        private System.Windows.Forms.Button buttonBlueOn;
        private System.Windows.Forms.Button buttonBlueOff;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

