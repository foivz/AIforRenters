using AIForRentersLib;
using AIForRentersLib.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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

        /// <summary>
        /// Method that triggers on keyDown event and checks if the pressed key
        /// is F1. If it is it opens HelpForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is triggered by a click event on the
        /// Log in button in LoginForm.
        /// It collects the user input from text boxes and forward it to the
        /// Authentication method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //collecting user input
            string emailAddress = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            //assigning emailAddress and password to Sender class for later reuse
            Sender.Email = emailAddress;
            Sender.Password = password;

            DialogResult result = 0;

            //Authentication of user
            try
            {
                Login.Authentication(emailAddress, password);
            }
            catch (Exception ex)
            {
                if (ex is LoginException exception)
                {
                    result = MessageBox.Show(exception.ExceptionMessage);
                }
                else if (ex is ArgumentNullException)
                {
                    result = MessageBox.Show("Login unsuccessful!");
                }
                else if (ex is SocketException)
                {
                    result = MessageBox.Show("Can't connect to the server. \nPlease check your internet connection!");
                }
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
