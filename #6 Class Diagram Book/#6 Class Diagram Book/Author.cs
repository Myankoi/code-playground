using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Class_Diagram_Book
{
    public class Author
    {
        private string name, email;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string toString()
        {
            return $"Author[name={getName()}, email={getEmail()}]"; 
        }
    }
}
