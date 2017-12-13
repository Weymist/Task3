using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    class AgentFactory
    {
        private static AgentFactory instance; //ссылка на конкретный экземпляр данного объекта

        private AgentFactory() //конструктор
        { }

        public ConsoleAgent CreateConsoleAgent(string param)  //создание нового консольного агента
        {
            return new ConsoleAgent(param);
        }

        public FormAgent CreateFormAgent(string param) //создание нового форменного агента
        {
            return new FormAgent(param);
        }

        public AbstractAgent CreateLogAgent(string param, string type) //создание консольного/форменного агента с выводом в файл
        {
            AbstractAgent agent;
            if (type == "Console")
            {
                agent = new ConsoleAgent(param);
            }
            else
            {
                agent = new FormAgent(param);
            }            
            agent = new AgentDecorator(agent.fileName, agent);
            return agent;
        }
             
        public static AgentFactory GetInstance() //вызов конструктора для создания объекта 
        {
            if (instance == null)
            {
                instance = new AgentFactory();
            }
            return instance;
        }
    }
}
