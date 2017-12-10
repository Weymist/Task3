using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Agent_pattern_
{
    class ConsoleAgent : AbstractAgent
    {
        public ConsoleAgent(string fileName): base(fileName)
        { }

        public override void ReadMessage()
        {
            StreamReader file = new StreamReader(fileName, Encoding.Default);
            try
            {
                string message =  file.ReadLine();
                while (message != null)
                {
                    messages.Add(message);
                    message = file.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                file.Close();
            }
        }

        public override void ShowMessage()
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
