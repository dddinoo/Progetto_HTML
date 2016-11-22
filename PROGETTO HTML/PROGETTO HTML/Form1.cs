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
    }
}
