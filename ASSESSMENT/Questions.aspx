<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="Questioner.Qsheet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="No" 
            DataSourceID="SqlDataSourceQn" EnableModelValidation="True" Height="16px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="No" HeaderText="No" ReadOnly="True" 
                    SortExpression="No" />
                <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                <asp:BoundField DataField="Question" HeaderText="Question" 
                    SortExpression="Question" />
                <asp:BoundField DataField="AnswerA" HeaderText="AnswerA" 
                    SortExpression="AnswerA" />
                <asp:BoundField DataField="AnswerB" HeaderText="AnswerB" 
                    SortExpression="AnswerB" />
                <asp:BoundField DataField="AnswerC" HeaderText="AnswerC" 
                    SortExpression="AnswerC" />
                <asp:BoundField DataField="AnswerD" HeaderText="AnswerD" 
                    SortExpression="AnswerD" />
                <asp:BoundField DataField="AnswerFinalObj" HeaderText="AnswerFinalObj" 
                    SortExpression="AnswerFinalObj" />
                <asp:BoundField DataField="AnsInputUpper" HeaderText="AnsInputUpper" 
                    SortExpression="AnsInputUpper" />
                <asp:BoundField DataField="AnsInputLower" HeaderText="AnsInputLower" 
                    SortExpression="AnsInputLower" />
            </Columns>
            <EditRowStyle BorderColor="#0066FF" />
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" Width="600px" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceQn" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:QnConnectionString %>" 
            DeleteCommand="DELETE FROM [QnTable] WHERE [No] = @original_No AND [Type] = @original_Type AND [Question] = @original_Question AND (([AnswerA] = @original_AnswerA) OR ([AnswerA] IS NULL AND @original_AnswerA IS NULL)) AND (([AnswerB] = @original_AnswerB) OR ([AnswerB] IS NULL AND @original_AnswerB IS NULL)) AND (([AnswerC] = @original_AnswerC) OR ([AnswerC] IS NULL AND @original_AnswerC IS NULL)) AND (([AnswerD] = @original_AnswerD) OR ([AnswerD] IS NULL AND @original_AnswerD IS NULL)) AND (([AnswerFinalObj] = @original_AnswerFinalObj) OR ([AnswerFinalObj] IS NULL AND @original_AnswerFinalObj IS NULL)) AND (([AnsInputUpper] = @original_AnsInputUpper) OR ([AnsInputUpper] IS NULL AND @original_AnsInputUpper IS NULL)) AND (([AnsInputLower] = @original_AnsInputLower) OR ([AnsInputLower] IS NULL AND @original_AnsInputLower IS NULL))" 
            InsertCommand="INSERT INTO [QnTable] ([Type], [Question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerFinalObj], [AnsInputUpper], [AnsInputLower]) VALUES (@Type, @Question, @AnswerA, @AnswerB, @AnswerC, @AnswerD, @AnswerFinalObj, @AnsInputUpper, @AnsInputLower)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [QnTable]" 
            UpdateCommand="UPDATE [QnTable] SET [Type] = @Type, [Question] = @Question, [AnswerA] = @AnswerA, [AnswerB] = @AnswerB, [AnswerC] = @AnswerC, [AnswerD] = @AnswerD, [AnswerFinalObj] = @AnswerFinalObj, [AnsInputUpper] = @AnsInputUpper, [AnsInputLower] = @AnsInputLower WHERE [No] = @original_No AND [Type] = @original_Type AND [Question] = @original_Question AND (([AnswerA] = @original_AnswerA) OR ([AnswerA] IS NULL AND @original_AnswerA IS NULL)) AND (([AnswerB] = @original_AnswerB) OR ([AnswerB] IS NULL AND @original_AnswerB IS NULL)) AND (([AnswerC] = @original_AnswerC) OR ([AnswerC] IS NULL AND @original_AnswerC IS NULL)) AND (([AnswerD] = @original_AnswerD) OR ([AnswerD] IS NULL AND @original_AnswerD IS NULL)) AND (([AnswerFinalObj] = @original_AnswerFinalObj) OR ([AnswerFinalObj] IS NULL AND @original_AnswerFinalObj IS NULL)) AND (([AnsInputUpper] = @original_AnsInputUpper) OR ([AnsInputUpper] IS NULL AND @original_AnsInputUpper IS NULL)) AND (([AnsInputLower] = @original_AnsInputLower) OR ([AnsInputLower] IS NULL AND @original_AnsInputLower IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_No" Type="Int32" />
                <asp:Parameter Name="original_Type" Type="String" />
                <asp:Parameter Name="original_Question" Type="String" />
                <asp:Parameter Name="original_AnswerA" Type="String" />
                <asp:Parameter Name="original_AnswerB" Type="String" />
                <asp:Parameter Name="original_AnswerC" Type="String" />
                <asp:Parameter Name="original_AnswerD" Type="String" />
                <asp:Parameter Name="original_AnswerFinalObj" Type="String" />
                <asp:Parameter Name="original_AnsInputUpper" Type="Int64" />
                <asp:Parameter Name="original_AnsInputLower" Type="Int64" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Type" Type="String" />
                <asp:Parameter Name="Question" Type="String" />
                <asp:Parameter Name="AnswerA" Type="String" />
                <asp:Parameter Name="AnswerB" Type="String" />
                <asp:Parameter Name="AnswerC" Type="String" />
                <asp:Parameter Name="AnswerD" Type="String" />
                <asp:Parameter Name="AnswerFinalObj" Type="String" />
                <asp:Parameter Name="AnsInputUpper" Type="Int64" />
                <asp:Parameter Name="AnsInputLower" Type="Int64" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Type" Type="String" />
                <asp:Parameter Name="Question" Type="String" />
                <asp:Parameter Name="AnswerA" Type="String" />
                <asp:Parameter Name="AnswerB" Type="String" />
                <asp:Parameter Name="AnswerC" Type="String" />
                <asp:Parameter Name="AnswerD" Type="String" />
                <asp:Parameter Name="AnswerFinalObj" Type="String" />
                <asp:Parameter Name="AnsInputUpper" Type="Int64" />
                <asp:Parameter Name="AnsInputLower" Type="Int64" />
                <asp:Parameter Name="original_No" Type="Int32" />
                <asp:Parameter Name="original_Type" Type="String" />
                <asp:Parameter Name="original_Question" Type="String" />
                <asp:Parameter Name="original_AnswerA" Type="String" />
                <asp:Parameter Name="original_AnswerB" Type="String" />
                <asp:Parameter Name="original_AnswerC" Type="String" />
                <asp:Parameter Name="original_AnswerD" Type="String" />
                <asp:Parameter Name="original_AnswerFinalObj" Type="String" />
                <asp:Parameter Name="original_AnsInputUpper" Type="Int64" />
                <asp:Parameter Name="original_AnsInputLower" Type="Int64" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Height="46px" onclick="Button1_Click" Text="Add Question" Width="126px" />
&nbsp;
    
    </div>
    </form>
</body>
</html>
