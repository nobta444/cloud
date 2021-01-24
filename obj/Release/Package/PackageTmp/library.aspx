<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="library.aspx.cs" Inherits="WestlakeInternatinalProject.library" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container p-4">
        <div class="row">

            <div class="col-sm-12">
               
                <div class="row">
                    <div class="col-sm-12 col-md-12">
                        <asp:Panel class="alert alert-success" role="alert" ID="Panel1" runat="server" Visible="False">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </asp:Panel>
                    </div>
                </div>
                <br />
                <div class="row">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4 Students Books</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:westlake_schoolDBConnectionString %>" SelectCommand="SELECT * FROM [book_inventory_table]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" style="background-color: #16c2c4;" runat="server" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="SqlDataSource1">
                           <Columns>
                              <asp:BoundField DataField="book_id" HeaderText="ID" ReadOnly="True" SortExpression="book_id" >
                               <ItemStyle Font-Bold="True" Font-Size="Medium" />
                              </asp:BoundField>
                               


                               <asp:TemplateField>

                                   <ItemTemplate>
                                       <div class="container-fluid p-2">
                                   <div class="row">
                                       <div class="col-lg-3">
                                           <asp:Image CssClass="img-fluid" ID="Image1" runat="server" ImageUrl='<%# Eval("book_img_link") %>' />
                                       </div>

                                       <div class="col-lg-9">
                                           <div class="row ">
                                               <div class="col-12">
                                                   <asp:Label ID="Label1" runat="server" Text='<%# Eval("book_name") %>' Font-Bold="True" Font-Size="Larger"></asp:Label>
                                               </div>
                                           </div>
                                           <hr />
                                           <div class="row">
                                               <div class="col-12">

                                                   Author -
                                                   <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("author_name") %>'></asp:Label>
                                                   &nbsp;|&nbsp; Genre -
                                                   <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("genre") %>'></asp:Label>
                                                   &nbsp;| Language -
                                                   <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("language") %>'></asp:Label>

                                               </div>
                                           </div>

                                           <div class="row">
                                               <div class="col-12">

                                                   Publisher -
                                                   <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("publisher_name") %>'></asp:Label>
                                                   &nbsp;| Publish Date -
                                                   <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("publish_date") %>'></asp:Label>
                                                   &nbsp;| Edition -
                                                   <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("edition") %>'></asp:Label>

                                               </div>
                                           </div>

                                           <div class="row">
                                               <div class="col-12">

                                                   Actual Stock -
                                                   <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("actual_stock") %>'></asp:Label>
                                                   &nbsp;| Available -
                                                   <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Small" Text='<%# Eval("current_stock") %>'></asp:Label>

                                               </div>
                                           </div>

                                           <hr />

                                           <div class="row">
                                               <div class="col-12">

                                                   Description -
                                                   <asp:Label ID="Label10" runat="server" Text='<%# Eval("book_description") %>'></asp:Label>
                                               </div>
                                           </div>
                                       </div>
                                   </div>
                               </div>
                                   </ItemTemplate>

                               </asp:TemplateField>
                           </Columns>
                        </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
