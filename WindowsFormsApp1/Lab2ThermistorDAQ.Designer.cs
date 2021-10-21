
namespace Lab2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectSerialButton = new System.Windows.Forms.Button();
            this.comPortDropdown = new System.Windows.Forms.ComboBox();
            this.temperatureKDisplay = new System.Windows.Forms.TextBox();
            this.thermistorVDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temperatureCDisplay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.saveFileCheckBox = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempKRollingAvgDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rollingAvgSizeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateRollingAvgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // connectSerialButton
            // 
            this.connectSerialButton.Location = new System.Drawing.Point(35, 379);
            this.connectSerialButton.Name = "connectSerialButton";
            this.connectSerialButton.Size = new System.Drawing.Size(144, 23);
            this.connectSerialButton.TabIndex = 3;
            this.connectSerialButton.Text = "Connect serial";
            this.connectSerialButton.UseVisualStyleBackColor = true;
            this.connectSerialButton.Click += new System.EventHandler(this.connectSerialButton_Click);
            // 
            // comPortDropdown
            // 
            this.comPortDropdown.FormattingEnabled = true;
            this.comPortDropdown.Location = new System.Drawing.Point(185, 379);
            this.comPortDropdown.Name = "comPortDropdown";
            this.comPortDropdown.Size = new System.Drawing.Size(144, 24);
            this.comPortDropdown.TabIndex = 4;
            this.comPortDropdown.SelectedIndexChanged += new System.EventHandler(this.comPortDropdown_SelectedIndexChanged);
            // 
            // temperatureKDisplay
            // 
            this.temperatureKDisplay.Location = new System.Drawing.Point(217, 35);
            this.temperatureKDisplay.Name = "temperatureKDisplay";
            this.temperatureKDisplay.Size = new System.Drawing.Size(100, 22);
            this.temperatureKDisplay.TabIndex = 6;
            // 
            // thermistorVDisplay
            // 
            this.thermistorVDisplay.Location = new System.Drawing.Point(217, 7);
            this.thermistorVDisplay.Name = "thermistorVDisplay";
            this.thermistorVDisplay.Size = new System.Drawing.Size(100, 22);
            this.thermistorVDisplay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperature (K)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thermistor (V)";
            // 
            // temperatureCDisplay
            // 
            this.temperatureCDisplay.Location = new System.Drawing.Point(217, 64);
            this.temperatureCDisplay.Name = "temperatureCDisplay";
            this.temperatureCDisplay.Size = new System.Drawing.Size(100, 22);
            this.temperatureCDisplay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temperature (C)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(178, 425);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(151, 22);
            this.fileNameTextBox.TabIndex = 13;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(72, 424);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(100, 23);
            this.selectFileButton.TabIndex = 14;
            this.selectFileButton.Text = "Select file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectFileButton_MouseClick);
            // 
            // saveFileCheckBox
            // 
            this.saveFileCheckBox.AutoSize = true;
            this.saveFileCheckBox.Location = new System.Drawing.Point(72, 453);
            this.saveFileCheckBox.Name = "saveFileCheckBox";
            this.saveFileCheckBox.Size = new System.Drawing.Size(100, 21);
            this.saveFileCheckBox.TabIndex = 15;
            this.saveFileCheckBox.Text = "Save to file";
            this.saveFileCheckBox.UseVisualStyleBackColor = true;
            this.saveFileCheckBox.CheckedChanged += new System.EventHandler(this.saveFileCheckBox_CheckedChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(356, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(656, 578);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // tempKRollingAvgDisplay
            // 
            this.tempKRollingAvgDisplay.Location = new System.Drawing.Point(229, 129);
            this.tempKRollingAvgDisplay.Name = "tempKRollingAvgDisplay";
            this.tempKRollingAvgDisplay.Size = new System.Drawing.Size(100, 22);
            this.tempKRollingAvgDisplay.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Temperature (K) rolling average";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.temperatureCDisplay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.thermistorVDisplay);
            this.groupBox1.Controls.Add(this.temperatureKDisplay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 97);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw";
            // 
            // rollingAvgSizeTextBox
            // 
            this.rollingAvgSizeTextBox.Location = new System.Drawing.Point(229, 158);
            this.rollingAvgSizeTextBox.Name = "rollingAvgSizeTextBox";
            this.rollingAvgSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.rollingAvgSizeTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rolling average window (max 500)";
            // 
            // updateRollingAvgButton
            // 
            this.updateRollingAvgButton.Location = new System.Drawing.Point(70, 195);
            this.updateRollingAvgButton.Name = "updateRollingAvgButton";
            this.updateRollingAvgButton.Size = new System.Drawing.Size(216, 23);
            this.updateRollingAvgButton.TabIndex = 22;
            this.updateRollingAvgButton.Text = "Update rolling average size";
            this.updateRollingAvgButton.UseVisualStyleBackColor = true;
            this.updateRollingAvgButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateRollingAvgButton_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 635);
            this.Controls.Add(this.updateRollingAvgButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rollingAvgSizeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempKRollingAvgDisplay);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.saveFileCheckBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.comPortDropdown);
            this.Controls.Add(this.connectSerialButton);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Lab 2 Thermistor DAQ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectSerialButton;
        private System.Windows.Forms.ComboBox comPortDropdown;
        private System.Windows.Forms.TextBox temperatureKDisplay;
        private System.Windows.Forms.TextBox thermistorVDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox temperatureCDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.CheckBox saveFileCheckBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tempKRollingAvgDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rollingAvgSizeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateRollingAvgButton;
    }
}