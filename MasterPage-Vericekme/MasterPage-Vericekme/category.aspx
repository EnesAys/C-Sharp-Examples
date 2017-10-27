<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="MasterPage_Vericekme.category" %>
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
                                    <th class="head0">Kategori ID</th>
                                    <th class="head1">Kategori Adi</th>
                                    <th class="head0">Açıklama</th>
                             
                               
                                </tr>
                            </thead>
                               <tbody>
                        </HeaderTemplate>                         
                        <ItemTemplate>
                                <tr>
                                    <td><%#Eval("CategoryID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("CategoryName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("CategoryName") %>' 
                                            ID="lnkTedarik"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("Description") %></td>
                                  
                            
                                </tr>          
                        </ItemTemplate> 
                        <AlternatingItemTemplate>
                                <tr style="background-color:blanchedalmond">
                                    <td><%#Eval("CategoryID") %></td>
                                    <td>
                                        <asp:LinkButton 
                                            Text='<%#Eval("CategoryName") %>'
                                            CommandName="google"
                                            CommandArgument='<%#Eval("CategoryName") %>' 
                                            ID="lnkUrun"                                               
                                            runat="server"
                                            >
                                        </asp:LinkButton>
                                    </td>
                                    <td><%#Eval("Description") %></td>
                               
                                   
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
