using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string namePattern = @"^([A-Za-z]*\s*)*$";
            string phonePattern = @"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{4}$";
            string emailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(txtName.Text, namePattern))
            {
                Debug.WriteLine("Name is valid");
            }
            else
            {
                Debug.WriteLine("Name is NOT valid");
                MessageBox.Show("Not a valid name, use only alphabetical characters.");
            }

            if (Regex.IsMatch(txtPhone.Text, phonePattern))
            {
                Debug.WriteLine("Phone is valid");
            }
            else
            {
                Debug.WriteLine("Phone is NOT valid");
                MessageBox.Show("Phone number is not a valid US phone number");
            }

            if (Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                Debug.WriteLine("Email is valid");
            }
            else
            {
                Debug.WriteLine("Email is NOT valid");
                MessageBox.Show("This is not a valid email address.");
            }


        }
    }
}
