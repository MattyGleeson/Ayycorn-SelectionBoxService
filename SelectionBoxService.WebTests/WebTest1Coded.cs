﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelectionBoxService.WebTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using LibAyycorn.Dtos;
    using Newtonsoft.Json;
    using System.Linq;

    public class WebTest1Coded : WebTest
    {
        private string json;
        private List<Giftbox> Boxes;
        private readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Ignore };


        public WebTest1Coded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
            json = System.IO.File.ReadAllText("../../../SelectionBoxService.WebTests/Data/selectionboxes.json");
            Boxes = JsonConvert.DeserializeObject<List<Giftbox>>(json, SerializerSettings);
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            WebTestRequest request1 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getboxes");
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            request2.Method = "POST";
            request2.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            StringHttpBody request2Body = new StringHttpBody();
            request2Body.ContentType = "application/json";
            request2Body.InsertByteOrderMark = false;
            request2Body.BodyString = JsonConvert.SerializeObject(Boxes.ElementAt(0));
            request2.Body = request2Body;
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getboxes");
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            request4.Method = "POST";
            request4.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            StringHttpBody request4Body = new StringHttpBody();
            request4Body.ContentType = "application/json";
            request4Body.InsertByteOrderMark = false;
            request4Body.BodyString = JsonConvert.SerializeObject(Boxes.ElementAt(0));
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request11 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            request11.Method = "POST";
            request11.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            request11.ExpectedHttpStatusCode = 500;
            StringHttpBody request11Body = new StringHttpBody();
            request11Body.ContentType = "application/json";
            request11Body.InsertByteOrderMark = false;
            request11.Body = request11Body;
            yield return request11;
            request11 = null;

            WebTestRequest request6 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getbox/1");
            yield return request6;
            request6 = null;

            WebTestRequest request7 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/updatebox/13");
            request7.Method = "PUT";
            request7.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            request7.ExpectedHttpStatusCode = 500;
            StringHttpBody request7Body = new StringHttpBody();
            request7Body.ContentType = "application/json";
            request7Body.InsertByteOrderMark = false;
            request7.Body = request7Body;
            yield return request7;
            request7 = null;

            WebTestRequest request8 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getbox/999999");
            request8.ExpectedHttpStatusCode = 204;
            yield return request8;
            request8 = null;

            WebTestRequest request9 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/deletebox/2");
            request9.Method = "DELETE";
            yield return request9;
            request9 = null;

            WebTestRequest request10 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/deletebox/999999");
            request10.Method = "DELETE";
            request10.ExpectedHttpStatusCode = 500;
            yield return request10;
            request10 = null;

            //WebTestRequest request5 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getboxes");
            //yield return request5;
            //request5 = null;

            //WebTestRequest request6 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            //request6.Method = "POST";
            //request6.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            //StringHttpBody request6Body = new StringHttpBody();
            //request6Body.ContentType = "application/json";
            //request6Body.InsertByteOrderMark = false;
            //request6Body.BodyString = JsonConvert.SerializeObject(Boxes.ElementAt(0));
            //request6.Body = request6Body;
            //yield return request6;
            //request6 = null;

            //WebTestRequest request7 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getboxes");
            //yield return request7;
            //request7 = null;

            //WebTestRequest request8 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            //request8.Method = "POST";
            //request8.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            //StringHttpBody request8Body = new StringHttpBody();
            //request8Body.ContentType = "application/json";
            //request8Body.InsertByteOrderMark = false;
            //request8Body.BodyString = JsonConvert.SerializeObject(Boxes.ElementAt(0));
            //request8.Body = request8Body;
            //yield return request8;
            //request8 = null;

            //WebTestRequest request9 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/getboxes");
            //yield return request9;
            //request9 = null;

            //WebTestRequest request10 = new WebTestRequest("http://ayycornselectionboxservice.azurewebsites.net/postbox");
            //request10.Method = "POST";
            //request10.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            //StringHttpBody request10Body = new StringHttpBody();
            //request10Body.ContentType = "application/json";
            //request10Body.InsertByteOrderMark = false;
            //request10Body.BodyString = JsonConvert.SerializeObject(Boxes.ElementAt(0));
            //request10.Body = request10Body;
            //yield return request10;
            //request10 = null;



        }
    }
}