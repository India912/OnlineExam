<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminviewqus.aspx.cs" Inherits="Online_Exam.adminviewqus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 824px; background-color:lightyellow;">
    <form id="form1" runat="server">
        <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" Text="Add Question " BackColor="Lime" Font-Bold="True" Font-Size="Medium" Height="43px" OnClick="Button10_Click" Width="174px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button11" runat="server" Text="View Questions" BackColor="Lime" Font-Bold="True" Font-Size="Medium" Height="46px" OnClick="Button11_Click" Width="186px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button12" runat="server" Text="Add Students" BackColor="Lime" Font-Bold="True" Font-Size="Medium" Height="46px" OnClick="Button12_Click" Width="175px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button13" runat="server" Text="View Result" BackColor="Lime" Font-Bold="True" Font-Size="Medium" Height="43px" OnClick="Button13_Click" Width="155px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" BackColor="Lime" Font-Bold="True" Font-Size="Medium" Height="42px" OnClick="Button9_Click" Text="Log Out" Width="130px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />

        </div>
        <div style="margin-right:auto;margin-left:auto;text-align:center;">
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Total No Of Question And Answers"></asp:Label>
            <br />
            <br />
        </div>
         <div style="height: 385px; position:absolute;left:20%;width:60%;padding:0;margin-top:50px";>
            <asp:GridView ID="GridView1" runat="server" Height="370px" Width="96%" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
