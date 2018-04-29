using System;
using System.IO;
using System.Net;
using System.Text;

namespace HTTPWebRequestCS
{
    internal class WebRequestHelper
    {
        private readonly WebRequest _request;
        private Stream _dataStream;

        public WebRequestHelper(string url)
        {
            _request = WebRequest.Create(url);
        }

        public WebRequestHelper(string url, string method) : this(url)
        {
            if (method.Equals("GET") || method.Equals("POST"))
            {
                _request.Method = method;
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
            _request.ContentType = "application/x-www-form-urlencoded";
            _request.ContentLength = byteArray.Length;
            _dataStream = _request.GetRequestStream();
            _dataStream.Write(byteArray, 0, byteArray.Length);
            _dataStream.Close();
        }

        public string Status { get; set; }

        public string GetResponse()
        {
            WebResponse response = _request.GetResponse();
            Status = ((HttpWebResponse)response).StatusDescription;
            _dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(_dataStream ?? throw new InvalidOperationException());
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            _dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}