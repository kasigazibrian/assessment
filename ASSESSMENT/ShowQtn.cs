using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ASSESSMENT
{
    public class ShowQtn
    {
        public List<string> Showquestion(string index)
        {
          try
            { 
            string Qtn,AnswerA,AnswerB,AnswerC,AnswerD,correctAnswer = "";
            List<string> Question = new List<string>();
            string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
            SqlConnection myConn = new SqlConnection(connectionstring);
            myConn.Open();

            string query = "SELECT [Type],[Question],[AnswerA],[AnswerB],[AnswerC],[AnswerD],[AnswerFinalObj] FROM [QnTable] WHERE No=" + index + "";
            SqlCommand cmd = new SqlCommand(query, myConn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();

            Qtn = reader["Question"].ToString();
            string t = reader["Type"].ToString();
            if (t == "Objective")
            {
                AnswerA = reader["AnswerA"].ToString();
                AnswerB = reader["AnswerB"].ToString();
                AnswerC = reader["AnswerC"].ToString();
                AnswerD = reader["AnswerD"].ToString();
                correctAnswer = reader["AnswerFinalObj"].ToString();
                Question.Add(Qtn);
                Question.Add(AnswerA);
                Question.Add(AnswerB);
                Question.Add(AnswerC);
                Question.Add(AnswerD);
                Question.Add(correctAnswer);

            }
            else if (t == "Input")
            {
               
            }
            else
            {
               
                AnswerA = reader["AnswerA"].ToString();
                AnswerB = reader["AnswerB"].ToString();
                AnswerC = reader["AnswerC"].ToString();
                AnswerD = reader["AnswerD"].ToString();
                correctAnswer = reader["AnswerFinalObj"].ToString();

                Question.Add(Qtn);
                Question.Add(AnswerA);
                Question.Add(AnswerB);
                Question.Add(AnswerC);
                Question.Add(AnswerD);
                Question.Add(correctAnswer);

            }


            reader.Close();
            myConn.Close();

            return Question;
            }
            catch(Exception errors)
            {
                string err = errors.ToString();
                string er = "";
                List<string> myerrors = new List<string>();
                myerrors.Add(er);
                return myerrors;
            }
        }
        public string updatemarks(string stdno, int marks)
        {
            try
            {
                string connectionstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Questions.mdf;Integrated Security=True;User Instance=True";
                SqlConnection myConn = new SqlConnection(connectionstring);
                myConn.Open();
                string query = "UPDATE Tally SET Mark=@marks WHERE StdNo=@studentno";
                SqlCommand cmd = new SqlCommand(query, myConn);
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@studentno", stdno);
                cmd.ExecuteNonQuery();
                myConn.Close();
                return "done";
            }
            catch (Exception err)
            {
                string errors = err.ToString();
                return "dberror";
            }
        }

    }
}