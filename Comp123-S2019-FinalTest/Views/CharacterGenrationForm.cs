using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Comp123_S2019_FinalTest.Views
{
    public partial class CharacterGenrationForm : Comp123_S2019_FinalTest.Views.MasterForm
    {
        public CharacterGenrationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

             

        

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            string[] firstNamesArray = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\firstNames.txt");
            string[] lastNamesArray = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\lastNames.txt");
          
            List<string> lastName = new List<string>(lastNamesArray);
            List<string> firstname = new List<string>(firstNamesArray);
           
            Random r = new Random();
            int i = r.Next(0, firstname.Count - 1);
            string firstName = firstname[i];
            int i2 = r.Next(0, lastName.Count - 1);
            string lastname = lastName[i2];

            FirstNameDataLabel.Text = firstName;
            LastNameDataLabel.Text = lastname;
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            string[] skills = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\skills.txt");
            Random r = new Random();
            int i = r.Next(0, skills.Length - 1);
            string skill = skills[i];

        }
    }
}
