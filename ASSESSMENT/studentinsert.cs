using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace ASSESSMENT
{
    public class studentinsert
    {
        public string insertstudent(string stdno, string regno, string stdname, string course, string year)
        {
            try
            {

                //Session["name"] = studentName.Text;
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";


                myConnection.Open();

                string query = "INSERT INTO Tally";
                query += " (Name, Reg, StdNo, Course) VALUES(";
                query += "\'" + stdname + "\',";
                query += "\'" + regno + "\',";
                query += "\'" + stdno + "\',";
                query += "\'" + course + " " + year + "\'";
                query += ")";

                SqlCommand cmd = new SqlCommand(query, myConnection);
                cmd.ExecuteNonQuery();
                myConnection.Close();
                return "success";
                


            }
            catch (Exception Err)
            {
                
                string error = Err.ToString();
                // MailDefinition errored = new MailDefinition();
                // errored.Subject = "ISA Error";

                return "dberror"; 

        }   }         
    }
}