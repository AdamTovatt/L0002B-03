using System;
using System.Windows.Forms;

namespace PersonalIdentityValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = Person.Create(PersonalIdentityNumberTextbox.Text, FirstNameTextbox.Text, SurnameTextbox.Text);

                if (person.ValidCheckSum)
                    OutputTextbox.Text = string.Format("Fullständigt namn: {0} {1}\nPersonnummer: {2}\nKön: {3}", person.FirstName, person.Surname, person.PersonalIdentityNumber, person.Gender == Gender.Male ? "Man" : "Kvinna");
                else
                    OutputTextbox.Text = "Personnummrets kontrollsiffra stämmer inte";
            }
            catch (Exception exception)
            {
                OutputTextbox.Text = exception.Message;
            }
        }
    }
}
