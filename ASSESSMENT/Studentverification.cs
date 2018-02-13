using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASSESSMENT
{
    public class Studentverification
    {
        public string studentverify(string stdno)
        {
            try
            {

                //Session["name"] = studentName.Text;
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";


                myConnection.Open();

                string validateQuery = "SELECT COUNT(*) AS Expr1 FROM Tally WHERE (StdNo =" + "\'" + stdno + "\')";
                SqlCommand validateCmd = new SqlCommand(validateQuery, myConnection);
                SqlDataReader validateReader;
                validateReader = validateCmd.ExecuteReader();
                validateReader.Read();
                string count = validateReader["Expr1"].ToString();
                validateReader.Close();
                int x = Convert.ToInt32(count);
                if (x == 0)
                {
                    return "absent";
                  
                }
                else
                {
                   
                    return "exists";
                  
                }
                //myConnection.Close();
            }
            catch (Exception Err)
            {
                string errors = Err.ToString();
                return "dberror";
                //string errors = Err.ToString();
                // MailDefinition errored = new MailDefinition();
                // errored.Subject = "ISA Error";


            }

            

        }
    }
}