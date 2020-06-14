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
            if (!Page.IsPostBack)
            {
                FillPropertiesDropDown<Property>();
                FillUnitsDropDown<AIForRentersLib.Unit>();
                FillNumberOfPeopleDropDown<int>();
            }
        }

        protected void sendRequestButton_Click(object sender, EventArgs e)
        {

            //AIForRentersLib.Unit selectedUnit = GetUnit();
           //Property selectedProperty = GetProperty();

            int unitID = int.Parse(GetSelectedUnit());
            int propertyID = int.Parse(GetSelectedProperty());

            string clientName = nameTextBox.Text;
            string clientSurname = surnameTextBox.Text;
            string clientEmail = emailTextBox.Text;
            int numberOfPeople = int.Parse(numberOfPeopleDropDownList.SelectedItem.Text);
            DateTime fromDate = dateFromCalendar.SelectedDate;
            DateTime toDate = dateToCalendar.SelectedDate;

            Client newClient = CreateClient(clientName, clientSurname, clientEmail);

            Request newRequest = CreateRequest(newClient, propertyID, unitID, numberOfPeople, fromDate, toDate);

            using (var context = new SE20E01_DBEntities())
            {
                //context.Properties.Attach(selectedProperty);
                //context.Units.Attach(selectedUnit);

                context.Clients.Attach(newClient);
                context.Clients.Add(newClient);

                context.Requests.Attach(newRequest);
                context.Requests.Add(newRequest);

                context.SaveChanges();
            }
        }

        protected void propertiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        protected void unitsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
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
                numbers.Add(i);
            }

            numberOfPeopleDropDownList.DataSource = numbers;
            numberOfPeopleDropDownList.DataBind();
        }

        private void FillUnitsDropDown<T>()
        {
            List<AIForRentersLib.Unit> units = new List<AIForRentersLib.Unit>();

            using (var context = new SE20E01_DBEntities())
            {
                var query = from unit in context.Units
                            select unit;

                units = query.ToList();
            }

            unitsDropDown.DataTextField = "Name";
            unitsDropDown.DataValueField = "UnitID";
            unitsDropDown.DataSource = units;
            unitsDropDown.DataBind();
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
        }

        private void FillNumberOfPeopleDropDown<T>()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }

            numberOfPeopleDropDownList.DataSource = numbers;
            numberOfPeopleDropDownList.DataBind();
        }

        private string GetSelectedProperty()
        {
            if (propertiesDropDown.SelectedItem != null)
            {
                return propertiesDropDown.SelectedValue;
            }
            return null;
        }

        private string GetSelectedUnit()
        {
            if (unitsDropDown.SelectedItem != null)
            {
                return unitsDropDown.SelectedValue;
            }
            return null;
        }

        private Property GetProperty()
        {
            int propertyID = int.Parse(GetSelectedProperty());

            Property selectedProperty;


            using (var context = new SE20E01_DBEntities())
            {
                var queryProperty = from property in context.Properties
                                    where property.PropertyID == propertyID
                                    select property;

                selectedProperty = queryProperty.Single();
            }

            return selectedProperty;
        }

        private AIForRentersLib.Unit GetUnit()
        {
            int unitID = int.Parse(GetSelectedUnit());
            AIForRentersLib.Unit selectedUnit;

            using (var context = new SE20E01_DBEntities())
            {
                var queryUnit = from unit in context.Units
                                where unit.UnitID == unitID
                                select unit;

                selectedUnit = queryUnit.Single();
            }

            return selectedUnit;
        }

        private Request CreateRequest(Client newClient, int selectedProperty, int selectedUnit, int numberOfPeople, DateTime fromDate, DateTime toDate)
        {
            Request newRequest = new Request();

            newRequest.Client = newClient;
            newRequest.PropertyID = selectedProperty;
            newRequest.UnitID = selectedUnit;
            newRequest.NumberOfPeople = numberOfPeople;
            newRequest.FromDate = fromDate;
            newRequest.ToDate = toDate;
            newRequest.Confirmed = false;

            return newRequest;
        }

        private Client CreateClient(string clientName, string clientSurname, string clientEmail)
        {
            Client newClient = new Client();

            newClient.Name = clientName;
            newClient.Surname = clientSurname;
            newClient.Email = clientEmail;

            return newClient;
        }
    }
}