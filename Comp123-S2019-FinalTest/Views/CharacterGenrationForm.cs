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
        public static List<string> LoadNames(string name)
        {
            string[] firstNamesArray = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\firstNames.txt");
            string[] lastNamesArray = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\lastNames.txt");
            if (name == "FirstName")
            {

                List<string> lastName = new List<string>(lastNamesArray);
                return lastName;
            }
            else
                       {
                List<string> firstname = new List<string>(firstNamesArray);
                return firstname;
            }
        }


        public  void GenrateName()
        {
            List<string> LastName = LoadNames("");
            List<string> firstName = LoadNames("FirstName");
            Random r = new Random();
            int i = r.Next(0, firstName.Count - 1);
            string firstname = firstName[i];
            int i2 = r.Next(0, LastName.Count - 1);
            string lastname = LastName[i2];

            FirstNameDataLabel.Text = firstname;
            LastNameDataLabel.Text = lastname;
        }



        private void GenerateNameButton_Click(object sender, EventArgs e)
        {


            GenrateName();

           
        }

      

        public static void loadSkills()
        {
            string[] skills = File.ReadAllLines(@"C:\Users\301044075\Desktop\Comp123-S2019-FinalTest\Comp123-S2019-FinalTest\Data\skills.txt");
            List<string> skill = new List<string>(skills);
        }
    }
}
