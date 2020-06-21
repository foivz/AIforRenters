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

            LegendColoring();

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

        /// <summary>
        /// This method is triggered by a click event on the
        /// Edit response button in FormRequests.
        /// It enables rich text box so the user can edit the response.
        /// It also disables Send response button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditResponse_Click(object sender, EventArgs e)
        {
            richTextBoxResponse.Enabled = true;
            richTextBoxResponse.Focus();

            buttonSend.Enabled = false;
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Send response button in FormRequests.
        /// It calls a method for sending response to the client
        /// and marks request as sent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            selectedRequest.MarkAsSent(selectedRequest);

            DisplayRequests();
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Refresh requests button in FormRequests.
        /// It refreshes the request in order to see are there any new ones
        /// and displays requests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefreshRequests_Click(object sender, EventArgs e)
        {
            RefreshRequests();

            DisplayRequests();
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Save changes button in FormRequests.
        /// It saves changes that user made on the response
        /// and enables Send response button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method enables certain buttons when the datagridview cell is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewIncomingRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewIncomingRequests.CurrentRow != null)
            {
                Request selectedRequest = GetSelectedRequest();

                buttonEditResponse.Enabled = true;
                buttonSend.Enabled = true;
                buttonSaveChanges.Enabled = true;

                if (selectedRequest.Sent == true)
                {
                    buttonSend.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Method that triggers on keyDown event and checks if the pressed key
        /// is F1. If it is it opens HelpForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method triggers on selection changed event in dataGridViewIncomingRequests
        /// and fills the rich text box with response body from a selected request.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewIncomingRequests_SelectionChanged(object sender, EventArgs e)
        {
            Request selectedRequest = GetSelectedRequest();
            richTextBoxResponse.Text = selectedRequest.ResponseBody;
            richTextBoxResponse.Enabled = false;

            if (selectedRequest.Sent == true)
            {
                buttonSend.Enabled = false;
            }
        }

        /// <summary>
        /// This method calls a method to process incoming requests and create new request objects.
        /// </summary>
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

        /// <summary>
        /// This method displays requests from database.
        /// </summary>
        private void DisplayRequests()
        {
            Request request = new Request();
            AvailabilityValidator.CheckForAvailability(request.DisplayRequests());

            dataGridViewIncomingRequests.DataSource = request.DisplayRequests();
            dataGridViewIncomingRequests.Columns["RequestID"].Visible = false;
            dataGridViewIncomingRequests.Columns["ClientID"].Visible = false;
            dataGridViewIncomingRequests.Columns["ResponseBody"].Visible = false;
            dataGridViewIncomingRequests.Columns["Confirmed"].Visible = false;
            dataGridViewIncomingRequests.Columns["Sent"].Visible = false;
            dataGridViewIncomingRequests.Columns["Processed"].Visible = false;

            RowsColoring();
        }

        /// <summary>
        /// This method colors rows of dataGridViewIncomingRequests depending which request is in which state.
        /// </summary>
        private void RowsColoring()
        {
            foreach (DataGridViewRow row in dataGridViewIncomingRequests.Rows)
            {
                Request request = row.DataBoundItem as Request;
                if (!request.Sent)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 208, 53, 104);
                }
                else if (request.Sent && !request.Confirmed)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 218, 135, 135);
                }
                else if (request.Confirmed)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 101, 221, 101);
                }
            } 
        }

        /// <summary>
        /// This method colors the text boxes that inform the user about the meaning of the colors of requests.
        /// </summary>
        private void LegendColoring()
        {
            responseSentColor.BackColor = Color.FromArgb(255, 218, 135, 135);
            responseNotSentColor.BackColor = Color.FromArgb(255, 208, 53, 104);
            confirmedReservationColor.BackColor = Color.FromArgb(255, 101, 221, 101);
        }

        public override string ToString()
        {
            return "RequestsForm";
        }

        /// <summary>
        /// This method returns selected request in the dataGridViewIncomingRequests.
        /// </summary>
        /// <returns>Selected Request object</returns>
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
