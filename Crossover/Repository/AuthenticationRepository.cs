using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Crossover.Repository
{
    public class AuthenticationRepository
    {
        public static void Registration()
        {
            var url = $"http://restapi.adequateshop.com/api/authaccount/registration";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"name\":\"'polo'\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }

        public static object Login(string email, string password)
        {
            var url = $"http://restapi.adequateshop.com/api/authaccount/login";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = $"{{\"email\":\"{email}\",\"password\":\"{password}\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return ex;
            }
        }

    }
}
