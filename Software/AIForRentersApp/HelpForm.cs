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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillData()
        {
            foreach (var item in Application.OpenForms)
            {
                if (item == LoginForm.ActiveForm)
                {
                    groupBoxName.Text = "Login";
                    labelContent.Text = "You must enter your email and password in the given text boxes and \nthen click the 'Log in' button.";
                }
                if (item == FormRequests.ActiveForm)
                {
                    groupBoxName.Text = "Requests";
                    labelContent.Text = "Here you can see incoming requests and if you click on one of them you can see the \nautomatic" +
                        " response generated for that request. If you click on the 'Edit response' button you \ncan edit it and if you click" +
                        " on 'Send response' button you will send it to the client. \nIn the upper right corner you can click on" +
                        " 'Properties / units' button and see your properties \nand units. Also you can click on 'Email templates' button " +
                        " to see your templates.";
                }
                if (item == PropertiesForm.ActiveForm)
                {
                    groupBoxName.Text = "Properties";
                    labelContent.Text = "Here you can see the list of your properties. You can enter new property by entering property" +
                        " \nname in the 'Property name' text box and property location in 'Property location' text box and \nclicking the" +
                        " 'Add new property' button. If you click on the 'Edit property' button you can" +
                        " \nedit it and then you must click the 'Save changes' button. If you click on 'Delete Property' \nbutton you will" +
                        " delete it. If you click on the property in the list and then on the \n'Units of a property' button you can see" +
                        " all units in that property. In the upper right corner you \ncan click on 'Requests / responses' button and see" +
                        " your incoming requests and automatic \nresponses. Also you can click on 'Email templates' button to see your" +
                        " templates.";
                }
                if (item == UnitsForm.ActiveForm)
                {
                    groupBoxName.Text = "Units";
                    labelContent.Text = "Here you can see the list of your units that are bound to the property. You can see to \nwhich" +
                        " property your units are bound in the 'Property name' text box in which will be the \ndisplayed name." +
                        " Under that text box will be shown the list of units and you can click on the \nunit and edit it by clicking" +
                        " the 'Edit unit' button and changing the data in text boxes below the \nlist and then clicking on the 'Save changes'" +
                        " button. You can also delete units by choosing \nthem from the list and clicking the 'Delete unit' button" +
                        " Adding new unit is also possible by \nfilling the text boxes below the list and clicking the 'Add new unit'" +
                        " button. In the upper right \ncorner you can click on 'Requests / responses' button and see your incoming requests" +
                        " and \nautomatic responses. Also you can click on 'Email templates' button to see your templates or \nyou can click" +
                        " on the 'Properties / units' button to return to your properties.";
                }
                if (item == EmailTemplatesForm.ActiveForm)
                {
                    groupBoxName.Text = "Email templates";
                    labelContent.Text = "Here you can see your templates for creating automatic responses and if you click on one of \nthem" +
                        " you can edit them by clicking on the 'Edit template' button. Then the chosen template \nwill fill the text boxes" +
                        " 'Template name' with its name and the bigger text box below with \ntemplate's content. When you finish editing" +
                        " the template you must click on the \n'Save changes' button to save changes. You can also add new templates by" +
                        " filling the \nmentioned text boxes with the name and content of the new template and clicking on the \nbutton 'Add" +
                        " new template'. You can also delete templates by clicking on the template in the \nlist and then clickin on the" +
                        " 'Delete template' button. In the upper right corner you can click \non 'Properties / units' button and see your" +
                        " properties and units. Also you can click on \n'Requests / responses' button to see your incoming requests" +
                        " and automatic responses.";
                }
            }
        }
    }
}
