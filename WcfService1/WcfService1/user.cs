using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class user
    {

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string question;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}