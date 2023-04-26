using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LabiryntFrontend
{
    class dataGetter
    {
        public dataGetter() { }
        public string getContent(string link, List<string> args)
        {
            string argStr="";
            foreach (var arg in args)
            {
                argStr +="/"+arg;
            }
            String request = "http://localhost:5194/api/" + link + argStr;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@request);
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            string content = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            return content;
        }
        public string getContent(string link)
        {
            
            String request = "http://localhost:5194/api/" + link;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@request);
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            string content = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
            return content;
        }

    }
    class dataSetter<T>
    {
        public dataSetter() { }
        public async Task postContent(string link, T data)
        {
            
            String json = JsonSerializer.Serialize(data);
            using (var streamWriter = new HttpClient())
            {
                var response = await streamWriter.PostAsync("http://localhost:5194/api/" +link, new StringContent(json, Encoding.UTF8, "application/json"));

            }
        }
    }
}
