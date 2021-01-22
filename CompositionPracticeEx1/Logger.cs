using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositionPracticeEx1
{
    class Logger
    {
        public void Log(string message)
        {
            MessageBox.Show(message);
        }
        public void LogInformation(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LogError(string message)
        {
            MessageBox.Show(message,"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
