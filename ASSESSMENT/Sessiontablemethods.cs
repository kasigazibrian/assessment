using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASSESSMENT
{
    public class Sessiontablemethods
    {
        public string insertintosessiontabel(string stdno, string remainingtime, List<int> qlist, string qtn1, string qtn2, string qtn3, string qtn4, string qtn5, string qtn6, string qtn7, string qtn8, string qtn9, string qtn10, string qtn11, string qtn12, string qtn13, string qtn14, string qtn15, string qtn16, string qtn17, string qtn18, string qtn19, string qtn20, string lqtn)
        {
            try
            {
                string myvalues = string.Join(",", qlist.ToArray());
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
                myConnection.Open();

                string query = "INSERT INTO sessionTable";
                query += " (studentno, remainingtime, QList, QTN1, QTN2, QTN3, QTN4, QTN5, QTN6, QTN7, QTN8, QTN9, QTN10, QTN11, QTN12, QTN13, QTN14, QTN15, QTN16, QTN17, QTN18, QTN19, QTN20, LQTN) VALUES(";
                query += "\'" + stdno + "\',";
                query += "\'" + remainingtime + "\',";
                query += "\'" + myvalues + "\',";
                query += "\'" + qtn1 + "\',";
                query += "\'" + qtn2 + "\',";
                query += "\'" + qtn3 + "\',";
                query += "\'" + qtn4 + "\',";
                query += "\'" + qtn5 + "\',";
                query += "\'" + qtn6 + "\',";
                query += "\'" + qtn7 + "\',";
                query += "\'" + qtn8 + "\',";
                query += "\'" + qtn9 + "\',";
                query += "\'" + qtn10 + "\',";
                query += "\'" + qtn11 + "\',";
                query += "\'" + qtn12 + "\',";
                query += "\'" + qtn13 + "\',";
                query += "\'" + qtn14 + "\',";
                query += "\'" + qtn15 + "\',";
                query += "\'" + qtn16 + "\',";
                query += "\'" + qtn17 + "\',";
                query += "\'" + qtn18 + "\',";
                query += "\'" + qtn19 + "\',";
                query += "\'" + qtn20 + "\',";
                query += "\'" + lqtn + "\'";
                query += ")";

                SqlCommand cmd = new SqlCommand(query, myConnection);
                cmd.ExecuteNonQuery();
                myConnection.Close();

                return "successfullyadded";
            }
            catch (Exception Err)
            {
                string error = Err.ToString();
                return "dberror";
               
            }
        }


        public string updatesessiontable(string stdno, string remainingtime, int lqtn, int qtncount, string ans)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
                myConnection.Open();

                string query = "UPDATE sessionTable SET remainingtime=@remainingtime, QTN"+qtncount+"=@ans, LQTN=@lqtn WHERE studentno=@stdno";
               
                SqlCommand cmd = new SqlCommand(query, myConnection);
                cmd.Parameters.AddWithValue("@remainingtime", remainingtime);
                cmd.Parameters.AddWithValue("@ans", ans);
                cmd.Parameters.AddWithValue("@lqtn", lqtn);
                cmd.Parameters.AddWithValue("@stdno", stdno);
                cmd.ExecuteNonQuery();
                

                
                myConnection.Close();

                return "updated";
            }
            catch (Exception err)
            {
                string error = err.ToString();
                return "dberror";
            }
        }

        public string deletefromsessiontable(string stdno)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
                myConnection.Open();

                string query = "DELETE FROM sessionTable WHERE studentno='" + stdno + "'";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
                myConnection.Close();

                return "deleted";
            }
            catch (Exception err)
            {
                string error = err.ToString();
                return "dberror";
            }
        }
        public string checksessiontable(string stdno)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";


                myConnection.Open();

                string validateQuery = "SELECT COUNT(*) AS Expr1 FROM sessionTable WHERE (studentno =" + "\'" + stdno + "\')";
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
            }
            catch (Exception err)
            {
                string error = err.ToString();
                return "dberror";
            }


        }
        public List<string> sessionanswers(string stdno)
        {
            List<string> error = new List<string>();
            try
            {
                List<string> sessionans = new List<string>();
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";


                myConnection.Open();
                string query = "SELECT [remainingtime],[QList],[QTN1],[QTN2],[QTN3],[QTN4],[QTN5],[QTN6],[QTN7],[QTN8],[QTN9],[QTN10],[QTN11],[QTN12],[QTN13],[QTN14],[QTN15],[QTN16],[QTN17],[QTN18],[QTN19],[QTN20],[LQTN] FROM [sessionTable] WHERE studentno=" + stdno + "";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string QTN1 = reader["QTN1"].ToString();
                string QTN2 = reader["QTN2"].ToString();
                string QTN3 = reader["QTN3"].ToString();
                string QTN4 = reader["QTN4"].ToString();
                string QTN5 = reader["QTN5"].ToString();
                string QTN6 = reader["QTN6"].ToString();
                string QTN7 = reader["QTN7"].ToString();
                string QTN8 = reader["QTN8"].ToString();
                string QTN9 = reader["QTN9"].ToString();
                string QTN10 = reader["QTN10"].ToString();
                string QTN11 = reader["QTN11"].ToString();
                string QTN12 = reader["QTN12"].ToString();
                string QTN13 = reader["QTN13"].ToString();
                string QTN14 = reader["QTN14"].ToString();
                string QTN15 = reader["QTN15"].ToString();
                string QTN16 = reader["QTN16"].ToString();
                string QTN17 = reader["QTN17"].ToString();
                string QTN18 = reader["QTN18"].ToString();
                string QTN19 = reader["QTN19"].ToString();
                string QTN20 = reader["QTN20"].ToString();
               
                sessionans.Add(QTN1);
                sessionans.Add(QTN2);
                sessionans.Add(QTN3);
                sessionans.Add(QTN4);
                sessionans.Add(QTN5);
                sessionans.Add(QTN6);
                sessionans.Add(QTN7);
                sessionans.Add(QTN8);
                sessionans.Add(QTN9);
                sessionans.Add(QTN10);
                sessionans.Add(QTN11);
                sessionans.Add(QTN12);
                sessionans.Add(QTN13);
                sessionans.Add(QTN14);
                sessionans.Add(QTN15);
                sessionans.Add(QTN16);
                sessionans.Add(QTN17);
                sessionans.Add(QTN18);
                sessionans.Add(QTN19);
                sessionans.Add(QTN20);
                reader.Close();
                myConnection.Close();

            return sessionans;
            }
            catch (Exception err)
            {
                error.Add("dberror");

               string erro = err.ToString();
               return error;
            }
        }
        public List<string> sessiontableinfo(string stdno)
        {
            List<string> error = new List<string>();
            try
            {
                List<string> sessiondata = new List<string>();
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";


                myConnection.Open();
                string query = "SELECT [remainingtime],[QList],[QTN1],[QTN2],[QTN3],[QTN4],[QTN5],[QTN6],[QTN7],[QTN8],[QTN9],[QTN10],[QTN11],[QTN12],[QTN13],[QTN14],[QTN15],[QTN16],[QTN17],[QTN18],[QTN19],[QTN20],[LQTN] FROM [sessionTable] WHERE studentno=" + stdno + "";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                string remainingtime = reader["remainingtime"].ToString();
                string Qlist = reader["QList"].ToString();
                string LQTN = reader["LQTN"].ToString();
                reader.Close();
                myConnection.Close();
                sessiondata.Add(remainingtime);
                sessiondata.Add(Qlist);
                sessiondata.Add(LQTN);

                return sessiondata;
            }
            catch(Exception err)
            {
                string erro = err.ToString();
                error.Add("dberror");
                return error;
            }
        }
    }
}