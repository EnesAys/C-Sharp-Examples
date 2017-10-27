<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="suppliers.aspx.cs" Inherits="MasterPage_Vericekme.suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table cellpadding="0" cellspacing="0" border="0" class="stdtable">
                    <colgroup>
                        <col class="con0" />
                        <col class="con1" />
                        <col class="con0" />
                        <col class="con1" />
                        <col class="con0" />
                    </colgroup>
                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" OnItemCreated="Repeater1_ItemCreated">

                        <HeaderTemplate>
                            <thead>
                                <tr>
                                    <th class="head0">Tedarilçi ID</th>
                                    <th class="head1">İletişim Adi</th>
                                    <th class="head0">Şirket Adı</th>
                                    <th class="head1">Bölge</th>
                                    <th class="head0">Ülke</th>
                                </tr>
                            </thead>
                               <tbody>
                        </HeaderTemplate>                         
                        <ItemTemplate>
                                <tr>
                                    <td><%#Eval("SupplierID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("ContactName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("ContactName") %>' 
                                            ID="lnkTedarik"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("CompanyName") %></td>
                                    <td class="center"><%#Eval("Region") %></td>
                                    <td class="center"><%#Eval("Country") %></td>
                                </tr>          
                        </ItemTemplate> 
                        <AlternatingItemTemplate>
                                <tr style="background-color:blanchedalmond">
                                    <td><%#Eval("SupplierID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("ContactName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("ContactName") %>' 
                                            ID="lnkUrun"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("CompanyName") %></td>
                                    <td class="center"><%#Eval("Region") %></td>
                                    <td class="center"><%#Eval("Country") %></td>
                                </tr>          
                        </AlternatingItemTemplate>    
                        <FooterTemplate>
                             </tbody>
                                <tr>
                                    <th colspan="5" class="head0">
                                        <asp:Label id="lblBilgilendirme" runat="server" ></asp:Label></th>                                   
                                    </tr>
                         </FooterTemplate>

                     </asp:Repeater>
                </table>
</asp:Content>
