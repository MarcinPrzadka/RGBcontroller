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
                //jeżeli wystąpi błąd
               
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {

            try //zabezpieczenie przed wystąpieniem wyjątku/problemu z otwarciem portu
            {
                //otwarcie wybranego portu
                serialPort.PortName = comboBoxPort.Text;
                serialPort.Open();

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
                //jeżeli wystąpi błąd
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
           // serialPort.Write("Red");
           serialPort.Write('r'+trackBarRed.Value.ToString());
           labelRed.Text = "Red is : " + trackBarRed.Value;
        
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            //serialPort.Write("Green");
            serialPort.Write('g'+trackBarGreen.Value.ToString());
            labelGreen.Text = "Green is : " + trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            //serialPort.Write("Blue");
            serialPort.Write('b'+trackBarBlue.Value.ToString());
            labelBlue.Text = "Blue is : " + trackBarBlue.Value;
        }

        private void buttonRedOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("r100");
        }

        private void buttonRedOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("r0");
        }

        private void buttonGreenOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("g100");
        }

        private void buttonGreenOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("g0");
        }

        private void buttonBlueOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("b100");
        }

        private void buttonBlueOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("b0");
        }
        
    }
    }

