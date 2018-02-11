using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OGbot
{
    class Program
    {
        static void Main(string[] args)
        {
            string myParameters = "login=scotty.klei@gmail.com&pass=Avignale3&s149-en.ogame.gameforge.com";
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application / x - www - form - urlencoded";
                client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36";
                client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                client.Headers[HttpRequestHeader.Referer] = "https://en.ogame.gameforge.com/";
                client.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate, br";
                client.Headers[HttpRequestHeader.AcceptLanguage] = "en-US,en;q=0.9";



                string htmlReturned = 
            }
        }
    }
}
