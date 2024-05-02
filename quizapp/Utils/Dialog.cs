using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizapp
{
    public class Dialog
    {
        // Information Dialog
        public static void Info (string message, string title = "Information")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Warning Dialog
        public static void Warning (string message, string title = "Warning")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Error Dialog
        public static void Error(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Bug Dialog
        public static void Bug(string message)
        {
            MessageBox.Show($"{message}\n\nPlease report this to developer. You can still running the app", "Bug Tracer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Confirmation Dialog
        public static DialogResult Confirm (string message, string title = "Confirmation", MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
        }
    }
}
