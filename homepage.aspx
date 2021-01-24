<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WestlakeInternatinalProject.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="container-fluid p-0">
            <div class="site-content">
                <div class="d-flex justify-content-center">
                    <div class="d-flex flex-column">
                        <h1 class="site-title">Asia Pacific International School</h1>
                        <p></p>
                    </div>
                </div>
            </div>
        </div>
        

        <div class="section-1">
            <div class="container text-center">
                <h2 class="heading-1" style="background-color: #16c2c4;">Available Books</h2>
                <p class="para-1">
                    We provide a free book facilities for the students of Asia Pacific International School. Students can view book and read book from where ever they are located at anytime.
                </p>

                <div class="row justify-content-center text-center">
                    <div class="col-md-4">
                        <div class="card" style="width:20rem;">
                            <img src="img/wallpaper/science.jpg" alt="Image1" class="card-img-top"/>
                            <div class="card-body">
                                <h4 p style="color: #16c2c4"">Science</h4>
                                
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 ">
                        <div class="card" style="width:20rem;">
                            <img src="img/wallpaper/math.jpg"alt="Image2" class="card-img-top"/>
                            <div class="card-body">
                                <h4 p style="color: #16c2c4">Math</h4>
                                
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                         <div class="card" style="width:20rem;">
                            <img src="img/wallpaper/social.jpg"alt="Image2" class="card-img-top"/>
                            <div class="card-body">
                                <h4 p style="color: #16c2c4">Social</h4>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
