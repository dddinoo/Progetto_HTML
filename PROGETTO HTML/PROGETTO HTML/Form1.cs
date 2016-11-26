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

        /// <summary>
        /// I dati scritti sulla text box dell'html e css vengono riportati sul web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text + richTextBox2.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        /// <summary>
        /// Salva in un file .html il testo scritto riga per riga nella textbox. L'utente sceglie in tempo reale dove salvare il file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string[] textlines = richTextBox1.Lines;
            try
            {
                SaveFileDialog SalvataggioHtml = new SaveFileDialog();
                SalvataggioHtml.Filter = "html files (*.html)|*.html|All files (*.*)|*.*"; //Filtra le estensioni dei file
                SalvataggioHtml.ShowDialog();

                using (StreamWriter sw = new StreamWriter(SalvataggioHtml.FileName))
                {
                    for(int i=0; i< textlines.GetUpperBound(0)+1;i++)
                    {
                        sw.WriteLine(textlines[i]);
                    }
                }
            }
            catch { MessageBox.Show("Errore nel Salvataggio"); }
        }

        /// <summary>
        /// Legge il file di estensione .html e lo inserisce nella textbox. L'utente sceglie in tempo reale il file da leggere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog LeggiHtml = new OpenFileDialog();
            LeggiHtml.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            LeggiHtml.ShowDialog();
                StreamReader sr = new StreamReader(LeggiHtml.FileName);
                string riga;
                while ((riga = sr.ReadLine()) != null) 
                {
                    richTextBox1.Text = richTextBox1.Text + riga;
                }         
        }

        //I seguenti bottoni stampano i diversi tag più importanti nelle caselle di testo HTML o CSS.
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
            richTextBox2.Text = richTextBox2.Text + "<style>\n";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox2.Text + "</style>\n";
        }

        /// <summary>
        /// Salva in un file .css il testo scritto riga per riga nella textbox. L'utente sceglie in tempo reale dove salvare il file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            string[] textlines = richTextBox2.Lines;
            try
            {
                SaveFileDialog SalvataggioCss = new SaveFileDialog();
                SalvataggioCss.Filter = "css files (*.css)|*.css|All files (*.*)|*.*";
                SalvataggioCss.ShowDialog();

                using (StreamWriter sw = new StreamWriter(SalvataggioCss.FileName))
                {
                    for (int i = 0; i < textlines.GetUpperBound(0) + 1; i++)
                    {
                        sw.WriteLine(textlines[i]);
                    }
                }
            }
            catch { MessageBox.Show("Errore nel Salvataggio"); }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text + richTextBox2.Text;
        }

        /// <summary>
        /// Legge il file di estensione .css e lo inserisce nella textbox. L'utente sceglie in tempo reale il file da leggere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog LeggiCss = new OpenFileDialog();
            LeggiCss.Filter = "css files (*.css)|*.css|All files (*.*)|*.*";
            LeggiCss.ShowDialog();
            StreamReader sr = new StreamReader(LeggiCss.FileName);
            string riga1;
            while ((riga1 = sr.ReadLine()) != null)
            {
                richTextBox2.Text = richTextBox2.Text + riga1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
