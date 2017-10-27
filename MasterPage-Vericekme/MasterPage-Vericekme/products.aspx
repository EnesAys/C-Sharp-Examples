<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="MasterPage_Vericekme.products" %>
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
                                    <th class="head0">Ürün ID</th>
                                    <th class="head1">Ürün Adi</th>
                                    <th class="head0">Kategori Adı</th>
                                    <th class="head1">Stoktaki Miktari</th>
                                    <th class="head0">Fiyatı</th>
                                </tr>
                            </thead>
                               <tbody>
                        </HeaderTemplate>                         
                        <ItemTemplate>
                                <tr>
                                    <td><%#Eval("ProductID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("ProductName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("ProductName") %>' 
                                            ID="lnkTedarik"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("CategoryName") %></td>
                                  <td class="center"><%#Eval("UnitPrice","{0:C}") %></td>
                                    <td class="center"><%#Eval("UnitsInStock") %></td>
                                </tr>          
                        </ItemTemplate> 
                        <AlternatingItemTemplate>
                                <tr style="background-color:blanchedalmond">
                                    <td><%#Eval("ProductID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("ProductName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("ProductName") %>' 
                                            ID="lnkUrun"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("CategoryName") %></td>
                                <td class="center"><%#Eval("UnitPrice","{0:C}") %></td>
                                    <td class="center"><%#Eval("UnitsInStock") %></td>
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
