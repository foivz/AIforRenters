using AIForRentersLib;
using AIForRentersLib.Exceptions;
using OpenPop.Pop3.Exceptions;
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
    public partial class FormRequests : Form
    {
        
        public FormRequests()
        {
            InitializeComponent();
        }
        
        private void FormRequests_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormRequests_KeyDown);

            buttonEditResponse.Enabled = false;
            buttonSend.Enabled = false;
            buttonSaveChanges.Enabled = false;

            RefreshRequests();

            DisplayRequests();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm formProperties = new PropertiesForm();
            formProperties.ShowDialog();
            this.Close();
        }

        private void buttonEmailTemplates_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailTemplatesForm emailTemplatesForm = new EmailTemplatesForm();
            emailTemplatesForm.ShowDialog();
            this.Close();
        }

        private void buttonEditResponse_Click(object sender, EventArgs e)
        {
            richTextBoxResponse.Enabled = true;
            richTextBoxResponse.Focus();

            buttonSend.Enabled = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Request selectedRequest = GetSelectedRequest();

            try
            {
                EmailSender.SendEmail(selectedRequest);
            }
            catch (Exception ex)
            {
                if (ex is SocketException)
                {
                    MessageBox.Show("Can't connect to the server. \nPlease check your internet connection!");
                }
                return;
            }
            
        }

        private void buttonRefreshRequests_Click(object sender, EventArgs e)
        {
            RefreshRequests();

            DisplayRequests();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Request chosenRequest = GetSelectedRequest();

            string responseBody = richTextBoxResponse.Text;

            try
            {
                chosenRequest.EditRequest(chosenRequest, responseBody);
            }
            catch (RequestException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            buttonSend.Enabled = true;

            DisplayRequests();
        }

        private void dataGridViewIncomingRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewIncomingRequests.CurrentRow != null)
            {
                buttonEditResponse.Enabled = true;
                buttonSend.Enabled = true;
                buttonSaveChanges.Enabled = true;
            }
        }

        private void FormRequests_KeyDown(object sender, KeyEventArgs e)
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

        private void dataGridViewIncomingRequests_SelectionChanged(object sender, EventArgs e)
        {
            Request selectedRequest = GetSelectedRequest();
            richTextBoxResponse.Text = selectedRequest.ResponseBody;
            richTextBoxResponse.Enabled = false;
        }

        private void RefreshRequests()
        {
            try
            {
                ResponseProcessor.ProcessData(EmailFetcher.ShapeReceivedData());
            }
            catch (Exception ex)
            {
                if (ex is PopServerNotFoundException || ex is SocketException)
                {
                    MessageBox.Show("Can't connect to the server. \nPlease check your internet connection!");
                }
                return;
            }
        }

        private void DisplayRequests()
        {
            Request request = new Request();

            dataGridViewIncomingRequests.DataSource = request.DisplayRequests();
            dataGridViewIncomingRequests.Columns["RequestID"].Visible = false;
            dataGridViewIncomingRequests.Columns["ClientID"].Visible = false;
            dataGridViewIncomingRequests.Columns["ResponseBody"].Visible = false;
        }

        public override string ToString()
        {
            return "RequestsForm";
        }

        private Request GetSelectedRequest()
        {
            if (dataGridViewIncomingRequests.CurrentRow != null)
            {
                return dataGridViewIncomingRequests.CurrentRow.DataBoundItem as Request;
            }
            return null;
        }
    }
}
