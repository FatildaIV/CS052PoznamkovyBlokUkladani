using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CS050PoznamkovyBlok
{
    public partial class PoznamkovyBlokForm : Form
    {
        public PoznamkovyBlokForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nacistButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"\.",                                   // výchozí adresář jako spuštěný program
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",     // pouze textové soubory
                FilterIndex = 2,                                            // výchozí hodnota filtru
                RestoreDirectory = true                                     // po zavření dialogu se nastaví původní adresář
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader sr = new StreamReader(openFileDialog.OpenFile()))
                {
                    poznTextBox.Text = sr.ReadToEnd();
                }
            }
        }

        private void velikostScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            velikostScrollBar_ValueChanged(sender, null);
            velikostTextBox.Text = velikostScrollBar.Value.ToString();
        }

        private void velikostTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void velikostScrollBar_ValueChanged(object sender, EventArgs e)
        {
            poznTextBox.Font = new Font(poznTextBox.Font.FontFamily, velikostScrollBar.Value);
        }

        private void velikostTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                velikostScrollBar.Value = int.Parse(velikostTextBox.Text);
            }
            catch
            {
                velikostTextBox.Text = 12.ToString();
                velikostTextBox_Validated(sender, e);
            }
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile());               
                sw.Write(poznTextBox.Text);
                sw.Close();                
            }
        }
    }
}