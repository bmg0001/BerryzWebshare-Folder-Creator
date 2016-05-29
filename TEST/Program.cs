using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerryzWebshare_Folder;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            BerryzWebshare bz = new BerryzWebshare();
            bz.Create("http://127.0.0.1:8080/test/", "Hi",Int32.MaxValue);
        }
    }
}
