﻿using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            comboBoxRedLamp.SelectedIndex = 0;
            comboBoxYellowLamp.SelectedIndex = 0;
            comboBoxGreenLamp.SelectedIndex = 0;
            comboBoxBlueLamp.SelectedIndex = 0;
            comboBoxWhiteLamp.SelectedIndex = 0;
            comboBoxSounder.SelectedIndex = 0;

            textBox3.Text = "10.0.0.246";
            textBox4.Text = "502";
            textBox5.Text = "1000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to Modbus       
                string ipAddress = textBox3.Text.ToString();
                int tcpPort = Convert.ToInt16(textBox4.Text);

                TcpClient tcpClient = new TcpClient(ipAddress, tcpPort);

                if (!tcpClient.Connected)
                {
                    tcpClient.Connect(ipAddress, tcpPort);
                    Console.WriteLine("tcp client not connected @ : {0}", DateTime.Now);
                }

                // create Modbus TCP Master by the tcp client
                ModbusIpMaster master = ModbusIpMaster.CreateIp(tcpClient);
                               
                //return master;
            }
            catch (Exception ex)
            {
                Console.Write("Exception: " + ex.ToString());
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }
        }

        private void readOutputs_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort startAddress = 512;
            ushort numOfPoints = 16;
            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            try
            {
                bool[] outputArr = master.ReadCoils(startAddress, numOfPoints);

                listView1.Items.Clear();

                for (int i = 0; i < numOfPoints; i++)
                {
                    int n = i + 1;
                    listView1.Items.Add(comboBox1.Items[i].ToString()).SubItems.Add(outputArr[i].ToString());
                }

                tcpClient.Close();
                master.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                //throw;
            }


        }

        //*****************************************************************************

        private ModbusIpMaster ConnectToModbus()
        {
            try
            {
                // connect new Tcp Client       
                string ipAddress = textBox3.Text.ToString();
                int tcpPort = Convert.ToInt16(textBox4.Text);

                TcpClient tcpClient = new TcpClient(ipAddress, tcpPort);

                if (!tcpClient.Connected)
                {
                    tcpClient.Connect(ipAddress, tcpPort);
                    Console.WriteLine("tcp client not connected @ : {0}", DateTime.Now);
                }

                // create Modbus TCP Master by the tcp client
                ModbusIpMaster master = ModbusIpMaster.CreateIp(tcpClient);

                return master;
            }
            catch (Exception ex)
            {
                Console.Write("Exception: " + ex.ToString());
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Connect TcpClient
        /// </summary>
        /// <returns></returns>
        private TcpClient ConnectTcpClient()
        {
            // connect new Tcp Client       
            string ipAddress = textBox3.Text.ToString();
            int tcpPort = Convert.ToInt16(textBox4.Text);

            try
            {
                TcpClient tcpClient = new TcpClient(ipAddress, tcpPort);
                if (!tcpClient.Connected)
                {
                    tcpClient.Connect(ipAddress, tcpPort);
                    Console.WriteLine("tcp client not connected @ : {0}", DateTime.Now);
                }

                return tcpClient;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }

        }
        //*****************************************************************************

        /// <summary>
        /// Connect to Modbus Master
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <returns></returns>
        private ModbusIpMaster ConnectModbusMaster(TcpClient tcpClient)
        {
            // create Modbus TCP Master by the tcp client
            try
            {
                ModbusIpMaster master = ModbusIpMaster.CreateIp(tcpClient);
                return master;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }

        }
        //*****************************************************************************


        private void readInputs_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort startAddress = 0;
            ushort numOfPoints = 16; // 2 x 8 inputs
            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            try
            {
                bool[] outputArr = master.ReadInputs(startAddress, numOfPoints);

                listView1.Items.Clear();
                
                for (int i = 0; i < numOfPoints; i++)
                {
                    int n = i + 1;
                    listView1.Items.Add(comboBox3.Items[i].ToString()).SubItems.Add(outputArr[i].ToString());
                }

                tcpClient.Close();
                master.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                //throw;
            }
        }

        private void readSingleCoil_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            int selectedOutput = Convert.ToInt16(comboBox1.SelectedIndex.ToString());
            int startAddress = 512;
            int o = selectedOutput + startAddress;
            ushort readAddress = (ushort)o;

            try 
	        {	        
		        bool[] outputValue = master.ReadCoils(readAddress, 1);
                textBox1.Text = outputValue[0].ToString();
	        }
	        catch (Exception ex)
	        {
		        MessageBox.Show("Exception: " + ex.ToString());
		        throw;
	        }

            tcpClient.Close();
            master.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            int selectedOutput = Convert.ToInt16(comboBox1.SelectedIndex.ToString());
            bool selectedState = Convert.ToBoolean(comboBox2.SelectedItem.ToString());
            int startAddress = 512;
            int o = selectedOutput + startAddress;
            ushort readAddress = (ushort)o;

            try
            {
                master.WriteSingleCoil(readAddress, selectedState);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }
            
            tcpClient.Close();
            master.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            int selectedInput = Convert.ToInt16(comboBox3.SelectedIndex.ToString());
            int startAddress = 0;
            int i = selectedInput + startAddress;
            ushort readAddress = (ushort)i;

            try
            {
                bool[] inputValue = master.ReadInputs(readAddress, 1);
                textBox2.Text = inputValue[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                throw;
            }

            tcpClient.Close();
            master.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void writeMultipleCoils_Click(object sender, EventArgs e)
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            bool selectedState = Convert.ToBoolean(comboBox2.SelectedItem.ToString());
            int startAddress = 512;
            int o = startAddress;
            ushort readAddress = (ushort)o;
            ushort numberOfCoils = 16; // 2 x 8 outputs

            bool[] boolArray = new bool[numberOfCoils];

            for (int i = 0; i <= 15; i++)
            {
                boolArray[i] = selectedState;
            }

                try
                {
                    master.WriteMultipleCoils(readAddress, boolArray);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.ToString());
                    throw;
                }

            tcpClient.Close();
            master.Dispose();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Thread redLamp = new Thread(new ThreadStart(RedLampControl));

            if (checkBox1.Checked)
            {                
                redLamp.Start();
            }
            
        }

        private void RedLampControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort redLampAddress = 512;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox1.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() {run = checkBox1.Checked == true ? true : false; });
                
                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxRedLamp.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(redLampAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(redLampAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(redLampAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(redLampAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Environment.Exit(Environment.ExitCode);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Thread yellowLamp = new Thread(new ThreadStart(YellowLampControl));

            if (checkBox2.Checked)
            {
                yellowLamp.Start();
            }
        }

        private void YellowLampControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort yellowLampAddress = 513;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox2.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() { run = checkBox2.Checked == true ? true : false; });

                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxYellowLamp.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(yellowLampAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(yellowLampAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(yellowLampAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(yellowLampAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Thread greenLamp = new Thread(new ThreadStart(GreenLampControl));

            if (checkBox3.Checked)
            {
                greenLamp.Start();
            }
        }

        private void GreenLampControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort greenLampAddress = 514;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox3.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() { run = checkBox3.Checked == true ? true : false; });

                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxGreenLamp.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(greenLampAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(greenLampAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(greenLampAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(greenLampAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread blueLamp = new Thread(new ThreadStart(BlueLampControl));

            if (checkBox4.Checked)
            {
                blueLamp.Start();
            }
        }

        private void BlueLampControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort blueLampAddress = 515;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox4.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() { run = checkBox4.Checked == true ? true : false; });

                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxBlueLamp.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(blueLampAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(blueLampAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(blueLampAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(blueLampAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Thread whiteLamp = new Thread(new ThreadStart(WhiteLampControl));

            if (checkBox5.Checked)
            {
                whiteLamp.Start();
            }
        }

        private void WhiteLampControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort whiteLampAddress = 516;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox5.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() { run = checkBox5.Checked == true ? true : false; });

                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxWhiteLamp.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(whiteLampAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(whiteLampAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(whiteLampAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(whiteLampAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Thread sounder = new Thread(new ThreadStart(SounderControl));

            if (checkBox6.Checked)
            {
                sounder.Start();
            }
        }

        private void SounderControl()
        {
            //connect to modbus...
            TcpClient tcpClient = ConnectTcpClient();
            ModbusIpMaster master = ConnectModbusMaster(tcpClient);

            ushort sounderAddress = 517;
            int index = 0;
            bool run = false;

            bool pulseState = false;

            master.Transport.ReadTimeout = Convert.ToInt16(textBox5.Text);

            // get state checkbox
            this.Invoke((MethodInvoker)delegate() { run = checkBox6.Checked == true ? true : false; });

            while (run)
            {
                // get state checkbox...                
                this.Invoke((MethodInvoker)delegate() { run = checkBox6.Checked == true ? true : false; });

                // get state checkboxLamp...
                this.Invoke((MethodInvoker)delegate() { index = comboBoxSounder.SelectedIndex; });

                // set the lamp according checkboxLamp state...
                if (index == 0)
                    master.WriteSingleCoil(sounderAddress, false);
                if (index == 1)
                    master.WriteSingleCoil(sounderAddress, true);

                if (index == 2)
                {
                    pulseState = !pulseState;
                    master.WriteSingleCoil(sounderAddress, pulseState);
                    Thread.Sleep(500);
                }


            }

            // turn off before exit
            master.WriteSingleCoil(sounderAddress, false);

            master.Dispose();
            Thread.CurrentThread.Abort();

        }

    }
}
