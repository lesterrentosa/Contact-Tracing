using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lastNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContactTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrgyTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("Output.txt");
            outputFile.Write("Last Name: ");
            outputFile.WriteLine(lastNameTxtBox.Text);
            outputFile.Write("First Name: ");
            outputFile.WriteLine(firstNameTxtBox.Text);
            outputFile.Write("Middle Name: ");
            outputFile.WriteLine(MiddleNameTxtBox.Text);
            outputFile.Write("Age: ");
            outputFile.WriteLine(AgeTxtBox.Text);
            outputFile.Write("Gender: ");
            outputFile.WriteLine(comboBox1.Text);
            outputFile.Write("Contact Number: ");
            outputFile.WriteLine(ContactTxtBox.Text);
            outputFile.Write("Email: ");
            outputFile.WriteLine(EmailTxtBox.Text);
            outputFile.Write("Address: ");
            outputFile.WriteLine(AddressTxtBox.Text);
            outputFile.Write("Barangay: ");
            outputFile.WriteLine(BrgyTxtBox.Text);
            outputFile.Write("City: ");
            outputFile.WriteLine(CityTxtBox.Text);
            outputFile.Close();
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void middleNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}