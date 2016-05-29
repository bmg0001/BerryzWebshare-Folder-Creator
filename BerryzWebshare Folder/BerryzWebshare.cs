using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinHttp;

namespace BerryzWebshare_Folder
{
    public class BerryzWebshare
    {
        public void Create(string HttpAddress,string FolderName, int count)
        {
            if (HttpAddress.IndexOf("http") > -1 | HttpAddress.IndexOf("https") > -1)
            {
                Random rr = new Random();
                WinHttpRequest wt = new WinHttpRequest();
                for (int i=0; i<count; i++)
                {
                    wt.Open("GET", HttpAddress + "?action=MakeDirectory&name=" + FolderName + "_" + DateTime.Now.ToString("mmssff"));
                    wt.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/" + rr.Next(0, 8088));
                    wt.SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                    wt.SetRequestHeader("Accept-Language", "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4");
                    wt.SetRequestHeader("Referer", HttpAddress);
                    wt.Send();
                    Console.WriteLine("[{0}/{1}] SendOK.",i,count);
                }
            }
            else
            {
                throw new Exception("http 또는 https 를 포함해야 합니다.");
            }
        }
    }
}
