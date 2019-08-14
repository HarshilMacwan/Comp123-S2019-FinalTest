using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comp123_S2019_FinalTest.Views;

namespace Comp123_S2019_FinalTest
{
    static class Program
    {
        public static CharacterGenrationForm characterGenrationForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            characterGenrationForm = new CharacterGenrationForm();

            Application.Run(characterGenrationForm);
        }
    }
}
