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
                        RunConsoleAgent(); //запуск агента, для вывода в консоль
                         break;
                    }
                case 2:
                    {
                        RunFormAgent(); //запуск агента, для вывода в форму
                        break;
                    }
                case 3:
                    {
                        RunConsoleLogAgent(); //запуск агента, для вывода в консоль и записи в файл
                        break;
                    }
                case 4:
                    {
                        RunFormLogAgent(); //запуск агента, для вывода в форму и записи в файл
                        break;
                    }
                default:
                    break;
            }         
            agent.ReadMessage(); //вызов метода чтения
            agent.ShowMessage(); //вызов метода вывода
            Console.ReadKey();
        }

        static void RunConsoleAgent() //конольный агент
        {
            agent = fabrica.CreateConsoleAgent("test.txt"); //инициализация агента
        }

        static void RunFormAgent() //форменный агент
        {
            agent = fabrica.CreateFormAgent("test.txt"); //инициализация агента
        }

        static void RunConsoleLogAgent() //консольный агент с выводом
        {
            agent = fabrica.CreateLogAgent("test.txt", "Console"); //инициализация агента
        }

        static void RunFormLogAgent() //форменный агент с выводом
        {
            agent = fabrica.CreateLogAgent("test.txt", "Form"); //инициализация агента
        }
    }
}
