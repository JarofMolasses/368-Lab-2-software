
namespace Lab_4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.distDisplay = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comPortDropdown = new System.Windows.Forms.ComboBox();
            this.connectSerialButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.Label();
            this.voltsDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sdevDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.distDisplayAvg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // distDisplay
            // 
            this.distDisplay.Location = new System.Drawing.Point(45, 139);
            this.distDisplay.Name = "distDisplay";
            this.distDisplay.Size = new System.Drawing.Size(99, 22);
            this.distDisplay.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(401, 30);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(323, 307);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comPortDropdown);
            this.groupBox2.Controls.Add(this.connectSerialButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(44, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 101);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial controls";
            // 
            // comPortDropdown
            // 
            this.comPortDropdown.FormattingEnabled = true;
            this.comPortDropdown.Location = new System.Drawing.Point(89, 29);
            this.comPortDropdown.Name = "comPortDropdown";
            this.comPortDropdown.Size = new System.Drawing.Size(160, 24);
            this.comPortDropdown.TabIndex = 18;
            this.comPortDropdown.SelectedIndexChanged += new System.EventHandler(this.comPortDropdown_SelectedIndexChanged);
            // 
            // connectSerialButton
            // 
            this.connectSerialButton.ForeColor = System.Drawing.Color.Black;
            this.connectSerialButton.Location = new System.Drawing.Point(89, 59);
            this.connectSerialButton.Name = "connectSerialButton";
            this.connectSerialButton.Size = new System.Drawing.Size(160, 23);
            this.connectSerialButton.TabIndex = 17;
            this.connectSerialButton.Text = "Connect serial";
            this.connectSerialButton.UseVisualStyleBackColor = true;
            this.connectSerialButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connectSerialButton_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Serial port";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(150, 144);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(63, 17);
            this.Distance.TabIndex = 28;
            this.Distance.Text = "Distance";
            // 
            // voltsDisplay
            // 
            this.voltsDisplay.Location = new System.Drawing.Point(45, 170);
            this.voltsDisplay.Name = "voltsDisplay";
            this.voltsDisplay.Size = new System.Drawing.Size(98, 22);
            this.voltsDisplay.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Voltage";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sdevDisplay
            // 
            this.sdevDisplay.Location = new System.Drawing.Point(246, 51);
            this.sdevDisplay.Name = "sdevDisplay";
            this.sdevDisplay.Size = new System.Drawing.Size(93, 22);
            this.sdevDisplay.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Distance avg";
            // 
            // distDisplayAvg
            // 
            this.distDisplayAvg.Location = new System.Drawing.Point(45, 51);
            this.distDisplayAvg.Name = "distDisplayAvg";
            this.distDisplayAvg.Size = new System.Drawing.Size(99, 22);
            this.distDisplayAvg.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distDisplayAvg);
            this.Controls.Add(this.sdevDisplay);
            this.Controls.Add(this.voltsDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.distDisplay);
            this.Name = "Form1";
            this.Text = "Optical distance sensor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox distDisplay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comPortDropdown;
        private System.Windows.Forms.Button connectSerialButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.TextBox voltsDisplay;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox sdevDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox distDisplayAvg;
    }
}

