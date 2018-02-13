<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportTemp.aspx.cs" Inherits="Questioner.ReportTemp" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 507px">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ExportToExcel" runat="server" Height="41px" onclick="ExportToExcel_Click" 
            Text="Export To Excel" Width="155px" />
            
&nbsp;<br />
&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSourceReport" 
            EnableModelValidation="True" Height="450px" Width="992px" 
            AllowSorting="True" PageSize="30" style="margin-left: 26px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Reg" HeaderText="Registration No." 
                    SortExpression="Reg" />
                <asp:BoundField DataField="StdNo" HeaderText="Student No." 
                    SortExpression="StdNo" />
                <asp:BoundField DataField="Course" HeaderText="Course" 
                    SortExpression="Course" />
                <asp:BoundField DataField="Mark" HeaderText="Mark" SortExpression="Mark" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:SqlDataSource ID="SqlDataSourceReport" runat="server" 
            ConnectionString="<%$ ConnectionStrings:QnConnectionString %>" 
            SelectCommand="SELECT * FROM [Tally] WHERE ([Mark] IS NOT NULL)" 
            ConflictDetection="CompareAllValues" 
            DeleteCommand="DELETE FROM [Tally] WHERE [id] = @original_id AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Reg] = @original_Reg) OR ([Reg] IS NULL AND @original_Reg IS NULL)) AND (([StdNo] = @original_StdNo) OR ([StdNo] IS NULL AND @original_StdNo IS NULL)) AND (([Course] = @original_Course) OR ([Course] IS NULL AND @original_Course IS NULL)) AND (([Mark] = @original_Mark) OR ([Mark] IS NULL AND @original_Mark IS NULL))" 
            InsertCommand="INSERT INTO [Tally] ([Name], [Reg], [StdNo], [Course], [Mark]) VALUES (@Name, @Reg, @StdNo, @Course, @Mark)" 
            OldValuesParameterFormatString="original_{0}" 
            UpdateCommand="UPDATE [Tally] SET [Name] = @Name, [Reg] = @Reg, [StdNo] = @StdNo, [Course] = @Course, [Mark] = @Mark WHERE [id] = @original_id AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Reg] = @original_Reg) OR ([Reg] IS NULL AND @original_Reg IS NULL)) AND (([StdNo] = @original_StdNo) OR ([StdNo] IS NULL AND @original_StdNo IS NULL)) AND (([Course] = @original_Course) OR ([Course] IS NULL AND @original_Course IS NULL)) AND (([Mark] = @original_Mark) OR ([Mark] IS NULL AND @original_Mark IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Reg" Type="String" />
                <asp:Parameter Name="original_StdNo" Type="Int32" />
                <asp:Parameter Name="original_Course" Type="String" />
                <asp:Parameter Name="original_Mark" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Reg" Type="String" />
                <asp:Parameter Name="StdNo" Type="Int32" />
                <asp:Parameter Name="Course" Type="String" />
                <asp:Parameter Name="Mark" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Reg" Type="String" />
                <asp:Parameter Name="StdNo" Type="Int32" />
                <asp:Parameter Name="Course" Type="String" />
                <asp:Parameter Name="Mark" Type="Int32" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Reg" Type="String" />
                <asp:Parameter Name="original_StdNo" Type="Int32" />
                <asp:Parameter Name="original_Course" Type="String" />
                <asp:Parameter Name="original_Mark" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
