namespace GUI_UART
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.OPEN = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.Kps_txtbox = new System.Windows.Forms.TextBox();
            this.Kis_txtbox = new System.Windows.Forms.TextBox();
            this.Kds_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RUN = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Setpoint_txt = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.send = new System.Windows.Forms.Button();
            this.Ts_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Kpi_txtbox = new System.Windows.Forms.TextBox();
            this.Kii_txtbox = new System.Windows.Forms.TextBox();
            this.Kdi_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Speed_txtbox = new System.Windows.Forms.TextBox();
            this.pwm_txtbox = new System.Windows.Forms.TextBox();
            this.Iref_txtbox = new System.Windows.Forms.TextBox();
            this.Idc_txtbox = new System.Windows.Forms.TextBox();
            this.Speed = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(40, 229);
            this.OPEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(143, 59);
            this.OPEN.TabIndex = 0;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Location = new System.Drawing.Point(312, 229);
            this.CLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(143, 59);
            this.CLOSE.TabIndex = 1;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // Kps_txtbox
            // 
            this.Kps_txtbox.Location = new System.Drawing.Point(304, 44);
            this.Kps_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kps_txtbox.Name = "Kps_txtbox";
            this.Kps_txtbox.Size = new System.Drawing.Size(100, 22);
            this.Kps_txtbox.TabIndex = 2;
            this.Kps_txtbox.TextChanged += new System.EventHandler(this.Kp_TextChanged);
            // 
            // Kis_txtbox
            // 
            this.Kis_txtbox.Location = new System.Drawing.Point(511, 44);
            this.Kis_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kis_txtbox.Name = "Kis_txtbox";
            this.Kis_txtbox.Size = new System.Drawing.Size(100, 22);
            this.Kis_txtbox.TabIndex = 3;
            this.Kis_txtbox.TextChanged += new System.EventHandler(this.Ki_txtbox_TextChanged);
            // 
            // Kds_txtbox
            // 
            this.Kds_txtbox.Location = new System.Drawing.Point(719, 44);
            this.Kds_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kds_txtbox.Name = "Kds_txtbox";
            this.Kds_txtbox.Size = new System.Drawing.Size(100, 22);
            this.Kds_txtbox.TabIndex = 4;
            this.Kds_txtbox.TextChanged += new System.EventHandler(this.Kd_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kd";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(511, 229);
            this.RUN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(143, 59);
            this.RUN.TabIndex = 10;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(869, 229);
            this.STOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(143, 59);
            this.STOP.TabIndex = 11;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Setpoint";
            // 
            // Setpoint_txt
            // 
            this.Setpoint_txt.Location = new System.Drawing.Point(108, 44);
            this.Setpoint_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setpoint_txt.Name = "Setpoint_txt";
            this.Setpoint_txt.Size = new System.Drawing.Size(100, 22);
            this.Setpoint_txt.TabIndex = 12;
            this.Setpoint_txt.TextChanged += new System.EventHandler(this.Setpoint_txt_TextChanged);
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(40, 345);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(972, 273);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(896, 146);
            this.send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(116, 46);
            this.send.TabIndex = 15;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Ts_txtbox
            // 
            this.Ts_txtbox.Location = new System.Drawing.Point(911, 44);
            this.Ts_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ts_txtbox.Name = "Ts_txtbox";
            this.Ts_txtbox.Size = new System.Drawing.Size(100, 22);
            this.Ts_txtbox.TabIndex = 8;
            this.Ts_txtbox.TextChanged += new System.EventHandler(this.Ts_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ts";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Speed";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Current";
            // 
            // Kpi_txtbox
            // 
            this.Kpi_txtbox.Location = new System.Drawing.Point(108, 111);
            this.Kpi_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kpi_txtbox.Name = "Kpi_txtbox";
            this.Kpi_txtbox.Size = new System.Drawing.Size(99, 22);
            this.Kpi_txtbox.TabIndex = 18;
            this.Kpi_txtbox.TextChanged += new System.EventHandler(this.Kpi_txtbox_TextChanged);
            // 
            // Kii_txtbox
            // 
            this.Kii_txtbox.Location = new System.Drawing.Point(307, 108);
            this.Kii_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kii_txtbox.Name = "Kii_txtbox";
            this.Kii_txtbox.Size = new System.Drawing.Size(96, 22);
            this.Kii_txtbox.TabIndex = 19;
            // 
            // Kdi_txtbox
            // 
            this.Kdi_txtbox.Location = new System.Drawing.Point(511, 107);
            this.Kdi_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kdi_txtbox.Name = "Kdi_txtbox";
            this.Kdi_txtbox.Size = new System.Drawing.Size(97, 22);
            this.Kdi_txtbox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ki";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kd";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Respone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(232, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Pwm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 166);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Iref";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(660, 171);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Idc";
            // 
            // Speed_txtbox
            // 
            this.Speed_txtbox.Location = new System.Drawing.Point(108, 166);
            this.Speed_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Speed_txtbox.Name = "Speed_txtbox";
            this.Speed_txtbox.Size = new System.Drawing.Size(93, 22);
            this.Speed_txtbox.TabIndex = 29;
            // 
            // pwm_txtbox
            // 
            this.pwm_txtbox.Location = new System.Drawing.Point(312, 167);
            this.pwm_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwm_txtbox.Name = "pwm_txtbox";
            this.pwm_txtbox.Size = new System.Drawing.Size(91, 22);
            this.pwm_txtbox.TabIndex = 30;
            // 
            // Iref_txtbox
            // 
            this.Iref_txtbox.Location = new System.Drawing.Point(516, 165);
            this.Iref_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Iref_txtbox.Name = "Iref_txtbox";
            this.Iref_txtbox.Size = new System.Drawing.Size(93, 22);
            this.Iref_txtbox.TabIndex = 31;
            // 
            // Idc_txtbox
            // 
            this.Idc_txtbox.Location = new System.Drawing.Point(720, 165);
            this.Idc_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Idc_txtbox.Name = "Idc_txtbox";
            this.Idc_txtbox.Size = new System.Drawing.Size(97, 22);
            this.Idc_txtbox.TabIndex = 32;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(477, 309);
            this.Speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(80, 16);
            this.Speed.TabIndex = 33;
            this.Speed.Text = "Speed chart";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 631);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Current chart";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(41, 663);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(971, 321);
            this.chart2.TabIndex = 35;
            this.chart2.Text = "chart2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 37;
            this.button2.Tag = "Step_profile";
            this.button2.Text = "Step profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 38;
            this.button3.Tag = "Ramp_profile";
            this.button3.Text = "Ramp profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 1040);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Idc_txtbox);
            this.Controls.Add(this.Iref_txtbox);
            this.Controls.Add(this.pwm_txtbox);
            this.Controls.Add(this.Speed_txtbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Kdi_txtbox);
            this.Controls.Add(this.Kii_txtbox);
            this.Controls.Add(this.Kpi_txtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.send);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Setpoint_txt);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ts_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kds_txtbox);
            this.Controls.Add(this.Kis_txtbox);
            this.Controls.Add(this.Kps_txtbox);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.OPEN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.TextBox Kps_txtbox;
        private System.Windows.Forms.TextBox Kis_txtbox;
        private System.Windows.Forms.TextBox Kds_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Setpoint_txt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox Ts_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Kpi_txtbox;
        private System.Windows.Forms.TextBox Kii_txtbox;
        private System.Windows.Forms.TextBox Kdi_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Speed_txtbox;
        private System.Windows.Forms.TextBox pwm_txtbox;
        private System.Windows.Forms.TextBox Iref_txtbox;
        private System.Windows.Forms.TextBox Idc_txtbox;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

