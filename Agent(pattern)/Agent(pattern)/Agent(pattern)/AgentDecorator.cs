using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    class AgentDecorator : AbstractAgent
    {
        protected AbstractAgent agent; //поле класса агент
        protected StreamWriter logFile = new StreamWriter("log.txt"); //определение файла для вывода сообщения

        public  AgentDecorator(string fileName, AbstractAgent agent) : base(fileName) //конструктор агента
        {
            this.agent = agent;
        }

        public override void ReadMessage() //чтение сообщения из файла
        {
            agent.ReadMessage();
        }

        public override void ShowMessage() //вывод сообщения
        {
            LogMessage();
            agent.ShowMessage();
        }

        protected void LogMessage() //метод вывода сообщения в файл
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
