using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkingForms
{
    public partial class Form2 : Form
    {
        private Form1 mainForm { get; set; }
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            //richTextBox1.Text = mainForm.RTB_Text;
        }
        public void asd()
        {
            richTextBox1.Text = mainForm.RTB_Text;
        }
    }
}
