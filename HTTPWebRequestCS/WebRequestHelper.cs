using System;
using System.IO;
using System.Net;
using System.Text;

namespace HTTPWebRequestCS
{
    internal class WebRequestHelper
    {
        private WebRequest request;
        private Stream dataStream;

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public WebRequestHelper(string url)
        {
            request = WebRequest.Create(url);
        }

        public WebRequestHelper(string url, string method) : this(url)
        {
            if (method.Equals("GET") || method.Equals("POST"))
            {
                request.Method = method;
            }
            else
            {
                throw new Exception("Method tidak valid");
            }
        }

        public WebRequestHelper(string url, string method, string data) : this(url, method)
        {
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
        }

        public string GetResponse()
        {
            WebResponse response = request.GetResponse();
            this.Status = ((HttpWebResponse)response).StatusDescription;
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}