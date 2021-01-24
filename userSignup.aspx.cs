using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WestlakeInternatinalProject
{
    public partial class userSignup : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // SIGNUP BUTTON CLICK EVENT
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check if same user exists
            if (checkUserExists())
            {
                Response.Write("<script>alert('Member Already Exist with this Email ID, try other Email ID');</script>");

            }
            else
            {
                signUpNewUser();
            }
        }


        // USER DEFINED METHODS


        // CHECK IF USER EXISTS
        bool checkUserExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from user_table where user_id='" + userIdTextBox.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + "');</script>");
                return false;
            }
        }

        // SIGN UP METHOD

        void signUpNewUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO user_table(first_name, last_name, phone_number, user_id, dob, state, city, pincode, full_address, email, password) VALUES (@first_name, @last_name, @phone_number, @user_id, @dob, @state, @city, @pincode, @full_address, @email, @password)", con);

                cmd.Parameters.AddWithValue("@first_name", firstNameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@last_name", lastNameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", phoneNumberTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@user_id", userIdTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", dobTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@state", stateDropDownList.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", cityTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", pincodeTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", fullAddressTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text.Trim());
                

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Sign Up Successful. You can Login now');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + "');</script>");
            }
        }

    }
}