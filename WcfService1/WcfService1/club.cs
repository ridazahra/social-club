using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class club
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        string contact_no;

        public string Contact_no
        {
            get { return contact_no; }
            set { contact_no = value; }
        }
        string qualification;

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        string working_category;

        public string Working_category
        {
            get { return working_category; }
            set { working_category = value; }
        }
        string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}