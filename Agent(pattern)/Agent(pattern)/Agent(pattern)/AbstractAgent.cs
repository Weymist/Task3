using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Agent_pattern_
{
    abstract class  AbstractAgent
    {
        public List<string> messages;
        public string fileName;

        public AbstractAgent(string fileName)
        {
            this.fileName = fileName;
            messages = new List<string>();
        }

        public abstract void ReadMessage();

        public abstract void ShowMessage();
    }
}
