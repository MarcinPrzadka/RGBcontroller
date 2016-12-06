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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBox1.Items.AddRange(SerialPort.GetPortNames());

            //sortowanie wyswietlanych nazw dostępnych portów
            comboBox1.Sorted = true; 

            //przypisanie wartosci domyslnych w rozwijanych listach wyboru
            comboBox1.SelectedIndex = 0;   //pierwszy dostępny port
            
            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBox1.Enabled = true;   //lista z portami
            button1.Enabled = false;    //przycisk wyślij
            button2.Enabled = true;     //przycisk połącz
            buttonRedOn.Enabled = false;    //przycisk rozłącz
            buttonRedOff.Enabled = false;
            buttonGreenOn.Enabled = false;
            buttonGreenOff.Enabled = false;
            buttonBlueOn.Enabled = false;
            buttonBlueOff.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            {
               serialPort.Close(); //zamknięciu portu - odłączenie

                //aktywacja i deaktywacja odpowiednich przyciskow
                comboBox1.Enabled = true;  
                button1.Enabled = true;    
                button2.Enabled = true;    
                buttonRedOn.Enabled = true;    
                buttonRedOff.Enabled = true;
                buttonGreenOn.Enabled = true;
                buttonGreenOff.Enabled = true;
                buttonBlueOn.Enabled = true;
                buttonBlueOff.Enabled = true;
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
                serialPort.PortName = comboBox1.Text;
                serialPort.Open();

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;        //przycisk połącz
                buttonRedOn.Enabled = true;    //przycisk rozłącz
                buttonRedOff.Enabled = true;
                buttonGreenOn.Enabled = true;
                buttonGreenOff.Enabled = true;
                buttonBlueOn.Enabled = true;
                buttonBlueOff.Enabled = true;


            }
            catch
            {
                //jeżeli wystąpi błąd
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort.Write("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort.Write("2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort.Write("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort.Write("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort.Write("6");
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
    }
    }

