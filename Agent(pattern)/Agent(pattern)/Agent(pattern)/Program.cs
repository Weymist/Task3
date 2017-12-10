using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agent_pattern_
{
    class Program
    {
        static AbstractAgent agent; //объявление агента
        static AgentFactory fabrica = AgentFactory.GetInstance(); //создание фабрики
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирете агента, обрабатывающего сообщения:" +
                "\n1-вывод в консоль" +
                "\n2-вывод на форму" +
                "\n3-вывод в консоль + запись в файл" +
                "\n4-вывод на форму + запись в файл");
            int agentType = Convert.ToInt32(Console.ReadLine());
            while (agentType > 4 || agentType < 1)
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку");
                agentType = Convert.ToInt32(Console.ReadLine());
            }
            switch (agentType) //выбор агента
            {
                case 1:
                    {
                        RunConsoleAgent();
                         break;
                    }
                case 2:
                    {
                        RunFormAgent();
                        break;
                    }
                case 3:
                    {
                        RunConsoleLogAgent();
                        break;
                    }
                case 4:
                    {
                        RunFormLogAgent();
                        break;
                    }
                default:
                    break;
            }         
            agent.ReadMessage();
            agent.ShowMessage();
            Console.ReadKey();
        }

        static void RunConsoleAgent() //конольный агент
        {
            agent = fabrica.CreateConsoleAgent("test.txt"); //инициализация агента
        }

        static void RunFormAgent() //форменный агент
        {
            agent = fabrica.CreateFormAgent("test.txt");
        }

        static void RunConsoleLogAgent() //консольный агент с выводом
        {
            agent = fabrica.CreateConsoleLogAgent("test.txt");
        }

        static void RunFormLogAgent() //форменный агент с выводом
        {
            agent = fabrica.CreateFormLogAgent("test.txt");
        }
    }
}
