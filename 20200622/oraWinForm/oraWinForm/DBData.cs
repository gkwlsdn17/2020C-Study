using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraWinForm
{
    
    class DBData
    {
        string name;
        int age;
        string addr;

        public DBData(string name, int age, string addr)
        {
            this.name = name;
            this.age = age;
            this.addr = addr;
        }

        public string NAME { get { return name; } set { name = value; } }
        public int AGE { get { return age; } set { age = value; } }
        public string ADDR { get { return addr; } set { addr = value; } }
    }
}
