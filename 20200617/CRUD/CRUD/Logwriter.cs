using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Logwriter
    {
        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if (!di.Exists)
            {
                di.Create(); //폴더 생성
            }
            using (StreamWriter writer = new StreamWriter("LogFolder\\Log.txt",true))
            {
                
                writer.WriteLine(contents);
            }
        }
    }
}
