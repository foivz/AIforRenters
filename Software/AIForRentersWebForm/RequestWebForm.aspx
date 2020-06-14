<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestWebForm.aspx.cs" Inherits="AIForRentersWebForm.RequestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }

        .calendar{
            width: 25%;
            margin: auto;
            display: grid;
            grid-template-columns: 1fr 1fr;
            grid-template-rows: 1fr;
            grid-gap: 10px;
        }

        .from{
            grid-column: 1;
            grid-row: 1;
            margin: auto;
            width: auto;
        }

        .to {
            grid-column: 2;
            grid-row: 1;
            margin: auto;
            width: auto;
        }
    </style>
</head>
<body>
    <h1 style="text-align: center">Request for rent</h1>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label><br />
            <asp:TextBox ID="surnameTextBox" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label7" runat="server" Text="Property"></asp:Label><br />
            <asp:DropDownList ID="propertiesDropDown" runat="server" OnSelectedIndexChanged="propertiesDropDown_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br /><br />

            <asp:Label ID="Label3" runat="server" Text="Unit"></asp:Label><br />
            <asp:DropDownList ID="unitsDropDown" runat="server" OnSelectedIndexChanged="unitsDropDown_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br /><br />

            <asp:Label ID="Label9" runat="server" Text="Number of people"></asp:Label><br />
            <asp:DropDownList ID="numberOfPeopleDropDownList" runat="server"></asp:DropDownList><br /><br />

            <div class="calendar">
                <div class="calendar from">
                    <asp:Label ID="Label4" runat="server" Text="From"></asp:Label><br />
                    <asp:Calendar ID="dateFromCalendar" runat="server"></asp:Calendar>
                </div>
                
                <div class="calendar to">
                    <asp:Label ID="Label5" runat="server" Text="To"></asp:Label><br />
                    <asp:Calendar ID="dateToCalendar" runat="server"></asp:Calendar><br /><br />
                </div>
            </div><br/>

            <asp:Button ID="sendRequestButton" runat="server" Text="Send request" OnClick="sendRequestButton_Click" />
        </div>
    </form>
</body>
</html>
