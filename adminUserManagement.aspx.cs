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
    public partial class adminUserManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        // DELETE BUTTON CLICK EVENT
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMemberByID();
        }


        // GO BUTTON CLICK EVENT
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getMemberByID();
        }


        // ACTIVATE BUTTON CLICK
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("active");
        }


        // PENDING BUTTON CLICK
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("pending");
        }


        // DEACTIVATE BUTTON CLICK
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("deactive");
        }


        // USER DEFINED FUNCTION
        bool checkIfMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from user_table where email='" + IDTextBox.Text.Trim() + "';", con);
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
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        // GET MEMBER BY EMAIL
        void getMemberByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from user_table where email='" + IDTextBox.Text.Trim() + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        fnTextBox.Text = dr.GetValue(0).ToString();
                        statusTextBox.Text = dr.GetValue(10).ToString();
                        lnTextBox.Text = dr.GetValue(1).ToString();
                        phoneNoTextBox.Text = dr.GetValue(2).ToString();
                        dobTextBox.Text = dr.GetValue(3).ToString();
                        stateTextBox.Text = dr.GetValue(4).ToString();
                        cityTextBox.Text = dr.GetValue(5).ToString();
                        pincodeTextBox.Text = dr.GetValue(6).ToString();
                        addressTextBox.Text = dr.GetValue(7).ToString();

                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid email');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        // UPDATE MEMBER STATUS
        void updateMemberStatusByID(string status)
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cmd = new SqlCommand("UPDATE user_table SET account_status='" + status + "' WHERE email='" + IDTextBox.Text.Trim() + "';", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('Member Status Updated');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }

        }

        // DELETE MEMBERS
        void deleteMemberByID()
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from user_table WHERE email='" + IDTextBox.Text.Trim() + "';", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Member Deleted Successfully');</script>");
                    clearForm();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }

        // CLEAR ENTRIES
        void clearForm()
        {
            IDTextBox.Text = "";
            fnTextBox.Text = "";
            lnTextBox.Text = "";
            dobTextBox.Text = "";
            phoneNoTextBox.Text = "";
            stateTextBox.Text = "";
            cityTextBox.Text = "";
            pincodeTextBox.Text = "";
            addressTextBox.Text = "";
            statusTextBox.Text = "";
        }

    }
}