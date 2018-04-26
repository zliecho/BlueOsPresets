using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PresetLibrary
{
    public class Class1
    {
        static public async Task Preset(int id)
        {
            try
            {

                string url = "http://192.168.0.10:11000/Preset?id=" + id;


                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
                request.ContentType = "application/json";
                request.Method = "GET";
                using (WebResponse response = await request.GetResponseAsync())
                {
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
