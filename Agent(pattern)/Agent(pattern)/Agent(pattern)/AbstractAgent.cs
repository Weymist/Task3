using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Agent_pattern_
{
    abstract class  AbstractAgent //шаблон агента
    {
        public List<string> messages;
        public string fileName;

        public AbstractAgent(string fileName) //конструктор агента
        {
            this.fileName = fileName;
            messages = new List<string>();
        }

        public abstract void ReadMessage(); //абстрактный метод чтения

        public abstract void ShowMessage(); //абстрактный метод вывода
    }
}
