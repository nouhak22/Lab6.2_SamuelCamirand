using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6._2_SamuelCamirand
{
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //enter text to validate input
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            //username input
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            //address input
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            //city input
        }

        private void txtProv_TextChanged(object sender, EventArgs e)
        {
            //province input
        }

        private void txtPC_TextChanged(object sender, EventArgs e)
        {
            //postal code input
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            //telephone input
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtUser.Text, @"^.{2,20}$"))
            {
                MessageBox.Show("Invalid User Name!");
                return;
            }

            if (!Regex.IsMatch(txtAddress.Text, @"^\d{1,4} [A-Za-z ]{1,20}$"))
            {
                MessageBox.Show("Invalid Address!");
                return;
            }

            if (!Regex.IsMatch(txtCity.Text, @"^([Mm]ontreal)$"))
            {
                MessageBox.Show("Invalid City!");
                return;
            }

            if (!Regex.IsMatch(txtProv.Text, @"^[Qq][Cc]$"))
            {
                MessageBox.Show("Invalid Province!");
                return;
            }

            if (!Regex.IsMatch(txtPC.Text, @"^([A-Z][0-9][A-Z])([0-9][A-Z][0-9])$|^([A-Z][\d][A-Z])([\s\-])?([\d][A-Z][\d])$"))
            {
                MessageBox.Show("Invalid Postal Code!");
                return;
            }

            if (!Regex.IsMatch(txtTel.Text, @"^\d{3}[\s\-]\d{3}[\s\-]\d{4}$"))
            {
                MessageBox.Show("Invalid Phone Number!");
                return;
            }

            MessageBox.Show("All fields are valid!");
        }

        private void btnChkEmail_Click(object sender, EventArgs e)
        {
            //check email button
        }

        private void btnDelExSpaces_Click(object sender, EventArgs e)
        {
            //delete extra spaces button
        }

        private void btnValPostalCode_Click(object sender, EventArgs e)
        {
            //validate postal code button
        }

        private void btnDelLetters_Click(object sender, EventArgs e)
        {
            // delete letters a,b,c,d button
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            //create array of words button
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
