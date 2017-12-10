using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Agent_pattern_
{
    class FormAgent : AbstractAgent
    {
        MessageForm form; //объявление формы

        public FormAgent(string fileName) : base(fileName) //инициализация формы и вызов базового конструктора
        {
            form = new MessageForm();
        }

        public override void ReadMessage() //чтение из файла
        {
            StreamReader file = new StreamReader(fileName, Encoding.Default);
            try
            {
                string message = file.ReadLine();
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

        public override void ShowMessage() //вывод сообщеения в форму
        {
            Application.EnableVisualStyles();
            form.messageList.Items.AddRange(messages.ToArray());
            Application.Run(form);
        }
    }
}
