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
    public partial class UnitsForm : Form
    {
        private Property chosenProperty;
        public UnitsForm(Property property)
        {
            InitializeComponent();
            chosenProperty = property;
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UnitsForm_KeyDown);

            DisplayUnits();
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
            this.Close();
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

        private void UnitsForm_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            
            Unit unit = new Unit();

            string unitName = textBoxUnitName.Text;
            int unitCapacity = int.Parse(textBoxUnitCapacity.Text);
            double unitPrice = double.Parse(textBoxUnitPrice.Text);

            unit.AddUnit(chosenProperty, unitName, unitCapacity, unitPrice);

            DisplayUnits();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Unit chosenUnit = GetSelectedUnit();

            string unitName = textBoxUnitName.Text;
            int unitCapacity = int.Parse(textBoxUnitCapacity.Text);
            double unitPrice = double.Parse(textBoxUnitPrice.Text);

            chosenUnit.EditUnit(chosenUnit, unitName, unitCapacity, unitPrice);

            DisplayUnits();
        }

        private void buttonEditUnit_Click(object sender, EventArgs e)
        {
            Unit chosenUnit = GetSelectedUnit();

            textBoxUnitName.Text = chosenUnit.Name;
            textBoxUnitCapacity.Text = chosenUnit.Capacity.ToString();
            textBoxUnitPrice.Text = chosenUnit.Price.ToString();
        }

        private void buttonDeleteUnit_Click(object sender, EventArgs e)
        {
            Unit chosenUnit = GetSelectedUnit();

            chosenUnit.DeleteUnit(chosenUnit);

            DisplayUnits();
        }

        private void DisplayUnits()
        {
            Unit unit = new Unit();

            dataGridViewUnits.DataSource = unit.DisplayUnits();
            dataGridViewUnits.Columns["UnitID"].Visible = false;
            dataGridViewUnits.Columns["PropertyID"].Visible = false;
            dataGridViewUnits.Columns["Availabilities"].Visible = false;
            dataGridViewUnits.Columns["Property"].Visible = false;
            dataGridViewUnits.Columns["Requests"].Visible = false;
        }

        private Unit GetSelectedUnit()
        {
            if (dataGridViewUnits.CurrentRow != null)
            {
                Unit chosenUnit = dataGridViewUnits.CurrentRow.DataBoundItem as Unit;
                return chosenUnit;
            }
            return null;
        }

        public override string ToString()
        {
            return "UnitsForm";
        }
    }
}
