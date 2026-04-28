using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalIdentityProcessor_SectionB_Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;

            if (inputID.Length == 13)
            {
                CitizenProfile myProfile = new CitizenProfile(inputID);

                // 1. Get the data from the class
                string birthday = myProfile.GetDOB();
                string gender = myProfile.GetGender();
                string citizenStatus = cmbCitizenship.Text;

                // 2. This filling the labels in the Identity Details box
                lblBirth.Text = "Date of Birth: " + birthday;
                lblSex.Text = "Gender: " + gender;
                lblHome.Text = "Citizenship: " + citizenStatus;

                // 3. Popup as a backup
                MessageBox.Show("ID Processed Successfully", "Done");
            }
            else
            {
                MessageBox.Show("Error: ID must be 13 digits long.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Call the validation logic
            btnValidate_Click(sender, e);

            // Adding the Processed message 
            lblHome.Text += "\nProcessed.";
        }
    }
}