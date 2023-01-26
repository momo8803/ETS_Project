using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS_ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelethonSystemWin
{
    public partial class ETSTelethon : Form
    {
        ETSManager etsManager = new ETSManager();
        public ETSTelethon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("Invalid input! Cannot be empty");
            }
            else
            {
                string message = etsManager.addSponsor(textBox3.Text, 0,textBox1.Text, textBox2.Text);
                MessageBox.Show(message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string allSponsor = etsManager.getAllSponsorInfo();
            if (allSponsor.Length == 0)
            {
                MessageBox.Show("It is Empty!");
            }
            else
            {
                richTextBox1.AppendText(allSponsor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0 || textBox6.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0)
            {
                MessageBox.Show("Invalid input! Cannot be empty");
            }
            else
            {
                string message = etsManager.addPrize(textBox4.Text, textBox5.Text, 
                    double.Parse(textBox6.Text), int.Parse(textBox7.Text), 
                    double.Parse(textBox8.Text),textBox20.Text);                
                MessageBox.Show(message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string allprize = etsManager.getAllPrizeInfo();
            if (allprize.Length == 0)
            {
                MessageBox.Show("It is Empty!");
            }
            else
            {
                richTextBox1.AppendText(allprize);
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (textBox14.Text.Length == 0 || textBox15.Text.Length == 0)
            {
                MessageBox.Show("Invalid input! Cannot be empty");
            }
            else
            {
                string message = etsManager.addDonation(textBox14.Text,
                Convert.ToDouble(textBox15.Text), Convert.ToString(dateTime));

                MessageBox.Show(message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string allDonations = etsManager.getAllDonationInfo();
            if(allDonations.Length == 0)
            {
                MessageBox.Show("It is Empty!");
            }
            else
            {
                richTextBox1.AppendText(allDonations);               
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string allDonors = etsManager.getAllDonorInfo();
            //richTextBox1.AppendText(allDonors);
            if (allDonors.Length == 0)
            {
                MessageBox.Show("It is Empty!");
            }
            else
            {
                richTextBox1.AppendText(allDonors);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = etsManager.saveDonorIntoFile();
            MessageBox.Show(message);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox18.Text.Length == 0 || textBox19.Text.Length == 0)
            {
                MessageBox.Show("Invalid input! Cannot be empty");
            }
            else
            {                
                string message = etsManager.showPrize(textBox18.Text);
                if (message.Length == 0)
                {
                    MessageBox.Show("Cant find this prize ID");
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            char cardType = ' ';
bool flag = false;
            if (textBox5.Text.Length == 9 || textBox12.Text.Length == 0 || textBox13.Text.Length == 0 || textBox16.Text.Length == 0 ||
                textBox17.Text.Length == 9 || textBox10.Text.Length == 0 || textBox11.Text.Length == 0)
            {
                MessageBox.Show("Invalid input! Cannot be empty");
            }
            else
            {
                
                if (visabtn.Checked)
                {
                    cardType = 'V';
                    flag = true;
                }
                else if (mcbtn.Checked)
                {
                    cardType = 'M';
                    flag = true;
                }
                else if (amexbtn.Checked)
                {
                    cardType = 'A';
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Choose a card type!");

                }
            }
                
                    if (flag == true)
                    {
                        string message = etsManager.addDonor(textBox9.Text,
                        textBox12.Text, textBox13.Text, Convert.ToChar(cardType), textBox16.Text,
                        textBox17.Text, textBox10.Text, textBox11.Text);
                        MessageBox.Show(message);
                    }
                            
            
        }
    }
}
