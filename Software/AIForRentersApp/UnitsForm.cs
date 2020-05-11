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
        private UnitRepository unitRepository = new UnitRepository();
        public UnitsForm()
        {
            InitializeComponent();
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UnitsForm_KeyDown);

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequests formRequests = new FormRequests();
            formRequests.ShowDialog();
            this.Close();

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropertiesForm formProperties = new PropertiesForm();
            formProperties.ShowDialog();
            this.Close();

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonEmailTemplates_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailTemplatesForm emailTemplatesForm = new EmailTemplatesForm();
            emailTemplatesForm.ShowDialog();
            this.Close();

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            Unit newUnit = new Unit
            {
                Name = textBoxUnitName.Text,
                Capacity = int.Parse(textBoxUnitCapacity.Text),
                Price = double.Parse(textBoxUnitPrice.Text)
            };

            unitRepository.Insert(newUnit);

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Unit selectedUnit =  GetSelectedUnit();
            selectedUnit.Name = textBoxUnitName.Text;
            selectedUnit.Capacity = int.Parse(textBoxUnitCapacity.Text);
            selectedUnit.Price = double.Parse(textBoxUnitPrice.Text);
            unitRepository.Update(selectedUnit);

            DisplayUnits(unitRepository.GetUnits());
        }

        private void buttonEditUnit_Click(object sender, EventArgs e)
        {
            Unit selectedUnit = GetSelectedUnit();
            textBoxUnitName.Text = selectedUnit.Name;
            textBoxUnitCapacity.Text = selectedUnit.Capacity.ToString();
            textBoxUnitPrice.Text = selectedUnit.Price.ToString();
        }

        private void buttonDeleteUnit_Click(object sender, EventArgs e)
        {
            Unit selectedUnit = GetSelectedUnit();
            unitRepository.Delete(selectedUnit);

            DisplayUnits(unitRepository.GetUnits());
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

        private void DisplayUnits(List<Unit> units)
        {
            dataGridViewUnits.DataSource = units.ToList();
        }

        private Unit GetSelectedUnit()
        {
            if (dataGridViewUnits.CurrentRow != null)
            {
                return dataGridViewUnits.CurrentRow.DataBoundItem as Unit;
            }
            return null;
        }

        public override string ToString()
        {
            return "UnitsForm";
        }
    }
}
