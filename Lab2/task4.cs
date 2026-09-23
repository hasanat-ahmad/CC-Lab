using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sessional1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var = richTextBox1.Text;
            String[] words = var.Split(' ');

            Regex logicalRegex = new Regex(@"^(&&|\|\||!)$");
            Regex relationalRegex = new Regex(@"^([<>!=]=|[<>])$");
            Regex arithmeticRegex = new Regex(@"^(\+|-|\*|/|%)$");

            richTextBox2.Clear();
            richTextBox2.Text += "+------------+------------+\r\n";
            richTextBox2.Text += "| Token      | Category   |\r\n";
            richTextBox2.Text += "+------------+------------+\r\n";

            for (int i = 0; i < words.Length; i++)
            {
                Match logicalMatch = logicalRegex.Match(words[i]);
                Match relationalMatch = relationalRegex.Match(words[i]);
                Match arithmeticMatch = arithmeticRegex.Match(words[i]);

                if (logicalMatch.Success)
                {
                    richTextBox2.Text += "| " + words[i].PadRight(10) + " | " + "Logical".PadRight(10) + " |\r\n";
                }
                else if (relationalMatch.Success)
                {
                    richTextBox2.Text += "| " + words[i].PadRight(10) + " | " + "Relational".PadRight(10) + " |\r\n";
                }
                else if (arithmeticMatch.Success)
                {
                    richTextBox2.Text += "| " + words[i].PadRight(10) + " | " + "Arithmetic".PadRight(10) + " |\r\n";
                }
                else
                {
                    richTextBox2.Text += "| " + words[i].PadRight(10) + " | " + "Invalid".PadRight(10) + " |\r\n";
                }
            }

            richTextBox2.Text += "+------------+------------+";
        }
    }
}
