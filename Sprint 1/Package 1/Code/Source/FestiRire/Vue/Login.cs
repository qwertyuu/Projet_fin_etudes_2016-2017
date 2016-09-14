using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestiRire.Vue
{
    public partial class Login : Form
    {
        Controleur.Login login;
        Controleur.Validation validation;
        public Login()
        {
            InitializeComponent();
            login = new Controleur.Login();
            validation = new Controleur.Validation();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            bool userFound = login.AuthentifierUser(txtIdUser.Text, validation.Hash(txtPassword.Text));
            if (userFound)//Utilisateur trouvé
                frmMenu.ShowDialog();
            else
                MessageBox.Show("Identifiant ou mot de passe incorrect");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
