using System.Security.Cryptography;

namespace TalkingForms
{
    public partial class Form1 : Form
    {
        Form2 frm;
        public Form1()
        {
            InitializeComponent();
            frm = new Form2(this);
            frm.Show();

            richTextBox1.TextChanged += RichTextBox1_TextChanged;
        }

        private void RichTextBox1_TextChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            RTB_Text = richTextBox1.Text;
            frm.asd();
        }

        public string RTB_Text
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
    }
}
