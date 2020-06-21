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
            //if the page is refreshed this block won't be executed
            if (!Page.IsPostBack)
            {
                FillPropertiesDropDown<Property>();
                FillUnitsDropDown<AIForRentersLib.Unit>();
                FillNumberOfPeopleDropDown<int>();
            }
        }

        /// <summary>
        /// This method is triggered by a click event on the
        /// Send request button in web form.
        /// It collects all necessary data from the web form to create
        /// new client and new request objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void sendRequestButton_Click(object sender, EventArgs e)
        {
            //getting the selected unit and property using GetUnit and GetProperty methods
            AIForRentersLib.Unit selectedUnit = GetUnit();
            Property selectedProperty = GetProperty();

            //collecting data and storing it into variables
            string clientName = nameTextBox.Text;
            string clientSurname = surnameTextBox.Text;
            string clientEmail = emailTextBox.Text;
            int numberOfPeople = int.Parse(numberOfPeopleDropDownList.SelectedItem.Text);
            DateTime fromDate = dateFromCalendar.SelectedDate;
            DateTime toDate = dateToCalendar.SelectedDate;
            double priceUponRequest = selectedUnit.Price;

            //creating new client using CreateClient method
            Client newClient = CreateClient(clientName, clientSurname, clientEmail);

            //creating new request using CreateRequest method
            Request newRequest = CreateRequest(newClient, selectedProperty, selectedUnit, numberOfPeople, fromDate, toDate, priceUponRequest);

            //using context to store new request and client in the database
            using (var context = new SE20E01_DBEntities())
            {
                context.Clients.Add(newClient);

                context.Requests.Add(newRequest);

                context.SaveChanges();
            }

            //popup that informs client about successful sending of request
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('Your request has been sent successfully!')", true);
        }

        /// <summary>
        /// This method is triggered by a selected index changed event on the
        /// properties dropdown in web form.
        /// It fills the units dropdown only with units that are in the selected property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is triggered by a selected index changed event on the
        /// units dropdown in web form.
        /// It fills the number of people dropdown only with numbers that are in range
        /// from 1 to the capacity of the selected unit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// The method gets the units from the database with a LINQ query
        /// and stores it in a list of units which is used as data source for
        /// showing units dropdown in web form.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// The method gets the properties from the database with a LINQ query
        /// and stores it in a list of properties which is used as data source for
        /// showing properties dropdown in web form.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// The method generates numbers from 1 to 10 and stores them in the list of numbers
        /// which is used as data source for filling number of people dropdown in web form.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// This method returns the PropertyID of the selected property 
        /// in the properties dropdown in web form.
        /// </summary>
        /// <returns>PropertyID of selected property</returns>
        private string GetSelectedProperty()
        {
            if (propertiesDropDown.SelectedItem != null)
            {
                return propertiesDropDown.SelectedValue;
            }
            return null;
        }

        /// <summary>
        /// This method returns the UnitID of the selected unit 
        /// in the properties dropdown in web form.
        /// </summary>
        /// <returns>UnitID of selected unit</returns>
        private string GetSelectedUnit()
        {
            if (unitsDropDown.SelectedItem != null)
            {
                return unitsDropDown.SelectedValue;
            }
            return null;
        }

        /// <summary>
        /// This method searches the database for a property with PropertyID that equals
        /// the PropertyID returned by GetSelectedProperty() method.
        /// It returns the found property.
        /// </summary>
        /// <returns>Property object</returns>
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

        /// <summary>
        /// This method searches the database for a property with UnitID that equals
        /// the UnitID returned by GetSelectedUnit() method.
        /// It returns the found unit.
        /// </summary>
        /// <returns>Unit object</returns>
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

        /// <summary>
        /// This method creates new Request object and returns it.
        /// </summary>
        /// <param name="newClient"></param>
        /// <param name="selectedProperty"></param>
        /// <param name="selectedUnit"></param>
        /// <param name="numberOfPeople"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="priceUponRequest"></param>
        /// <returns>New Request object</returns>
        private Request CreateRequest(Client newClient, Property selectedProperty, AIForRentersLib.Unit selectedUnit, int numberOfPeople, DateTime fromDate, DateTime toDate, double priceUponRequest)
        {
            Request newRequest = new Request();

            newRequest.Client = newClient;
            newRequest.Property = selectedProperty.Name;
            newRequest.Unit = selectedUnit.Name;
            newRequest.NumberOfPeople = numberOfPeople;
            newRequest.FromDate = fromDate;
            newRequest.ToDate = toDate;
            newRequest.PriceUponRequest = priceUponRequest;
            newRequest.Confirmed = false;
            newRequest.Processed = false;
            newRequest.Sent = false;
            newRequest.ResponseSubject = "";
            newRequest.ResponseBody = "";

            return newRequest;
        }

        /// <summary>
        /// This method creates new Client object and returns it.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="clientSurname"></param>
        /// <param name="clientEmail"></param>
        /// <returns>New Client object</returns>
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