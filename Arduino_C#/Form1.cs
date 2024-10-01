using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_C_
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            //crear serial port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM8"; // cehcar en el equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //vincular eventos
            this.FormClosing += CerrandoForm1;
            this.Bapagar.Click += Bapagar_Click;
            this.Bencender.Click += Bencender_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bapagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void Bencender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}
