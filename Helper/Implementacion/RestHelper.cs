using Helper.Contrato;
using System.Net;

namespace Helper.Implementacion
{
    public class RestHelper : IRestHelper
    {
        public Task<string> consumirDelete(string URL)
        {
            throw new NotImplementedException();
        }

        public async Task<string> consumirGet(string URL)
        {

            var url = $"{URL}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = await request.GetResponseAsync())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = await objReader.ReadToEndAsync();
                            // Do something with responseBody
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;// Handle error
            }

        }

        public Task<string> consumirPost<T>(string URL, T objeto)
        {
            throw new NotImplementedException();
        }

        public Task<string> consumirPut<T>(string URL, T objeto)
        {
            throw new NotImplementedException();
        }
    }
}
