using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Crossover.Repository
{
    public class GithubRepository
    {
        public static object RepositoryList(int amount)
        {
            var url = $"https://api.github.com/repositories";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
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

                            JObject json = JObject.Parse(responseBody);
                            int count = 1;
                            List<object> listRepository = new List<object>();
                            foreach (var e in json)
                            {
                                if (count <= amount)
                                    //Console.WriteLine(e);
                                    listRepository.Add(e.ToString());
                                else
                                    break;
                                count++;
                            }

                            return listRepository;
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
