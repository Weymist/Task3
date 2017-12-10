using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    class AgentFactory
    {
        private static AgentFactory instance;

        private AgentFactory()
        { }

        public ConsoleAgent CreateConsoleAgent(string param)
        {
            return new ConsoleAgent(param);
        }

        public FormAgent CreateFormAgent(string param)
        {
            return new FormAgent(param);
        }

        public AbstractAgent CreateConsoleLogAgent(string param)
        {
            AbstractAgent agent = new  ConsoleAgent(param);
            agent = new AgentDecorator(agent.fileName, agent);
            return agent;
        }

        public AbstractAgent CreateFormLogAgent(string param)
        {
            AbstractAgent agent = new FormAgent(param);
            agent = new AgentDecorator(agent.fileName, agent);
            return agent;
        }

        public static AgentFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new AgentFactory();
            }
            return instance;
        }
    }
}
