using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASSESSMENT
{
    public class AnswerQtn
    {

        public bool answer_question(string correctanswer , string selected_ans)
        {
          
            if(correctanswer == selected_ans)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
            
    }
}