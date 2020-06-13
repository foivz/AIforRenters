using AIForRentersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AIForRentersWebForm
{
    public partial class RequestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPropertiesDropDown<Property>();
            FillUnitsDropDown<AIForRentersLib.Unit>();
        }

        protected void sendRequestButton_Click(object sender, EventArgs e)
        {

            int propertyID = int.Parse(propertiesDropDown.SelectedValue);
            int unitID = int.Parse(unitsDropDown.SelectedValue);
            Property selectedProperty;
            AIForRentersLib.Unit selectedUnit;

            using (var context = new SE20E01_DBEntities())
            {
                var queryUnit = from unit in context.Units
                                where unit.UnitID == unitID
                                select unit;

                var queryProperty = from property in context.Properties
                                    where property.PropertyID == propertyID
                                    select property;

                selectedProperty = queryProperty.Single();
                selectedUnit = queryUnit.Single();
            }
            
            Client newClient = new Client();
            newClient.Name = nameTextBox.Text;
            newClient.Surname = surnameTextBox.Text;
            newClient.Email = emailTextBox.Text;

            Request newRequest = new Request();
            newRequest.Client = newClient;
            newRequest.Property = selectedProperty;
            newRequest.Unit = selectedUnit;
            newRequest.NumberOfPeople = int.Parse(numberOfPeopleDropDownList.SelectedItem.Text);
            newRequest.FromDate = dateFromCalendar.SelectedDate;
            newRequest.ToDate = dateToCalendar.SelectedDate;
            newRequest.Confirmed = false;

            using (var context = new SE20E01_DBEntities())
            {
                context.Clients.Attach(newClient);
                context.Clients.Add(newClient);

                context.Requests.Attach(newRequest);
                context.Requests.Add(newRequest);

                context.SaveChanges();
            }
        }

        protected void propertiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUnitsDropDown<AIForRentersLib.Unit>();
        }

        protected void unitsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumberOfPeopleDropDown<int>();
        }

        private void FillUnitsDropDown<T>()
        {
            int propertyID = int.Parse(GetSelectedProperty());

            List<AIForRentersLib.Unit> units = new List<AIForRentersLib.Unit>();

            using (var context = new SE20E01_DBEntities())
            {
                var query = from unit in context.Units
                            where unit.Property.PropertyID == propertyID
                            select unit;

                units = query.ToList();
            }

            unitsDropDown.DataTextField = "Name";
            unitsDropDown.DataValueField = "UnitID";
            unitsDropDown.DataSource = units;
            unitsDropDown.DataBind();
            unitsDropDown.Items.Insert(0, new ListItem("[Select]", "-1"));
            unitsDropDown.SelectedIndex = 0;
        }

        private void FillPropertiesDropDown<T>()
        {
            List<Property> properties = new List<Property>();

            using (var context = new SE20E01_DBEntities())
            {
                var query = from property in context.Properties
                            select property;

                properties = query.ToList();
            }

            propertiesDropDown.DataTextField = "Name";
            propertiesDropDown.DataValueField = "PropertyID";
            propertiesDropDown.DataSource = properties;
            propertiesDropDown.DataBind();
            propertiesDropDown.Items.Insert(0, new ListItem("[Select]", "-1"));
            propertiesDropDown.SelectedIndex = 0;
        }

        private void FillNumberOfPeopleDropDown<T>()
        {
            int unitID = int.Parse(GetSelectedUnit());
            int unitCapacity;

            using (var context = new SE20E01_DBEntities())
            {
                var query = from unit in context.Units
                            where unit.UnitID == unitID
                            select unit.Capacity;

                unitCapacity = query.Single();
            }

            for (int i = 1; i < unitCapacity + 1; i++)
            {
                numberOfPeopleDropDownList.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        private string GetSelectedProperty()
        {
            if (propertiesDropDown.SelectedItem != null)
            {
                return propertiesDropDown.SelectedItem.Value;
            }
            return null;
        }

        private string GetSelectedUnit()
        {
            if (unitsDropDown.SelectedItem != null)
            {
                return unitsDropDown.SelectedItem.Value;
            }
            return null;
        }
    }
}