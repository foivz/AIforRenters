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

        }

        protected void sendRequestButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string email = emailTextBox.Text;
            //int numberOfPeople = int.Parse(numberOfPeopleDropDownList.SelectedValue);
            string property = propertiesDropDown.SelectedValue;
            string unit = unitsDropDown.SelectedValue;
            DateTime dateFrom = dateFromCalendar.SelectedDate;
            DateTime dateTo = dateToCalendar.SelectedDate;
            string comment = commentTextBox.Text;

            Request newClientRequest = new Request(name, surname, email, 3, property, unit, dateFrom, dateTo, comment);

            newClientRequest.AddRequest(newClientRequest);
        }
    }
}