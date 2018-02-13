using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Questioner
{
    public partial class Qsheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
            myConnection.Open();

            string query = "INSERT INTO [QnTable] (Type,Question) VALUES ('Objective','New Question')";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();

            //Label1.Text = reader["Question"].ToString();
            myConnection.Close();
        }
    }
}