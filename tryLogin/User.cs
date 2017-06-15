using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryLogin
{
    class User
    {

        private String name;

        private String lastName;

        private String document;

        private String customer;

        private String pass;

        public User(string name, string lastName, string document, string user, string pass)
        {
            this.name = name;
            this.lastName = lastName;
            this.document = document;
            this.customer = user;
            this.pass = pass;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Document { get => document; set => document = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
