<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestWebForm.aspx.cs" Inherits="AIForRentersWebForm.RequestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AI for Renters APP</title>
    <link href="https://fonts.googleapis.com/css2?family=Rubik:wght@300&display=swap" rel="stylesheet"> 
    <style type="text/css">
        body{
            font-family: 'Rubik', sans-serif;
        }

        .auto-style1 {
            text-align: center;
            padding: 40px 0px 40px 0px;
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

        .textBoxStyle {
            width: 20%;
            padding: 10px 10px 10px 10px;
            margin: 5px 0 0 0;
            border-radius: 5px;
            border: 1px solid rgba(127, 140, 141,0.3);
        }

        .textBoxStyle:focus {
            width: 20%;
            padding: 10px 10px 10px 10px;
            margin: 5px 0 0 0;
            box-shadow: 0 12px 16px 0 rgba(127, 140, 141,0.2), 0 17px 50px 0 rgba(127, 140, 141,0.2);
        }

        .dropDownStyle {
            width: 20%;
            padding: 10px 10px 10px 10px;
            margin: 5px 0 0 0;
            border-radius: 5px;
            border: 1px solid rgba(127, 140, 141,0.3);
        }

        .dropDownStyle:focus {
            width: 20%;
            padding: 10px 10px 10px 10px;
            margin: 5px 0 0 0;
            border-radius: 5px;
            border: 1px solid rgba(127, 140, 141,0.3);
            box-shadow: 0 12px 16px 0 rgba(127, 140, 141,0.2), 0 17px 50px 0 rgba(127, 140, 141,0.2);
        }

        #sendRequestButton{
            background-color: rgba(127, 140, 141,1.0);
            border: none;
            border-radius: 5px;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            cursor: pointer;
            margin-top: 20px;
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
        }

        #sendRequestButton:hover{
            background-color: white;
            border: 1px solid rgba(127, 140, 141,1.0);
            border-radius: 5px;
            color: rgba(127, 140, 141,1.0);
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            cursor: pointer;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
            transition-duration: 0.4s;
        }

        .calendarStyle {
            background-color: #f2f2f2;
            width: 156px;
            border: none !important;
        }

        .calendar td {
            padding: 5px 5px 5px 5px;
        }

        .calendar td:hover{
            padding: 5px 5px 5px 5px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
        }

         .calendarStyle a
         {
            text-decoration: none;
         }

         .calendarStyle:hover{
             box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
         }

         footer{
             text-align: center;
         }
    </style>
</head>
<body style="background-image: url('https://www.cadsoft.com/wp-content/uploads/2016/04/White-Geometric-background-01.png'); background-size:cover;">
    <h1 style="text-align: center; font-size: 50px; font-weight: 200;">AI for Renters web form</h1>
    <h1 style="text-align: center">Request for accomodation unit</h1>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label CssClass="labelStyle" ID="Label1" runat="server" Text="Name"></asp:Label><br />
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="textBoxStyle" placeholder="John"></asp:TextBox><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label><br />
            <asp:TextBox ID="surnameTextBox" runat="server" CssClass="textBoxStyle" placeholder="Doe"></asp:TextBox><br /><br />

            <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTextBox" runat="server" CssClass="textBoxStyle" placeholder="johndoe@domain.com"></asp:TextBox><br /><br />

            <asp:Label ID="Label7" runat="server" Text="Property"></asp:Label><br />
            <asp:DropDownList CssClass="dropDownStyle" ID="propertiesDropDown" runat="server" OnSelectedIndexChanged="propertiesDropDown_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br /><br />

            <asp:Label ID="Label3" runat="server" Text="Unit"></asp:Label><br />
            <asp:DropDownList CssClass="dropDownStyle" ID="unitsDropDown" runat="server" OnSelectedIndexChanged="unitsDropDown_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br /><br />

            <asp:Label ID="Label9" runat="server" Text="Number of people"></asp:Label><br />
            <asp:DropDownList CssClass="dropDownStyle" ID="numberOfPeopleDropDownList" runat="server"></asp:DropDownList><br /><br />

            <div class="calendar">
                <div class="calendar from">
                    <asp:Label ID="Label4" runat="server" Text="Check-in date"></asp:Label><br />
                    <asp:Calendar CssClass="calendarStyle" ID="dateFromCalendar" runat="server" CellSpacing="2"></asp:Calendar>
                </div>
                
                <div class="calendar to">
                    <asp:Label ID="Label5" runat="server" Text="Check-out date"></asp:Label><br />
                    <asp:Calendar CssClass="calendarStyle" ID="dateToCalendar" runat="server" CellSpacing="2"></asp:Calendar><br /><br />
                </div>
            </div><br/>

            <asp:Button ID="sendRequestButton" runat="server" Text="Send request" OnClick="sendRequestButton_Click" />
        </div>
    </form>
    <footer>
        <p>This app is made by team of students from University of Zagreb - Faculty of organization and informatics.</p>
        <p>&copy 2020. FOI - Software Engineering</p>
    </footer>
</body>
</html>
