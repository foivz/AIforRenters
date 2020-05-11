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
    public partial class PropertiesForm : Form
    {
        private PropertyRepository propertyRepository = new PropertyRepository();
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(PropertiesForm_KeyDown);

            DisplayProperties(propertyRepository.GetProperties());
        }

        private void buttonShowListOfUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnitsForm unitsForm = new UnitsForm();
            unitsForm.ShowDialog();
            this.Close();

            DisplayProperties(propertyRepository.GetProperties());
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
            this.Close();

            DisplayProperties(propertyRepository.GetProperties());
        }

        private void buttonEmailTemplates_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailTemplatesForm emailTemplatesForm = new EmailTemplatesForm();
            emailTemplatesForm.ShowDialog();
            this.Close();

            DisplayProperties(propertyRepository.GetProperties());
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

        private void DisplayProperties(List<Property> properties)
        {
            dataGridViewProperties.DataSource = properties.ToList();
        }

        private Property GetSelectedProperty()
        {
            if (dataGridViewProperties.CurrentRow != null)
            {
                return dataGridViewProperties.CurrentRow.DataBoundItem as Property;
            }
            return null;
        }

        public override string ToString()
        {
            return "PropertiesForm";
        }

        private void buttonDeleteProperty_Click(object sender, EventArgs e)
        {
            Property selectedProperty = GetSelectedProperty();
            propertyRepository.Delete(selectedProperty);

            DisplayProperties(propertyRepository.GetProperties());
        }

        private void buttonEditProperty_Click(object sender, EventArgs e)
        {
            Property selectedProperty = GetSelectedProperty();

            textBoxPropertyName.Text = selectedProperty.Name;
            textBoxPropertyLocation.Text = selectedProperty.Location;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Property selectedProperty = GetSelectedProperty();
            selectedProperty.Name = textBoxPropertyName.Text;
            selectedProperty.Location = textBoxPropertyLocation.Text;
            propertyRepository.Update(selectedProperty);

            DisplayProperties(propertyRepository.GetProperties());
        }

        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            Property newProperty = new Property
            {
                Name = textBoxPropertyName.Text,
                Location = textBoxPropertyLocation.Text
            };
            propertyRepository.Insert(newProperty);

            DisplayProperties(propertyRepository.GetProperties());
        }
    }
}
