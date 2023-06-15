using LabiryntBackend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<Maze> getUserMazes(long id_user)
        {
            try
            {
                String request = "http://localhost:5194/api/Mazes/getUserMazes/" + id_user;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@request);
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                string content = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
                Debug.WriteLine(content);
                List<Maze> mazes = JsonSerializer.Deserialize<List<Maze>>(content);
                return mazes;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
        public User login(string login, string password)
        {
            try
            {
                String request = "http://localhost:5194/api/User/Login/" + login + "/" + password;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@request);
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                string content = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
                User newUser = JsonSerializer.Deserialize<User>(content);
                return newUser;
            }catch(Exception ex)
            {
                return null;
            }
           
        }

    }
    class dataSetter<T>
    {
        public dataSetter() { }
        public async Task<object> postContent(string link, T data)
        {
            
            String json = JsonSerializer.Serialize(data);
            using (var streamWriter = new HttpClient())
            {
                var response = await streamWriter.PostAsync("http://localhost:5194/api/" +link, new StringContent(json, Encoding.UTF8, "application/json"));
                if (response.StatusCode == HttpStatusCode.OK) { return response; } return null;
            }
        }
    }
}
