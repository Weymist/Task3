using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    /*abstract*/ class AgentDecorator : AbstractAgent
    {
        protected AbstractAgent agent;
        protected StreamWriter logFile = new StreamWriter("log.txt");

        public  AgentDecorator(string fileName, AbstractAgent agent) : base(fileName)
        {
            this.agent = agent;
        }

        public override void ReadMessage()
        {
            agent.ReadMessage();
        }

        public override void ShowMessage()
        {
            LogMessage();
            agent.ShowMessage();
        }

        protected void LogMessage()
        {
            string logFileContent = "";
            try
            {
                foreach (string message in agent.messages)
                {
                    logFileContent += message + "\r\n";
                }
                logFile.WriteLine(logFileContent);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                logFile.Close();
            }
        }
    }
}
