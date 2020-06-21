using AIForRentersLib;
using AIForRentersLib.Exceptions;
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
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(PropertiesForm_KeyDown);

            buttonSaveChanges.Enabled = false;
            buttonDeleteProperty.Enabled = false;
            buttonEditProperty.Enabled = false;
            buttonShowListOfUnits.Enabled = false;

            DisplayProperties();
        }

        private void buttonShowListOfUnits_Click(object sender, EventArgs e)
        {
            Property chosenProperty = GetSelectedProperty();

            this.Hide();
            UnitsForm unitsForm = new UnitsForm(chosenProperty);
            unitsForm.ShowDialog();
            this.Close();
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
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
        /// Method that triggers on keyDown event and checks if the pressed key
        /// is F1. If it is it opens HelpForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropertiesForm_KeyDown(object sender, KeyEventArgs e)
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
        /// Delete property button in PropertiesForm.
        /// It deletes selected property from database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteProperty_Click(object sender, EventArgs e)
        {
            Property chosenProperty = GetSelectedProperty();

            try
            {
                chosenProperty.DeleteProperty(chosenProperty);
            }
            catch (PropertyException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayProperties();
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Edit property button in PropertiesForm.
        /// It collects all necessary data from the selected property and fills
        /// textboxes on the PropertiesForm with that data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditProperty_Click(object sender, EventArgs e)
        {
            try
            {
                Property chosenProperty = GetSelectedProperty();

                textBoxPropertyName.Text = chosenProperty.Name;
                textBoxPropertyLocation.Text = chosenProperty.Location;
            }
            catch (PropertyException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            buttonAddProperty.Enabled = false;
            buttonDeleteProperty.Enabled = false;
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Save changes button in PropertiesForm.
        /// It collects all necessary data from the PropertiesForm to update
        /// selected property object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Property chosenProperty = GetSelectedProperty();

            string propertyName = textBoxPropertyName.Text;
            string propertyLocation = textBoxPropertyLocation.Text;

            try
            {
                chosenProperty.EditProperty(chosenProperty, propertyName, propertyLocation);
            }
            catch (PropertyException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            buttonAddProperty.Enabled = true;
            buttonDeleteProperty.Enabled = true;

            DisplayProperties();
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Add property button in PropertiesForm.
        /// It collects all necessary data from the PropertiesForm to create
        /// new property object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            Property property = new Property();

            string propertyName = textBoxPropertyName.Text;
            string propertyLocation = textBoxPropertyLocation.Text;

            try
            {
                property.AddProperty(propertyName, propertyLocation);
            }
            catch (PropertyException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayProperties();
        }

        /// <summary>
        /// This method enables certain buttons when the datagridview cell is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProperties.CurrentRow != null)
            {
                buttonSaveChanges.Enabled = true;
                buttonDeleteProperty.Enabled = true;
                buttonEditProperty.Enabled = true;
                buttonShowListOfUnits.Enabled = true;
            }
        }

        /// <summary>
        /// This method displays properties from database.
        /// </summary>
        private void DisplayProperties()
        {
            Property property = new Property();

            dataGridViewProperties.DataSource = property.DisplayProperties();
            dataGridViewProperties.Columns["PropertyID"].Visible = false;
            dataGridViewProperties.Columns["Units"].Visible = false;
        }

        /// <summary>
        /// This method returns selected property in the datagridviewProperties.
        /// </summary>
        /// <returns>Selected Property object</returns>
        private Property GetSelectedProperty()
        {
            if (dataGridViewProperties.CurrentRow != null)
            {
                Property chosenProperty = dataGridViewProperties.CurrentRow.DataBoundItem as Property;
                return chosenProperty;
            }
            else
            {
                throw new PropertyException("You have to select a property!");
            }
        }

        public override string ToString()
        {
            return "PropertiesForm";
        }
    }
}
