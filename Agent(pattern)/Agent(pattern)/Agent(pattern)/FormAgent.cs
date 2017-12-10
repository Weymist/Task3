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
        MessageForm form;

        public FormAgent(string fileName) : base(fileName)
        {
            form = new MessageForm();
        }

        public override void ReadMessage()
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

        public override void ShowMessage()
        {
            Application.EnableVisualStyles();
            form.messageList.Items.AddRange(messages.ToArray());
            Application.Run(form);
        }
    }
}
