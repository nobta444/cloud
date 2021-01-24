<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="userSignup.aspx.cs" Inherits="WestlakeInternatinalProject.userSignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="p-2">
        <div class="container">
            <div class="row">
                <div class="col-md-6 mx-auto">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                           <img src="img/logo/signuplogo.png"  width="150px"/>
                        </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                           <h3>Member Sign Up</h3>
                        </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="firstNameTextBox" runat="server" placeholder="First Name"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="lastNameTextBox" runat="server" placeholder="Last Name"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="phoneNumberTextBox" runat="server" placeholder="Phone Number" TextMode="Phone"></asp:TextBox>
                                    </div>

                                     <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="userIdTextBox" runat="server" placeholder="User ID"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="dobTextBox" runat="server" placeholder="Date of Birth" TextMode="Date"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:DropDownList CssClass="form-control" ID="stateDropDownList" runat="server">
                                            <asp:ListItem Text="State" Value="State" />
                                            <asp:ListItem Text="Biratnagar Pradesh" Value="Province-1" />
                                            <asp:ListItem Text="Janakpur Pradesh" Value="Province-2" />
                                            <asp:ListItem Text="Bagmati Pradesh" Value="Province-3" />
                                            <asp:ListItem Text="Gandaki Pradesh" Value="Province-4" />
                                            <asp:ListItem Text="Butwal Pradesh" Value="Province-5" />
                                            <asp:ListItem Text="Karnali Pradesh" Value="Province-6" />
                                            <asp:ListItem Text="Sudurpashchim Pradesh" Value="Province-7" />
                                        </asp:DropDownList>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="cityTextBox" runat="server" placeholder="City"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="pincodeTextBox" runat="server" placeholder="Pincode" TextMode="Number"></asp:TextBox>
                                    </div>

                                     <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="fullAddressTextBox" runat="server" placeholder="Full Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="emailTextBox" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="passwordTextBox" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>

                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <asp:Button CssClass="btn btn-info btn-block btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click"  />
                                        <br />
                                        <a href="userLogin.aspx">Already have a account? Click to Sign in!</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <a href="homepage.aspx"><< Back to Home</a><br>
                    <br>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
