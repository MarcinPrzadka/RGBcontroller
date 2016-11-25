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
            button3.Enabled = false;    //przycisk rozłącz
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

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
                button3.Enabled = true;    
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
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
                button3.Enabled = true;    //przycisk rozłącz
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;


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
    }
    }

