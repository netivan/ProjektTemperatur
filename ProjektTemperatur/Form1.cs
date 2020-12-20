using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ProjektTemperatur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Beep();
            Console.Beep();



           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string FilNamn = @"C:\Prova\TemperaturData.csv";

       //     string FilNamn = textBox1.Text;

            foreach (string rad in File.ReadLines(FilNamn))
            {     
                listBox1.Items.Add(rad);


                var tmpx = Metoder.ConvertData(rad);   // skapar objekt temperatur i vilken rad konverteras (rad viene convertito nell´oggetto tmpx)
                if (tmpx == null) MessageBox.Show("error" + rad);
                else Metoder.InsertData(tmpx);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            textBox1.Text = s;
            if (!File.Exists(s))
            {
                MessageBox.Show("file does not exist!");
                btnLoad.Enabled = false;

            }
            else
                btnLoad.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Temperaturer t = new Temperaturer();
            Metoder.InsertData(t);


        }
    }
}
