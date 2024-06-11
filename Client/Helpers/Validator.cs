using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Helpers
{
    public class Validator
    {
        public static bool ValidateForm(List<TextBox> textBoxes, Label errorLabel)
        {
            bool allOk = true;
            textBoxes.ForEach(textBox =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor=System.Drawing.Color.Salmon;
                    errorLabel.Text = "Red fields are missing!";
                    allOk = false;
                }

            });
            return allOk;
        }

        private static void ResetValidation(List<TextBox> textBoxes, Label errorLabel)
        {

            textBoxes.ForEach(textBox =>
            {
                textBox.BackColor = System.Drawing.Color.White;
            });
            errorLabel.Text = "";
        }
    }
}
