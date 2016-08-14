using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePasswordHolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String currentDirectory = System.IO.Directory.GetCurrentDirectory();
            String[] userInput = { this.WebsiteNameEntry.Text, this.UsernameEntry.Text, this.PasswordEntry.Text };
            System.IO.File.AppendAllLines(currentDirectory, userInput);
        }

        private void WebsiteNameEntry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UsernameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
