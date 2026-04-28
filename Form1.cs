using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Languages_Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adding functionalities to the add and remove buttons
            string language = txtInput.Text.Trim();

            // 1. Prevent empty input
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a language.");
                return;
            }

            // 2. Preventing duplicates
            if (listBoxLanguages.Items.Contains(language))
            {
                MessageBox.Show("This language is already in your favorites!");
            }
            else
            {
                listBoxLanguages.Items.Add(language);
                txtInput.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxLanguages.SelectedItem != null)
            {
                string removedLang = listBoxLanguages.SelectedItem.ToString();
                listBoxLanguages.Items.Remove(removedLang);

                // 3. Display the date and time of removal
                lblStatus.Text = $"Removed {removedLang} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            }
            else
            {
                MessageBox.Show("Please select a language to remove.");
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
