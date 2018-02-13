using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASSESSMENT
{
    public partial class ANSWER : System.Web.UI.Page

    {
        //protected int remainingtime;
        Sessiontablemethods mysession = new Sessiontablemethods();
        //string variable;
        ShowQtn myqtn = new ShowQtn();
        int cnt;
        //string selected_ans = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //string student = (string)(Session["stdno"]);
            //List<string> sessiondata = mysession.sessiontableinfo(student);
            //string remainingtimefromdb = sessiondata[0];
            //if (remainingtimefromdb == "0")
            //{
            //    remainingtime = 10;
            //}
            //remainingtime = int.Parse(remainingtimefromdb);
          
                


            


            // myerror.Text =variable ;
            submit.Visible = false;
            next.Visible = false;
            back.Visible = false;
            selectedansA.Visible = false;
            selectedansB.Visible = false;
            selectedansC.Visible = false;
            selectedansD.Visible = false;
            qtn.Visible = false;
            QTNO.Visible = false;

        }

       

        protected void next_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            next.Visible = true;
            selectedansA.Visible = true;
            selectedansB.Visible = true;
            selectedansC.Visible = true;
            selectedansD.Visible = true;
            qtn.Visible = true;
            QTNO.Visible = true;

           
            string student = Session["stdno"].ToString();
            int p = int.Parse(Session["count"].ToString());
            string selected_ans = "";
            if (selectedansA.Checked)
            {
                selected_ans = selectedansA.Text;
            }

            else if (selectedansB.Checked)
            {
                selected_ans = selectedansB.Text;
            }
            else if (selectedansC.Checked)
            {
                selected_ans = selectedansC.Text;
            }
            else if (selectedansD.Checked)
            {
                selected_ans = selectedansD.Text;
            }
            else
            {
                // error.Text = "Please select an answer";
            }
            string myresult = mysession.updatesessiontable(student, "", p, (p + 1), selected_ans);
            if (myresult == "updated")
            {
                try
                {
                    p++;
                    if (p == 19)
                    {
                        submit.Visible = true;
                        next.Visible = false;
                    }
                    //variable = hdnfldVariable.Value;
                    //int[] timeleft = variable.Split(':').Select(n => Convert.ToInt32(n)).ToArray();
                    //int time = (timeleft[0] * 60) + timeleft[1];
                    //Session["timeleft"] = time;
                    Session["count"] = p;
                    List<int> myrlist = (List<int>)Session["qtnlist"];
                   

                    if (p < myrlist.Count)
                    {
                       

                        string index1 = myrlist[p].ToString();
                        List<string> myquestion = myqtn.Showquestion(index1);
                        question.Text = myquestion[0];
                        selectedansA.Text = myquestion[1];
                        selectedansB.Text = myquestion[2];
                        selectedansC.Text = myquestion[3];
                        selectedansD.Text = myquestion[4];
                        cnt = int.Parse(Session["count"].ToString());
                        cnt = cnt + 1;
                        QTNO.Text = cnt.ToString() ;

                    }
                }

                catch (Exception err)
                {
                    string errors = err.ToString();
                    error.Text = "Out of Range";
                }
            }
            
        }

            protected void back_Click(object sender, EventArgs e)
        {
            selectedansA.Visible = true;
            selectedansB.Visible = true;
            selectedansC.Visible = true;
            selectedansD.Visible = true;
            next.Visible = true;
            back.Visible = true;
            qtn.Visible = true;
            QTNO.Visible = true;
            int p = int.Parse(Session["count"].ToString());
            List<int> myrlist = (List<int>)Session["qtnlist"];
            if (p < myrlist.Count)
            {
                try
                {
                    //variable = hdnfldVariable.Value;
                    //int[] timeleft = variable.Split(':').Select(n => Convert.ToInt32(n)).ToArray();
                    //int time = (timeleft[0] * 60) + timeleft[1];
                    //Session["timeleft"] = time;
                    p--;
                    Session["count"] = p;
                    //ShowQtn myqtn = new ShowQtn();
                    if (p == 0)
                    {
                        back.Visible = false;
                    }
                    string index1 = myrlist[p].ToString();
                    List<string> myquestion = myqtn.Showquestion(index1);
                    question.Text = myquestion[0];
                    selectedansA.Text = myquestion[1];
                    selectedansB.Text = myquestion[2];
                    selectedansC.Text = myquestion[3];
                    selectedansD.Text = myquestion[4];
                    cnt = int.Parse(Session["count"].ToString());
                    cnt = cnt + 1;
                    QTNO.Text = cnt.ToString();
                }
                catch (Exception err)
                {
                    string errors = err.ToString();
                    error.Text = "Out of range";
                }

            }
            else
            {

            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string student = Session["stdno"].ToString();
            int p = int.Parse(Session["count"].ToString());
            string selected_ans = "";
           
            if (selectedansA.Checked)
            {
                selected_ans = selectedansA.Text;
            }

            else if (selectedansB.Checked)
            {
                selected_ans = selectedansB.Text;
            }
            else if (selectedansC.Checked)
            {
                selected_ans = selectedansC.Text;
            }
            else if (selectedansD.Checked)
            {
                selected_ans = selectedansD.Text;
            }
            else
            {
                // error.Text = "Please select an answer";
            }
            string myresult = mysession.updatesessiontable(student,"", p, (p + 1), selected_ans);
            if (myresult == "updated")
            {
                try
                {

                    List<string> answers = mysession.sessionanswers(Session["stdno"].ToString()); //get the answers from the session
                    List<int> markinglist = (List<int>)Session["qtnlist"];// get session marking list
                    List<string> correctanswers = new List<string>(new string[] { });
                    string answer = "";
                    List<string> question = new List<string>();
                    int mark = 0;
                    for (int i = 0; i < 20; i++)
                    {

                        question = myqtn.Showquestion(markinglist[i].ToString());
                        answer = question[5];
                        correctanswers.Add(answer);
                    }


                    for (int i = 0; i < 20; i++)
                    {
                        if (answers[i] == correctanswers[i])
                        {
                            mark++;
                        }
                        else
                        {
                        }
                    }

                    string result = myqtn.updatemarks(Session["stdno"].ToString(), mark);
                    if (result == "done")
                    {
                        string myresults = mysession.deletefromsessiontable(Session["stdno"].ToString());
                        if (myresults == "deleted")
                        {

                            Session.Clear();
                            Response.Redirect("FINALPAGE.aspx");
                        }
                    }
                    else
                    {
                        error.Text = "Database Error - PLEASE CONTACT ADMINISTRATOR";
                    }
                }
                catch (Exception err)
                {
                    string errors = err.ToString();
                    error.Text = "Out of Range";
                }
            }
            else
            {

            }
            
        }

      

        protected void showfirstqtn_Click(object sender, EventArgs e)
        {
            back.Visible = true;
            next.Visible = true;
            selectedansA.Visible = true;
            selectedansB.Visible = true;
            selectedansC.Visible = true;
            selectedansD.Visible = true;
            qtn.Visible = true;
            QTNO.Visible = true;
            string student = (string)(Session["stdno"]);
            string result = mysession.checksessiontable(student);
            if (result == "exists")
            {
                List<int> newlist = new List<int>();
                List<string> sessiondata = mysession.sessiontableinfo(student);
                //string remainingtimefromdb = sessiondata[0];
                string qlist = sessiondata[1];
                string lqtn = sessiondata[2];
                int[] intarray = qlist.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                //Session["Timer"] = sessiondata[0];
                newlist = intarray.ToList();
                //variable =hdnfldVariable.Value;
                //int[] timeleft = variable.Split(':').Select(n => Convert.ToInt32(n)).ToArray();
                //int time = (timeleft[0] * 60) + timeleft[1];
                //Session["timeleft"] = time;
                //remainingtime = int.Parse(Session["timeelapsed"].ToString());
                Session["count"] = lqtn;
                Session["qtnlist"] = newlist;
                int i = int.Parse(Session["count"].ToString());
                List<int> myrlist = (List<int>)Session["qtnlist"];
                if (i < myrlist.Count)
                {
                    //ShowQtn myqtn = new ShowQtn();

                    string index1 = myrlist[i].ToString();
                    List<string> myquestion = myqtn.Showquestion(index1);
                    question.Text = myquestion[0];
                    selectedansA.Text = myquestion[1];
                    selectedansB.Text = myquestion[2];
                    selectedansC.Text = myquestion[3];
                    selectedansD.Text = myquestion[4];
                    //string correct_ans = myquestion[5];
                    Session["count"] = i;
                    if (i == 0)
                    {
                        back.Visible = false;
                    }
                    cnt = i + 1;
                    QTNO.Text = cnt.ToString();
                    showfirstqtn.Visible = false;
                }
                else
                {
                    error.Text = "Database Error - Please contact administrator";
                }





            }


        }

        //protected void timerTest_Tick(object sender, EventArgs e)
        //{
        //    if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timer"].ToString())) < 0)
        //    {
        //        litMsg.Text = "Time left: " + ((Int32)DateTime.Parse(Session["timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString() + "Minute: " + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString() + "Seconds: ";
        //    }
        //    else
        //    {
        //        litMsg.Text = "Time Expired";
        //    }
        //}
    }

}