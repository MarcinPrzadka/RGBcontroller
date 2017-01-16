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
           serialPort.Write('r'+trackBarRed.Value.ToString());
           textBoxMix.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
           textBoxRed.BackColor = Color.FromArgb(trackBarRed.Value, 0, 0);
           textBoxRed.Text = trackBarRed.Value.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            serialPort.Write('g'+trackBarGreen.Value.ToString());
            textBoxMix.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            textBoxGreen.BackColor = Color.FromArgb(0, trackBarGreen.Value, 0);
            textBoxGreen.Text = trackBarGreen.Value.ToString();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            serialPort.Write('b'+trackBarBlue.Value.ToString());
            textBoxMix.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            textBoxBlue.BackColor = Color.FromArgb(0,0,trackBarBlue.Value);
            textBoxBlue.Text = trackBarBlue.Value.ToString();
        }

        private void textBoxMix_TextChanged(object sender, EventArgs e){ }
    }
    }