using System;
using System.IO;
using System.Net;

namespace CreepyBot.Utils
{
    class CHTrans
    {
        public CHTrans(){}
        public static string GET(string Url, string Data)
        {
            WebRequest req = WebRequest.Create(Url + Data);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }
    }

}
