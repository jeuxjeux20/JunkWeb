﻿//JunkWeb Client by Cth103
//this following program is a test. feel free to edit it anytime.
//START CODE
//Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;

namespace Junk_Web_Client
{
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            Console.WriteLine("Switching ip...");
             while (true) //Loop
            {
                //jump to dead ip address :) so much junk
                Random rnd = new Random();
                string[] ip = new string[] { "https://81.196.2.213:80/", "https://203.66.159.44:80/", "https://123.57.190.51:80/","https://123.57.190.51:80/" };
                string res = ip[rnd.Next(ip.Length)];
                WebProxy proxyObject = new WebProxy(res);
                GlobalProxySelection.Select = proxyObject;
            }

            }
      
    }
     
}