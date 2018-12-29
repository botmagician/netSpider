﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace netSpider
{
    public class netSpiderBase
    {
       
        public HttpWebResponse  getResponse(string URL, bool keepAlive, int timeOut, string method, string accept, string userAgent)
        {
            HttpWebRequest mywr = (HttpWebRequest)WebRequest.Create(URL);
            mywr.KeepAlive = keepAlive;
            mywr.Timeout = timeOut;
            mywr.Method = method;
            mywr.Accept = accept;
            mywr.UserAgent = userAgent;
            HttpWebResponse myrp = (HttpWebResponse)mywr.GetResponse();
            if (myrp.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }else{
            	return myrp;
            }
        }
    }
}