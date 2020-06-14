using AIForRentersLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIForRentersApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (e.Handled)
                {
                    return;
                }
                HelpForm helpForm = new HelpForm();
                helpForm.ShowDialog();
                e.Handled = true;
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string emailAddress = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            Sender.Email = emailAddress;
            Sender.Password = password;

            DialogResult result = 0;

            try
            {
                Login.Authentication(emailAddress, password);
            }
            catch (LoginException ex)
            {
                result = MessageBox.Show(ex.Poruka);
            }

            if (result != DialogResult.OK)
            {
                this.Hide();
                FormRequests formRequests = new FormRequests();
                formRequests.ShowDialog();
                this.Close();
            }
            else
            {
                textBoxPassword.ResetText();
            }
        }

        public override string ToString()
        {
            return "LoginForm";
        }
    }
}
