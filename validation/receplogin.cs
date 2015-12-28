using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace validation
{
    class receplogin
    {
        private string user_name = "";

        public string User_name
        {
            get { return user_name; }
            set {
                if (value.Length == 0)
                {
                    throw new Exception("Customer name is required");
                }
                if (value.Length > 20)
                {
                    throw new Exception("Value can not be greater than 20");
                }
                user_name = value; }
        }
        private string password = "";

        public string Password
        {
            get { return password; }
            set {
                if (value.Length == 0)
                {
                    throw new Exception("Value can not be empty");
                }
                if (value.Length < 5)
                {
                    throw new Exception("password must be greater than 4");
                }
                password = value; }
        }

        public void save()
        {
            /*Dataacress obj = new Dataacress();
            obj.Insertreceplogin(
                user_name,
                password);*/
        }
    }
}
