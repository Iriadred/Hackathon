using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AP3_GestionHackathon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtmdp.PasswordChar = '*';
        }

        private void txtmdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconn_Click_1(object sender, EventArgs e)
        {
            bool result = Modele.connexionadmin(txtlog.Text, txtmdp.Text);
            if (result == true)
            {
                FormMenu Gestion = new FormMenu();
                Gestion.Show();
                this.Hide();
            }
        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckPass.Checked == true)
            {
                txtmdp.PasswordChar = (char)0;
            }
            else
            {
                txtmdp.PasswordChar = '*';
            }
        }

        private void txtmdp_TextChanged_1(object sender, EventArgs e)
        {

        }
        /*private static string GetRandomSalt()
{
//return BCrypt.GenerateSalt(12);
}

public static string HashPassword(string password)
{
return BCrypt.HashPassword(password, GetRandomSalt());
}

public static bool ValidatePassword(string password, string correctHash)
{
return BCrypt.Verify(password, correctHash);
}*/


    }
}
