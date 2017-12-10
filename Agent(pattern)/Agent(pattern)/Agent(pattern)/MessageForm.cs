using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agent_pattern_
{
    public partial class MessageForm : Form
    {
        public ListBox messageList = new ListBox();

        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            messageList.Location = new Point(5, 5);
            messageList.Size = new Size(Height - 40, Width - 40);
            Controls.Add(messageList);
        }
    }
}
