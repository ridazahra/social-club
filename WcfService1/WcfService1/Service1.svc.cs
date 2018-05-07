using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void add(string name, string password, string question, string answer)
        {
            user k=new user();
            k.Name = name;
            k.Password = password;
            k.Question = question;
            k.Answer = answer;
            userdl.myuser.Add(k);
        }
       public  bool search(string name, string password)
        {
            bool isfound = false;
            foreach (user u in userdl.myuser)
            {
                if (u.Name == name && u.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
       public bool change_password(string q, string a,string p)
       {
           bool isfound = false;
           foreach (user u in userdl.myuser)
           {
               if (u.Question==q&&  u.Answer==a)

               {
                   isfound = true;
                   u.Password = p;

               }
           }
           return isfound;
       }
       public void add_category(string name, string cat,string q, string cn, string working, string g)
       {
           club u=new club();
           u.Name = name;
           u.Category = cat;
           u.Contact_no = cn;
           u.Working_category = working;
           u.Gender = g;
           userdl.myclub.Add(u);

       }
      public bool isadmin(string name, string password)
       {
           bool isfound = false;
           if (Admin.name == name && Admin.password == password)
           {
               isfound = true; 
           }
          
           return isfound;
       }
      public List<club> search_servant(string category)
      { 
          List<club> C=new List<club>();
          foreach (club u in userdl.myclub)
          {
              if (u.Category == category)
              {
                  C.Add(u);
              }
          }
          return C;
      }
      public bool change(string name,string password, string key)
      {
          bool correct = false;
          if (name == Admin.name && Admin.key == key)
          {
              Admin.password = password;
              correct = true;
          }
          return correct;
      
      }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
