using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Person
    {
        public String FirstName {  set; get; }
        public String LastName {  set; get; }

        public override string ToString()
        {
            return string.Format("FirstName: {0}, Lastname: {1}", FirstName, LastName);
        }
    }
}
