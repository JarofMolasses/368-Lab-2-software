
namespace Lab_3
{
    partial class Lab3Scale
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.voltsDisplay = new System.Windows.Forms.TextBox();
            this.comPortDropdown = new System.Windows.Forms.ComboBox();
            this.connectSerialButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.massDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sdevDisplay = new System.Windows.Forms.TextBox();
            this.tareButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.massDisplayAvgRaw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.massOffsetDisplay = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.massDisplayAvg = new System.Windows.Forms.TextBox();
            this.kgLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltsDisplay
            // 
            this.voltsDisplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.voltsDisplay.ForeColor = System.Drawing.Color.White;
            this.voltsDisplay.Location = new System.Drawing.Point(51, 21);
            this.voltsDisplay.Name = "voltsDisplay";
            this.voltsDisplay.Size = new System.Drawing.Size(158, 22);
            this.voltsDisplay.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Serial port";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 532);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 84);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start new calibration";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Use default calibration";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "V";
            // 
            // massDisplay
            // 
            this.massDisplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.massDisplay.ForeColor = System.Drawing.Color.White;
            this.massDisplay.Location = new System.Drawing.Point(51, 46);
            this.massDisplay.Name = "massDisplay";
            this.massDisplay.Size = new System.Drawing.Size(158, 22);
            this.massDisplay.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "kg";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.comPortDropdown);
            this.groupBox2.Controls.Add(this.connectSerialButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(24, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 101);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial controls";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sdevDisplay);
            this.groupBox3.Controls.Add(this.massDisplay);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.voltsDisplay);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 132);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raw";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sdev of massQueueAvg";
            // 
            // sdevDisplay
            // 
            this.sdevDisplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sdevDisplay.ForeColor = System.Drawing.Color.White;
            this.sdevDisplay.Location = new System.Drawing.Point(51, 101);
            this.sdevDisplay.Name = "sdevDisplay";
            this.sdevDisplay.Size = new System.Drawing.Size(158, 22);
            this.sdevDisplay.TabIndex = 26;
            // 
            // tareButton
            // 
            this.tareButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tareButton.ForeColor = System.Drawing.Color.Black;
            this.tareButton.Location = new System.Drawing.Point(106, 95);
            this.tareButton.Name = "tareButton";
            this.tareButton.Size = new System.Drawing.Size(103, 27);
            this.tareButton.TabIndex = 30;
            this.tareButton.Text = "Tare ";
            this.tareButton.UseVisualStyleBackColor = false;
            this.tareButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tareButton_MouseClick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(298, 402);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(867, 214);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Raw mass";
            // 
            // massDisplayAvgRaw
            // 
            this.massDisplayAvgRaw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.massDisplayAvgRaw.ForeColor = System.Drawing.Color.White;
            this.massDisplayAvgRaw.Location = new System.Drawing.Point(105, 28);
            this.massDisplayAvgRaw.Name = "massDisplayAvgRaw";
            this.massDisplayAvgRaw.Size = new System.Drawing.Size(104, 22);
            this.massDisplayAvgRaw.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tare offset";
            // 
            // massOffsetDisplay
            // 
            this.massOffsetDisplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.massOffsetDisplay.ForeColor = System.Drawing.Color.White;
            this.massOffsetDisplay.Location = new System.Drawing.Point(105, 54);
            this.massOffsetDisplay.Name = "massOffsetDisplay";
            this.massOffsetDisplay.Size = new System.Drawing.Size(104, 22);
            this.massOffsetDisplay.TabIndex = 33;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.massDisplayAvgRaw);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.massOffsetDisplay);
            this.groupBox5.Controls.Add(this.tareButton);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(24, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 150);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Averaged";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(210, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "kg";
            // 
            // massDisplayAvg
            // 
            this.massDisplayAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.massDisplayAvg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.massDisplayAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massDisplayAvg.ForeColor = System.Drawing.Color.Honeydew;
            this.massDisplayAvg.Location = new System.Drawing.Point(391, 32);
            this.massDisplayAvg.Name = "massDisplayAvg";
            this.massDisplayAvg.Size = new System.Drawing.Size(578, 121);
            this.massDisplayAvg.TabIndex = 28;
            this.massDisplayAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.massDisplayAvg.Resize += new System.EventHandler(this.massDisplayAvg_Resize);
            // 
            // kgLabel
            // 
            this.kgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgLabel.Location = new System.Drawing.Point(975, 32);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(129, 95);
            this.kgLabel.TabIndex = 31;
            this.kgLabel.Text = "kg";
            // 
            // Lab3Scale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1177, 628);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.massDisplayAvg);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lab3Scale";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voltsDisplay;
        private System.Windows.Forms.ComboBox comPortDropdown;
        private System.Windows.Forms.Button connectSerialButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox massDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tareButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sdevDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox massOffsetDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox massDisplayAvgRaw;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox massDisplayAvg;
        private System.Windows.Forms.Label kgLabel;
    }
}

