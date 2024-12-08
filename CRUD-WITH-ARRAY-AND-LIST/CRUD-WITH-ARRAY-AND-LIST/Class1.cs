using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WITH_ARRAY_AND_LIST
{
    internal class Class1
    {
        public string[] uname = new string[] { "", "", "" };
        public string[] level = new string[] { "", "", "" };
        public string[] pass = new string[] { "", "", "" };
        public string[] namanya = new string[] { "", "", "" };
        public string[] jk = new string[] { "", "", "" };
        public string[] email = new string[] { "", "", "" };
        public string[] nohp = new string[] { "", "", "" };
        public string[] indeksdata = new string[] { "", "", "" };

        public void dataqu(int index, string uname1, string level1, string pass1, string namanya1, string jk1, string email1, string nohp1)
        {
            uname[index] = uname1;
            level[index] = level1;
            pass[index] = pass1;
            namanya[index] = namanya1;
            jk[index] = jk1;
            email[index] = email1;
            nohp[index] = nohp1;
        }
    }
}
