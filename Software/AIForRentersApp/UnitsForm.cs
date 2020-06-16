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

            buttonDeleteUnit.Enabled = false;
            buttonEditUnit.Enabled = false;
            buttonSaveChanges.Enabled = false;
            textBoxPropertyName.Text = chosenProperty.Name;

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

            try
            {
                unit.AddUnit(chosenProperty, unitName, unitCapacity, unitPrice);
            }
            catch (UnitException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
            
            DisplayUnits();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Unit chosenUnit = GetSelectedUnit();

            string unitName = textBoxUnitName.Text;
            int unitCapacity = int.Parse(textBoxUnitCapacity.Text);
            double unitPrice = double.Parse(textBoxUnitPrice.Text);

            try
            {
                chosenUnit.EditUnit(chosenUnit, unitName, unitCapacity, unitPrice);
            }
            catch (UnitException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayUnits();
        }

        private void buttonEditUnit_Click(object sender, EventArgs e)
        {
            try
            {
                Unit chosenUnit = GetSelectedUnit();

                textBoxUnitName.Text = chosenUnit.Name;
                textBoxUnitCapacity.Text = chosenUnit.Capacity.ToString();
                textBoxUnitPrice.Text = chosenUnit.Price.ToString();
            }
            catch (UnitException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
        }

        private void buttonDeleteUnit_Click(object sender, EventArgs e)
        {
            Unit chosenUnit = GetSelectedUnit();

            try
            {
                chosenUnit.DeleteUnit(chosenUnit);
            }
            catch (UnitException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }

            DisplayUnits();
        }

        private void DisplayUnits()
        {
            Unit unit = new Unit();

            dataGridViewUnits.DataSource = unit.DisplayUnits(chosenProperty);
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
            else
            {
                throw new UnitException("You have to select a unit!");
            }
        }

        public override string ToString()
        {
            return "UnitsForm";
        }

        private void dataGridViewUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUnits.CurrentRow != null)
            {
                buttonDeleteUnit.Enabled = true;
                buttonEditUnit.Enabled = true;
                buttonSaveChanges.Enabled = true;
            }
        }
    }
}
