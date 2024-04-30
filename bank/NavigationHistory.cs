using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    internal class NavigationHistory
    {
        private static Stack<Form> history = new Stack<Form>();

        public static void GoBack()
        {
            if (history.Count > 1) 
            {
                Form currentForm = history.Pop(); 
                Form previousForm = history.Peek(); 
                currentForm.Close();
                previousForm.Show();
            }
        }

        public static void NavigateTo(Form nextForm)
        {
            Form currentForm = null;
            if (history.Count > 0)
            {
                currentForm = history.Peek(); 
                currentForm.Hide(); 
            }
            history.Push(nextForm); 
            nextForm.Show();
        }

        public static void ClearHistory()
        {
            history.Clear();
        }
    }
}
