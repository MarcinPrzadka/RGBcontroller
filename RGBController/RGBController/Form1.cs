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

namespace RGBController
{
    public partial class RGBController : Form
    {
        public RGBController()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());

            //sortowanie wyswietlanych nazw dostępnych portów
            comboBoxPort.Sorted = true; 

            //przypisanie wartosci domyslnych w rozwijanych listach wyboru
            comboBoxPort.SelectedIndex = 0;   //pierwszy dostępny port
            
            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBoxPort.Enabled = true;   //lista z portami
            buttonDisconnect.Enabled = false;    //przycisk wyślij
            buttonConnect.Enabled = true;     //przycisk połącz
            buttonRedOn.Enabled = false;    //przycisk rozłącz
            buttonRedOff.Enabled = false;
            buttonGreenOn.Enabled = false;
            buttonGreenOff.Enabled = false;
            buttonBlueOn.Enabled = false;
            buttonBlueOff.Enabled = false;
            trackBarBlue.Enabled = false;
            trackBarGreen.Enabled = false;
            trackBarRed.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            {
               serialPort.Close(); //zamknięciu portu - odłączenie
               labelStatus.Text = "Disconnected!";

                //aktywacja i deaktywacja odpowiednich przyciskow
                comboBoxPort.Enabled = true;   //lista z portami
                buttonDisconnect.Enabled = false;    //przycisk wyślij
                buttonConnect.Enabled = true; //przycisk połącz
                buttonRedOn.Enabled = false;    //przycisk rozłącz
                buttonRedOff.Enabled = false;
                buttonGreenOn.Enabled = false;
                buttonGreenOff.Enabled = false;
                buttonBlueOn.Enabled = false;
                buttonBlueOff.Enabled = false;
                trackBarBlue.Enabled = false;
                trackBarGreen.Enabled = false;
                trackBarRed.Enabled = false;
            }
            catch
            {
                labelStatus.Text = "Error!"; //jeżeli wystąpi błąd
               
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {

            try //zabezpieczenie przed wystąpieniem wyjątku/problemu z otwarciem portu
            {
                //otwarcie wybranego portu
                serialPort.PortName = comboBoxPort.Text;
                serialPort.Open();
                labelStatus.Text = "Connected!";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBoxPort.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonConnect.Enabled = false;        //przycisk połącz
                buttonRedOn.Enabled = true;    //przycisk rozłącz
                buttonRedOff.Enabled = true;
                buttonGreenOn.Enabled = true;
                buttonGreenOff.Enabled = true;
                buttonBlueOn.Enabled = true;
                buttonBlueOff.Enabled = true;
                trackBarBlue.Enabled = true;
                trackBarGreen.Enabled = true;
                trackBarRed.Enabled = true;


            }
            catch
            {
                labelStatus.Text = "Error!"; //jeżeli wystąpi błąd
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
           // serialPort.Write("Red");
           serialPort.Write('r'+trackBarRed.Value.ToString());
           labelRed.Text = "Red is : " + trackBarRed.Value;
           textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            //serialPort.Write("Green");
            serialPort.Write('g'+trackBarGreen.Value.ToString());
            labelGreen.Text = "Green is : " + trackBarGreen.Value;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            //serialPort.Write("Blue");
            serialPort.Write('b'+trackBarBlue.Value.ToString());
            labelBlue.Text = "Blue is : " + trackBarBlue.Value;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonRedOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("r255");
            labelRed.Text = "Red is : 255";
            trackBarRed.Value = 255;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonRedOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("r0");
            labelRed.Text = "Red is : 0";
            trackBarRed.Value = 0;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonGreenOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("g255");
            labelGreen.Text = "Green is : 255";
            trackBarGreen.Value = 255;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonGreenOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("g0");
            labelGreen.Text = "Green is : 0";
            trackBarGreen.Value = 0;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonBlueOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("b255");
            labelBlue.Text = "Blue is : 255";
            trackBarBlue.Value = 255;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonBlueOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("b0");
            labelBlue.Text = "Blue is : 0";
            trackBarBlue.Value = 0;
            textBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }



        
    }
    }

