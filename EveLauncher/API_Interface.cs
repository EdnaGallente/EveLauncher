using System;
using System.Threading;
using System.Xml;
using System.Drawing;

namespace EveLauncher
{
    public static class API_Interface
    {
        public static int serverOpen = -1;
        public static string onlinePlayers = "0";
        public static Thread thread;
        private static MainWindow mainWindow;

        //called on startup
        public static void formManage(MainWindow mainWindowTemp)
        {
            mainWindow = mainWindowTemp;
        }

        public static void getServerStatusThreadSafe()
        {
            try {
                using (XmlTextReader xmlReader = new XmlTextReader("https://api.eveonline.com/Server/ServerStatus.xml.aspx"))
                {
                    bool stopServerOpen = false;
                    bool stopOnlinePlayers = false;

                    while (xmlReader.Read())
                    {

                        if (xmlReader.Name == "onlinePlayers" && stopOnlinePlayers == false)
                        {
                            xmlReader.Read();
                            onlinePlayers = xmlReader.Value;
                            stopOnlinePlayers = true;
                        }

                        if (xmlReader.Name == "serverOpen" && stopServerOpen == false)
                        {
                            xmlReader.Read();
                            if (xmlReader.Value.Equals("True"))
                            {
                                serverOpen = 1;
                            }
                            else if (xmlReader.Value.Equals("False"))
                            {
                                serverOpen = 0;
                            }
                            else
                            {
                                serverOpen = -2;
                            }

                            stopServerOpen = true;
                        }
                    }

                }
            }
            catch (Exception error)
            {
                int serverOpen = -1;
                Console.WriteLine(error);
            }

            updateMainFormThreadSafe();

            thread.Abort();
        }

        private static void updateMainFormThreadSafe()
        {
            Action actionOnlinePlayers = () => mainWindow.onlinePlayers.Text = onlinePlayers + " Players";
            mainWindow.onlinePlayers.Invoke(actionOnlinePlayers);

            string tqStatus = "";

            Action actionserverOpenColor = () => mainWindow.tqStatus.ForeColor = Color.Red;

            switch (serverOpen)
            {
                case -2:
                    tqStatus = "(Something really bad happened)";
                    actionserverOpenColor = () => mainWindow.tqStatus.ForeColor = Color.Red;
                    break;
                case -1:
                    tqStatus = "(Api Error)";
                    actionserverOpenColor = () => mainWindow.tqStatus.ForeColor = Color.Red;
                    break;
                case 0:
                    tqStatus = "(Offline)";
                    actionserverOpenColor = () => mainWindow.tqStatus.ForeColor = Color.Red;
                    break;
                case 1:
                    tqStatus = "(Online)";
                    actionserverOpenColor = () => mainWindow.tqStatus.ForeColor = Color.ForestGreen;
                    break;
            }
                

            Action actionserverOpen = () => mainWindow.tqStatus.Text = tqStatus;
            mainWindow.onlinePlayers.Invoke(actionserverOpenColor);
            mainWindow.onlinePlayers.Invoke(actionserverOpen);

        }



        public static void getSeverStatus()
        {

            thread = new Thread(getServerStatusThreadSafe);
            thread.Start();



        }
    }
}
