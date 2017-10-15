using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PillPilot
{
    public partial class Form1 : Form
    {
        int a = 0;

        public Form1()
        {
            InitializeComponent();
            JustTime();
            LoadMedicineList();
            timer1.Start();
        }

        private async void Blink(TextBox tb)
        {
            while (timer1.Enabled)
            {
                await Task.Delay(500);
                tb.BackColor = tb.BackColor == Color.White ? Color.Red : Color.White;
            }
        }

        public void JustTime()
        {
            morgenAlarm1.Format = DateTimePickerFormat.Time;
            morgenHvornår1.Format = DateTimePickerFormat.Time;
            morgenAlarm2.Format = DateTimePickerFormat.Time;
            morgenHvornår2.Format = DateTimePickerFormat.Time;
            middagAlarm1.Format = DateTimePickerFormat.Time;
            middagHvornår1.Format = DateTimePickerFormat.Time;
            middagAlarm2.Format = DateTimePickerFormat.Time;
            middagHvornår2.Format = DateTimePickerFormat.Time;
            aftenAlarm1.Format = DateTimePickerFormat.Time;
            aftenHvornår1.Format = DateTimePickerFormat.Time;
            aftenAlarm2.Format = DateTimePickerFormat.Time;
            aftenHvornår2.Format = DateTimePickerFormat.Time;

            morgenAlarm1.Format = DateTimePickerFormat.Custom;
            morgenAlarm1.CustomFormat = "HH:mm";
            morgenAlarm2.Format = DateTimePickerFormat.Custom;
            morgenAlarm2.CustomFormat = "HH:mm";
            middagAlarm1.Format = DateTimePickerFormat.Custom;
            middagAlarm1.CustomFormat = "HH:mm";
            middagAlarm2.Format = DateTimePickerFormat.Custom;
            middagAlarm2.CustomFormat = "HH:mm";
            aftenAlarm1.Format = DateTimePickerFormat.Custom;
            aftenAlarm1.CustomFormat = "HH:mm";
            aftenAlarm2.Format = DateTimePickerFormat.Custom;
            aftenAlarm2.CustomFormat = "HH:mm";

            morgenHvornår1.Format = DateTimePickerFormat.Custom;
            morgenHvornår1.CustomFormat = " ";
            morgenHvornår2.Format = DateTimePickerFormat.Custom;
            morgenHvornår2.CustomFormat = " ";
            middagHvornår1.Format = DateTimePickerFormat.Custom;
            middagHvornår1.CustomFormat = " ";
            middagHvornår2.Format = DateTimePickerFormat.Custom;
            middagHvornår2.CustomFormat = " ";
            aftenHvornår1.Format = DateTimePickerFormat.Custom;
            aftenHvornår1.CustomFormat = " ";
            aftenHvornår2.Format = DateTimePickerFormat.Custom;
            aftenHvornår2.CustomFormat = " ";
        }

        private void LoadMedicineList()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ole Kjaerulff\Documents\PillPilotData\MedicineList.txt");
            morgenNavnText1.Text = lines[0];
            morgenDosisText1.Text = lines[1];
            morgenFormText1.Text = lines[2];
            morgenFarveText1.Text = lines[3];
            morgenAlarm1.Text = lines[4];
            morgenNavnText2.Text = lines[5];
            morgenDosisText2.Text = lines[6];
            morgenFormText2.Text = lines[7];
            morgenFarveText2.Text = lines[8];
            morgenAlarm2.Text = lines[9];

            middagNavnText1.Text = lines[10];
            middagDosisText1.Text = lines[11];
            middagFormText1.Text = lines[12];
            middagFarveText1.Text = lines[13];
            middagAlarm1.Text = lines[14];
            middagNavnText2.Text = lines[15];
            middagDosisText2.Text = lines[16];
            middagFormText2.Text = lines[17];
            middagFarveText2.Text = lines[18];
            middagAlarm2.Text = lines[19];

            aftenNavnText1.Text = lines[20];
            aftenDosisText1.Text = lines[21];
            aftenFormText1.Text = lines[22];
            aftenFarveText1.Text = lines[23];
            aftenAlarm1.Text = lines[24];
            aftenNavnText2.Text = lines[25];
            aftenDosisText2.Text = lines[26];
            aftenFormText2.Text = lines[27];
            aftenFarveText2.Text = lines[28];
            aftenAlarm2.Text = lines[29];
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void morgenTaget1_CheckedChanged(object sender, EventArgs e)
        {
            if (!morgenTaget1.Checked)
            {

                morgenTaget1.Text = "Nej";
                morgenNavnText1.ForeColor = Color.Red;
                morgenDosisText1.ForeColor = Color.Red;
                morgenFormText1.ForeColor = Color.Red;
                morgenFarveText1.ForeColor = Color.Red;
                morgenAlarm1.ForeColor = Color.Red;
                morgenTaget1.ForeColor = Color.Red;
                morgenHvornår1.ForeColor = Color.Red;

                morgenHvornår1.CustomFormat = " ";

                timer1.Start();
            }
            else
            {
                morgenTaget1.Text = "Ja";
                morgenNavnText1.ForeColor = Color.Green;
                morgenDosisText1.ForeColor = Color.Green;
                morgenFormText1.ForeColor = Color.Green;
                morgenFarveText1.ForeColor = Color.Green;
                morgenAlarm1.ForeColor = Color.Green;
                morgenTaget1.ForeColor = Color.Green;
                morgenHvornår1.ForeColor = Color.Green;

                morgenHvornår1.CustomFormat = "HH:mm";
                morgenHvornår1.Text = DateTime.Now.ToString("HH:mm");

                timer1.Stop();
            }
        }

        private void morgenTaget2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!morgenTaget2.Checked)
            {
                morgenTaget2.Text = "Nej";
                morgenNavnText2.ForeColor = Color.Red;
                morgenDosisText2.ForeColor = Color.Red;
                morgenFormText2.ForeColor = Color.Red;
                morgenFarveText2.ForeColor = Color.Red;
                morgenAlarm2.ForeColor = Color.Red;
                morgenTaget2.ForeColor = Color.Red;
                morgenHvornår2.ForeColor = Color.Red;

                morgenHvornår2.CustomFormat = " ";
            }
            else
            {
                morgenTaget2.Text = "Ja";
                morgenNavnText2.ForeColor = Color.Green;
                morgenDosisText2.ForeColor = Color.Green;
                morgenFormText2.ForeColor = Color.Green;
                morgenFarveText2.ForeColor = Color.Green;
                morgenAlarm2.ForeColor = Color.Green;
                morgenTaget2.ForeColor = Color.Green;
                morgenHvornår2.ForeColor = Color.Green;

                morgenHvornår2.CustomFormat = "HH:mm";
                morgenHvornår2.Text = DateTime.Now.ToString("HH:mm");

                

           


            }
        }

        private void middagTaget1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!middagTaget1.Checked)
            {
                middagTaget1.Text = "Nej";
                middagNavnText1.ForeColor = Color.Red;
                middagDosisText1.ForeColor = Color.Red;
                middagFormText1.ForeColor = Color.Red;
                middagFarveText1.ForeColor = Color.Red;
                middagAlarm1.ForeColor = Color.Red;
                middagTaget1.ForeColor = Color.Red;
                middagHvornår1.ForeColor = Color.Red;

                middagHvornår1.CustomFormat = " ";
            }
            else
            {
                middagTaget1.Text = "Ja";
                middagNavnText1.ForeColor = Color.Green;
                middagDosisText1.ForeColor = Color.Green;
                middagFormText1.ForeColor = Color.Green;
                middagFarveText1.ForeColor = Color.Green;
                middagAlarm1.ForeColor = Color.Green;
                middagTaget1.ForeColor = Color.Green;
                middagHvornår1.ForeColor = Color.Green;

                middagHvornår1.CustomFormat = "HH:mm";
                middagHvornår1.Text = DateTime.Now.ToString("HH:mm");

                a = 1;
            }
        }

        private void middagTaget2_CheckedChanged(object sender, EventArgs e)
        {
            if (!middagTaget2.Checked)
            {
                middagTaget2.Text = "Nej";
                middagNavnText2.ForeColor = Color.Red;
                middagDosisText2.ForeColor = Color.Red;
                middagFormText2.ForeColor = Color.Red;
                middagFarveText2.ForeColor = Color.Red;
                middagAlarm2.ForeColor = Color.Red;
                middagTaget2.ForeColor = Color.Red;
                middagHvornår2.ForeColor = Color.Red;

                middagHvornår2.CustomFormat = " ";
            }
            else
            {
                middagTaget2.Text = "Ja";
                middagNavnText2.ForeColor = Color.Green;
                middagDosisText2.ForeColor = Color.Green;
                middagFormText2.ForeColor = Color.Green;
                middagFarveText2.ForeColor = Color.Green;
                middagAlarm2.ForeColor = Color.Green;
                middagTaget2.ForeColor = Color.Green;
                middagHvornår2.ForeColor = Color.Green;

                middagHvornår2.CustomFormat = "HH:mm";
                middagHvornår2.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void aftenTaget1_CheckedChanged(object sender, EventArgs e)
        {
            if (!aftenTaget1.Checked)
            {

                aftenTaget1.Text = "Nej";
                aftenNavnText1.ForeColor = Color.Red;
                aftenDosisText1.ForeColor = Color.Red;
                aftenFormText1.ForeColor = Color.Red;
                aftenFarveText1.ForeColor = Color.Red;
                aftenAlarm1.ForeColor = Color.Red;
                aftenTaget1.ForeColor = Color.Red;
                aftenHvornår1.ForeColor = Color.Red;

                aftenHvornår1.CustomFormat = " ";
            }
            else
            {
                aftenTaget1.Text = "Ja";
                aftenNavnText1.ForeColor = Color.Green;
                aftenDosisText1.ForeColor = Color.Green;
                aftenFormText1.ForeColor = Color.Green;
                aftenFarveText1.ForeColor = Color.Green;
                aftenAlarm1.ForeColor = Color.Green;
                aftenTaget1.ForeColor = Color.Green;
                aftenHvornår1.ForeColor = Color.Green;

                aftenHvornår1.CustomFormat = "HH:mm";
                aftenHvornår1.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void aftenTaget2_CheckedChanged(object sender, EventArgs e)
        {
            if (!aftenTaget2.Checked)
            {
                aftenTaget2.Text = "Nej";
                aftenNavnText2.ForeColor = Color.Red;
                aftenDosisText2.ForeColor = Color.Red;
                aftenFormText2.ForeColor = Color.Red;
                aftenFarveText2.ForeColor = Color.Red;
                aftenAlarm2.ForeColor = Color.Red;
                aftenTaget2.ForeColor = Color.Red;
                aftenHvornår2.ForeColor = Color.Red;

                aftenHvornår2.CustomFormat = " ";
            }
            else
            {
                aftenTaget2.Text = "Ja";
                aftenNavnText2.ForeColor = Color.Green;
                aftenDosisText2.ForeColor = Color.Green;
                aftenFormText2.ForeColor = Color.Green;
                aftenFarveText2.ForeColor = Color.Green;
                aftenAlarm2.ForeColor = Color.Green;
                aftenTaget2.ForeColor = Color.Green;
                aftenHvornår2.ForeColor = Color.Green;

                aftenHvornår2.CustomFormat = "HH:mm";
                aftenHvornår2.Text = DateTime.Now.ToString("HH:mm");
            }
        }

        private void morgenFormText1_TextChanged(object sender, EventArgs e)
        {

        }

        
        int b = 0;
        int c = 0;
        int d = 0;
        int ee = 0; //e is event symbol and cannot be used, so using ee
        int f = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            String testTime = "12:52";

            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == morgenAlarm1.Text)
            {
                System.Media.SystemSounds.Beep.Play();
                if (a == 0)
                {
                    
                    //MessageBox.Show("Tid til at tage " + morgenNavnText1.Text + " " + morgenDosisText1.Text);
                    Blink(morgenNavnText1);
                    Blink(morgenDosisText1);
                }
            }

            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == morgenAlarm2.Text)
            {
                System.Media.SystemSounds.Beep.Play();
                if (b == 0)
                {
                    b = 1;
                    //MessageBox.Show("Tid til at tage " + morgenNavnText2.Text + " " + morgenDosisText2.Text);
                    Blink(morgenNavnText2);
                    Blink(morgenDosisText2);
                }
            }

            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == middagAlarm1.Text)
            {
            System.Media.SystemSounds.Beep.Play();
                if (c == 0)
                {
                    c = 1;
                    //MessageBox.Show("Tid til at tage " + middagNavnText1.Text + " " + middagDosisText1.Text);
                    Blink(middagNavnText1);
                    Blink(middagDosisText1);

                }
            }

            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == middagAlarm2.Text)
            {
                System.Media.SystemSounds.Beep.Play();
                if (d == 0)
                {
                    d = 1;
                    //MessageBox.Show("Tid til at tage " + middagNavnText2.Text + " " + middagDosisText2.Text);
                    Blink(middagNavnText2);
                    Blink(middagDosisText2);

                }
            }

            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == aftenAlarm1.Text)
            {
                System.Media.SystemSounds.Beep.Play();
                if (ee == 0)
                {
                    ee = 1;
                    //MessageBox.Show("Tid til at tage " + aftenNavnText1.Text + " " + aftenDosisText1.Text);
                    Blink(aftenNavnText1);
                    Blink(aftenDosisText1);

                }
            }


            //if (DateTime.Now.ToString("HH:mm") == testTime)
            if (DateTime.Now.ToString("HH:mm") == aftenAlarm2.Text)
            {
                System.Media.SystemSounds.Beep.Play();
                if (f == 0)
                {
                    f = 1;
                    //MessageBox.Show("Tid til at tage " + aftenNavnText2.Text + " " + aftenDosisText2.Text);
                    Blink(aftenNavnText2);
                    Blink(aftenDosisText2);

                }
            }


        }

        private void middagNavnText2_TextChanged(object sender, EventArgs e)
        {

        }

        private void middagFarveText1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
