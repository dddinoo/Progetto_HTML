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

namespace PROGETTO_HTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] textlines = richTextBox1.Lines;
            try
            {
                SaveFileDialog Salvataggio = new SaveFileDialog();
                Salvataggio.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
                Salvataggio.ShowDialog();

                using (StreamWriter sw = new StreamWriter(Salvataggio.FileName))
                {
                    for(int i=0; i< textlines.GetUpperBound(0)+1;i++)
                    {
                        sw.WriteLine(textlines[i]);
                    }
                }
            }
            catch { MessageBox.Show("Errore nel Salvataggio"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog Leggi = new OpenFileDialog();
            Leggi.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            Leggi.ShowDialog();
                StreamReader sr = new StreamReader(Leggi.FileName);
                string riga;
                while ((riga = sr.ReadLine()) != null) 
                {
                    richTextBox1.Text = richTextBox1.Text + riga;
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<html>\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<head>\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<body>\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<h3>\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<p>\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = richTextBox1.Text + "<button>\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</html>\n";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</head>\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</body>\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</h3>\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</p>\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</button>\n";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<style>\n";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "</style>\n";
        }
    }
}
