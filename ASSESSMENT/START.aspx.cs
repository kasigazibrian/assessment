using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSESSMENT
{
    public partial class START : System.Web.UI.Page
    {
        Studentverification verifystudent = new Studentverification();
        Sessiontablemethods verifysession = new Sessiontablemethods();
        random myrandom = new random();
        List<int> myrlist = new List<int>();
        int a = 7;
        int b = 26;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void start_ServerClick(object sender, EventArgs e)
        {
            if (stdno.Text == "") error.Text = "*Student Name is Required*";
            else if (regno.Text == "") error.Text = "*Registration Number is Required*";
            else if (stdname.Text == "") error.Text = "*Student Number is Required*";
            else { 
            string studentnumber = stdno.Text;
            string registrationnumber = regno.Text;
            string studentname = stdname.Text;
            string studentcourse = course.SelectedValue;
            string studentyear = year.SelectedValue;
            string result = verifystudent.studentverify(studentnumber);
            string myresults = verifysession.checksessiontable(studentnumber);
            if (result == "absent")
            {
                    if (myresults == "absent")
                    {
                       
                         Session["counter"] = 0;
                         Session["myrlist"] = myrandom.randomnumber(a, b);
                      // Session["timer"] = InitTimer(30); ;

                        
                        myrlist = (List<int>)Session["myrlist"];
                        Session["stdno"] = studentnumber;

                        string inserted = verifysession.insertintosessiontabel(Session["stdno"].ToString(), "", myrlist, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", Session["counter"].ToString());
                        studentinsert myinsert = new studentinsert();
                        string myresult = myinsert.insertstudent(studentnumber, registrationnumber, studentname, studentcourse, studentyear);
                        if (myresult == "success")
                        {

                            Response.Redirect("ANSWER.aspx");

                        }
                        else
                        {
                            error.Text = "Error accessing Database- Try Again or Contact Administrator";
                        }
                    }
            }
            else if (result == "exists")
            {
                error.Text = "Student record already exists!";
            }
            else if (result == "dberror")
            {
                error.Text = "Error accessing Database- Try Again or Contact Administrator";
            }
            else
            {
                error.Text = "Error accessing Database- Try Again or Contact Administrator";
            }
            }
        }

        protected void continue_ServerClick(object sender, EventArgs e)
        {

            
            string studentnumber = stdno.Text;
            string registrationnumber = regno.Text;
            string studentname = stdname.Text;
            string studentcourse = course.SelectedValue;
            string studentyear = year.SelectedValue;
            string checktallytable = verifystudent.studentverify(studentnumber);
            string checksessiontable = verifysession.checksessiontable(studentnumber);

            if (checktallytable == "exists")
            {
                if (checksessiontable == "exists")
                {

                    
                    Session["stdno"] = studentnumber;
                    Response.Redirect("ANSWER.aspx");

                    
                   
                }
                else if (checksessiontable == "absent")
                {
                    error.Text = "You have already completed the assessment!";
                }
                else
                {
                    error.Text = "Error accessing Database- Try Again or Contact Administrator";
                }
            }
            else if(checktallytable=="absent")
            {
                error.Text = "Please enter your details to start the lab assessment!";
            }
            else
            {
                error.Text = "Error accessing Database- Try Again or Contact Administrator";
            }
            
        }
       

    }
}