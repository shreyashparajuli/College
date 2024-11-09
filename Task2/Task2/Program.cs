using System;
using System.Windows.Forms;

namespace Task2
{
    class Program   
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Displaying a message box with a message, title, OK button, and exclamation icon
            MessageBox.Show("This is the message inside the box", "Message Box Title",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
