using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = listBox1.Text;
            int coutWords = searchWords(inputText);
            label1.Text = coutWords.ToString();
        }   

        private int searchWords(string inputText)
        {
            char[] separators = { ' ' };
            string[] words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
