using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WestlakeInternatinalProject
{
    public partial class index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((string)Session["role"]))
                {
                    LinkButton1.Visible = true; // user login link button
                    LinkButton2.Visible = true; // sign up link button

                    LinkButton3.Visible = false; // logout link button
                    LinkButton7.Visible = false; // hello user link button


                    LinkButton6.Visible = true; // admin login link button
                    //LinkButton11.Visible = false; // author management link button
                    LinkButton12.Visible = false; // publisher management link button
                    //LinkButton8.Visible = false; // book inventory link button
                    //LinkButton9.Visible = false; // book issuing link button
                   

                }
                else if (Session["role"].Equals("users"))
                {
                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // sign up link button
                    LinkButton5.Visible = true; // User Profile Button
                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton7.Text = "Hello " + Session["username"].ToString();


                    LinkButton6.Visible = false; // admin login link button
                    //LinkButton11.Visible = false; // author management link button
                    LinkButton12.Visible = false; // publisher management link button
                    //LinkButton8.Visible = false; // book inventory link button
                    //LinkButton9.Visible = false; // book issuing link button
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // user login link button
                    LinkButton2.Visible = false; // sign up link button
                    LinkButton5.Visible = false; // User Profile Button
                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton7.Text = "Hello Admin";

                    
                    LinkButton6.Visible = false; // admin login link button
                    //LinkButton11.Visible = true; // author management link button
                    LinkButton12.Visible = true; // Library management link button
                    //LinkButton8.Visible = true; // book inventory link button
                    //LinkButton9.Visible = true; // book issuing link button
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userSignup.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }


        // LOGOUT BUTTON 
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["first_name"] = "";
            Session["role"] = "";
            Session["status"] = "";


            LinkButton1.Visible = true; // user login link button
            LinkButton2.Visible = true; // sign up button
            LinkButton5.Visible = false; // User Profile Button
            LinkButton3.Visible = false; // logout button
            LinkButton7.Visible = false; // Hello user button

            LinkButton6.Visible = true;  // admin login button
            //LinkButton11.Visible = false; // Restaurant Management button
            LinkButton12.Visible = false; // Inventory Management button
            //LinkButton9.Visible = false; // Member Management button
            //LinkButton8.Visible = false; // Order Issuing button
           

            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("library.aspx");
        }


        
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminUserManagement.aspx");
        }


        // USER PROFILE
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
        }


        // 
        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLibrary.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminBookIsuue.aspx");
        }
    }
}