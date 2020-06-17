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

        private void DisplayProperties()
        {
            Property property = new Property();

            dataGridViewProperties.DataSource = property.DisplayProperties();
            dataGridViewProperties.Columns["PropertyID"].Visible = false;
            dataGridViewProperties.Columns["Units"].Visible = false;
        }

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
