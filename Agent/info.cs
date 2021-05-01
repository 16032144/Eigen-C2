using System;
using System.Diagnostics;
using System.Net;

namespace testc2
{
    class GeneralInfo
    {
        public string oSystem;
        public string uName;
        public string cDirectory;
        public string pName;
        public string ePath;
        public string ipv4Adress;
        public string hostName;
        public int pId;
        public bool isAdmin;

        public GeneralInfo(){

            oSystem = Environment.OSVersion.ToString();
            uName = Environment.UserName;
            cDirectory = Environment.CurrentDirectory;
            pName = Process.GetCurrentProcess().ProcessName;
            pId = Process.GetCurrentProcess().Id;
            hostName = Dns.GetHostName();
            ipv4Adress = Dns.GetHostByName(hostName).AddressList[0].ToString();
            using var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            isAdmin = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}
