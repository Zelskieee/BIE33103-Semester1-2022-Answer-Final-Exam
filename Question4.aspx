<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question4.aspx.cs" Inherits="Spot_Sem1_2022.WebForm9" %>

<!DOCTYPE html>
<html>
<head>
    <title>President Election Form</title>
</head>
<body>

    <form id="presidentForm" runat="server">

        <h1>PRESIDENT ELECTION 2021</h1>

        <p>President Election Form: Choose your president</p>

        <table>
            <tr>
                <td><label for="ddlCandidates">Candidate:</label></td>
                <td>
                    <asp:DropDownList ID="ddlCandidates" runat="server">
                        <asp:ListItem Text="Ahmad" Value="Ahmad"></asp:ListItem>
                        <asp:ListItem Text="Ali" Value="Ali"></asp:ListItem>
                        <asp:ListItem Text="Eugene" Value="Eugene"></asp:ListItem>
                        <asp:ListItem Text="Siva" Value="Siva"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td><span style="color: red;">Please choose a candidate!</span></td>
            </tr>
            <tr>
                <td><label>House:</label></td>
                <td>
                    <asp:RadioButtonList ID="rblHouses" runat="server">
                        <asp:ListItem Text="Blue" Value="Blue"></asp:ListItem>
                        <asp:ListItem Text="Red" Value="Red"></asp:ListItem>
                        <asp:ListItem Text="Green" Value="Green"></asp:ListItem>
                        <asp:ListItem Text="Yellow" Value="Yellow"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td></td>
            </tr>
            <tr>
                <td><label for="txtClass">Class:</label></td>
                <td><asp:TextBox ID="txtClass" runat="server"></asp:TextBox></td>
                <td><span style="color: red;">Enter your class (5-10)</span></td>
            </tr>
            <tr>
                <td><label for="txtPhoneNumber">Phone Number:</label></td>
                <td><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td>
                <td><span style="color: red;">Enter phone number</span></td>
            </tr>
            <tr>
                <td><label for="txtEmail">Email:</label></td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                <td><span style="color: red;">Enter Email</span></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ErrorMessage="Invalid Email" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" /></td>
                <td></td>
            </tr>
        </table>

    </form>

</body>
</html>