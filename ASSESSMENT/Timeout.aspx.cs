using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSESSMENT
{
    public partial class Timeout : System.Web.UI.Page
    {
        Sessiontablemethods mysession = new Sessiontablemethods();
        ShowQtn myqtn = new ShowQtn();
        protected void Page_Load(object sender, EventArgs e)
        {
            string student = Session["stdno"].ToString();
            int p = int.Parse(Session["count"].ToString());
            string selected_ans = "";

           
            string myresult = mysession.updatesessiontable(student, "", p, (p + 1), selected_ans);
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

    }
}
