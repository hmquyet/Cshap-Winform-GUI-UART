using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_UART
{
    public partial class Form1 : Form
    {
        private double time, setpoint, Kps, Kis, Kds, Kpi, Kii, Kdi, speed, pwm, Iref, Idc, Ts, time_speed, time_Iref, time_Idc, n, step_enable, ramp_enable, tick;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick = tick + 1;
            time = tick * 0.1;
            if(step_enable == 1)
            {
                if(time == 0.2)
                {
                    Setpoint_txt.Text = "100";
                    send_Click(sender, e);
                }    
                else if(time == 2)
                {
                    Setpoint_txt.Text = "180";
                    send_Click(sender, e);
                }
                else if (time == 4)
                {
                    Setpoint_txt.Text = "90";
                    send_Click(sender, e);
                }
                else if (time == 6)
                {
                    Setpoint_txt.Text = "0";
                    send_Click(sender, e);
                }
                else if (time == 8)
                {
                    Setpoint_txt.Text = "-90";
                    send_Click(sender, e);
                }
                else if (time == 10)
                {
                    Setpoint_txt.Text = "-180";
                    send_Click(sender, e);
                }
                else if (time == 12)
                {
                    Setpoint_txt.Text = "-100";
                    send_Click(sender, e);
                }
                else if (time == 14)
                {
                    Setpoint_txt.Text = "0";
                    send_Click(sender, e);
                }
                else if(time == 16)
                {
                    STOP_Click(sender, e);
                    tick = 0;
                }
            }
        }

        private void Ts_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("V");
            string dataToSend = new string('*', 56);
            serialPort1.Write(dataToSend);
            //timer1.Enabled = true;
            ramp_enable = 1;
            step_enable = 0;
        }

        private void Kd_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("R");
            string dataToSend = new string('*', 56);
            serialPort1.Write(dataToSend);
            timer1.Enabled = true;
            step_enable = 1;
            ramp_enable = 0;
        }

        private void Ki_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;

            // Draw chart 1
            chart1.Series[0].Name = "Setpoint";

            // Tạo một Series mới với tên "Dữ liệu"
            Series dataSeries = new Series("Speed");

            // Đặt tên cột x và y cho Series "Dữ liệu"
            dataSeries.XValueMember = "Time";
            dataSeries.YValueMembers = "Speed";
            dataSeries.ChartType = SeriesChartType.Line;
            chart1.Series[0].ChartType = SeriesChartType.Line;

            // Thêm Series vào biểu đồ
            chart1.Series.Add(dataSeries);

            // Thiết lập tầm giá trị của đồ thị
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = -200;
            chart1.ChartAreas[0].AxisY.Maximum = 200;

            // Draw chart 2
            chart2.Series[0].Name = "Iref";
            Series dataSeries2 = new Series("Idc");
            dataSeries2.XValueMember = "Time";
            dataSeries2.YValueMembers = "Idc";
            dataSeries2.ChartType = SeriesChartType.Line;
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series.Add(dataSeries2);
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 10;
            chart2.ChartAreas[0].AxisY.Minimum = -5;
            chart2.ChartAreas[0].AxisY.Maximum = 5;

            // Init default mode
            Setpoint_txt.Text = "0";
            Kps_txtbox.Text = "0.0004";
            Kis_txtbox.Text = "0.002";
            Kds_txtbox.Text = "0.00001";
            Kpi_txtbox.Text = "0";
            Kii_txtbox.Text = "0";
            Kdi_txtbox.Text = "0";
            Ts_txtbox.Text = "0.01";
            time_speed = 0;
            time_Idc = 0;
            time_Iref = 0;
            n = 5;
            Ts = 0.01*n;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string rev_data = serialPort1.ReadLine();
            // Update setpoint
            if(rev_data.StartsWith("V"))
            {
                rev_data = rev_data.Substring(1);
                Setpoint_txt.Text = rev_data;
                setpoint = Convert.ToDouble(rev_data);
            }
            // Draw speed
            if (rev_data.StartsWith("S"))
            {
                rev_data = rev_data.Substring(1);
                Speed_txtbox.Text = rev_data;
                speed = Convert.ToDouble(rev_data);
                chart1.Series["Setpoint"].Points.AddXY(time_speed * Ts, setpoint);
                chart1.Series["Speed"].Points.AddXY(time_speed * Ts, speed);
                if (time_speed * Ts > chart1.ChartAreas[0].AxisX.Maximum)
                {
                    chart1.ChartAreas[0].AxisX.Maximum += time_speed * Ts;
                }
                if (speed > chart1.ChartAreas[0].AxisY.Maximum)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = speed * 1.2;
                }
                if (speed < chart1.ChartAreas[0].AxisY.Minimum)
                {
                    chart1.ChartAreas[0].AxisY.Minimum = speed * 1.2;
                }
                time_speed = time_speed + 1;
            }
            // Draw Iref
            else if(rev_data.StartsWith("R"))
            {
                rev_data = rev_data.Substring(1);
                Iref_txtbox.Text = rev_data;
                Iref = Convert.ToDouble(rev_data);
                chart2.Series["Iref"].Points.AddXY(time_Iref * Ts, Iref);
                if (time_Iref * Ts > chart2.ChartAreas[0].AxisX.Maximum)
                {
                    chart2.ChartAreas[0].AxisX.Maximum += time_Iref * Ts;
                }
                if (Iref > chart2.ChartAreas[0].AxisY.Maximum)
                {
                    chart2.ChartAreas[0].AxisY.Maximum = Iref * 1.2;
                }
                if (Iref < chart2.ChartAreas[0].AxisY.Minimum)
                {
                    chart2.ChartAreas[0].AxisY.Minimum = Iref * 1.2;
                }
                time_Iref = time_Iref + 1;
            }
            // Draw Idc
            else if(rev_data.StartsWith("I"))
            {
                rev_data = rev_data.Substring(1);
                Idc_txtbox.Text = rev_data;
                Idc = Convert.ToDouble(rev_data);
                chart2.Series["Idc"].Points.AddXY(time_Idc * Ts, Idc);
                if (time_Idc * Ts > chart2.ChartAreas[0].AxisX.Maximum)
                {
                    chart2.ChartAreas[0].AxisX.Maximum += time_Idc * Ts;
                }
                if (Idc > chart2.ChartAreas[0].AxisY.Maximum)
                {
                    chart2.ChartAreas[0].AxisY.Maximum = Idc * 1.2;
                }
                if (Idc < chart2.ChartAreas[0].AxisY.Minimum)
                {
                    chart2.ChartAreas[0].AxisY.Minimum = Idc * 1.2;
                }
                time_Idc = time_Idc + 1;
            }
            // Show pwm
            else if(rev_data.StartsWith("u"))
            {
                rev_data = rev_data.Substring(1);
                pwm_txtbox.Text = rev_data;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Kp_TextChanged(object sender, EventArgs e)
        {

        }

        private void RUN_Click(object sender, EventArgs e)
        {
            serialPort1.Write("R");
            string dataToSend = new string('*', 56);
            serialPort1.Write(dataToSend);
            timer1.Enabled = true;
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
            string dataToSend = new string('*', 56);
            serialPort1.Write(dataToSend);
            timer1.Enabled = false;
        }

        private void Setpoint_txt_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void send_Click(object sender, EventArgs e)
        {
            serialPort1.Write("P");
            setpoint = Convert.ToDouble(Setpoint_txt.Text);
            serialPort1.Write(Setpoint_txt.Text.PadLeft(8, '0'));
            serialPort1.Write(Kps_txtbox.Text.PadLeft(8, '0'));
            serialPort1.Write(Kis_txtbox.Text.PadLeft(8, '0'));
            serialPort1.Write(Kds_txtbox.Text.PadLeft(8, '0'));
            serialPort1.Write(Kpi_txtbox.Text.PadLeft(8, '0'));
            serialPort1.Write(Kii_txtbox.Text.PadLeft(8, '0'));
            serialPort1.Write(Kdi_txtbox.Text.PadLeft(8, '0'));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Kpi_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
