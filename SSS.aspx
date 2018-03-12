<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="SSS.aspx.cs" Inherits="SSS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
        <div class="left_content_body">

<!-- Heading -->
            <p class="page_title">
                <asp:Label ID="_lblHizmetName" runat="server"></asp:Label>
            </p>
<!-- Heading -->

    &nbsp;<table style="width: 100%">
                <tr>
                    <td>
                        <asp:Label ID="_lblAciklama" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </div>
<!-- Left Content Body Ends Here -->



<!-- Right Content Body Starts Here -->
        <div class="right_content_body">

<!-- More Links Starts here -->
<!-- Heading -->
            <p class="page_sub_title">
Sık Sorulan Sorular
            </p>
<!-- Heading -->

            <div class="more_links">
                <ul>
<%
    for (int i = 0; i < _dtSSS.Rows.Count; i++)
    {
        Response.Write("<li><a href='SSS.aspx?MercanYaziliM=" + Convert.ToInt32(_dtSSS.Rows[i]["idSSS"]) + "'>" + _dtSSS.Rows[i]["Soru"].ToString() + "</li>");
    }
    
    
     %>




<%--    <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
    </asp:BulletedList>--%>
                </ul>
            </div>

<!-- More Links Ends Here -->

        </div>
<!-- Right Content Body Ends here -->

<!-- Clear -->
        <div class="clear">
        </div>
<!-- Clear -->

    </div>
</asp:Content>

