<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminForm.aspx.cs" Inherits="aspTeräs.adminForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="id"
                ShowHeaderWhenEmpty="true" 
                
                onRowCommand="GridView1_RowCommand" onRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                onRowUpdating="GridView1_RowUpdating" onRowDeleting="GridView1_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="349px">

                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />

                <Columns>
                    <asp:TemplateField HeaderText="Nimike">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Nimike") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNimikeName" Text='<%# Eval("Nimike") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNimikeFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Tiedot">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Tiedot") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTiedot" Text='<%# Eval("Tiedot") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTiedotFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Button4" Text="Muokkaa" runat="server" CommandName="Edit" ToolTip="Edit" Width="80px" Height="20px"/>
                            <asp:Button ID="Button5" Text="Poista" runat="server" CommandName="Delete" ToolTip="Delete" Width="80px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="Button6" Text="Tallenna" runat="server" CommandName="Update" ToolTip="Update" Width="80px" Height="20px"/>
                            <asp:Button ID="Button7" Text="Hylkaa" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="80px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="Button8" Text="Uusi" runat="server" CommandName="AddNew" ToolTip="Add New" Width="80px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>

            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="gridi" />
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="gridi2" />
            <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="gridi3" />
            <br />

            <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
