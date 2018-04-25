using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VowelsAndConsonants
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var vowelCount = 0;
            var consonantCount = 0;
            string input = inputTextBox.Text.ToLower();
            char[] inputArray = input.ToCharArray();
            foreach (var letter in inputArray)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount += 1;
                }
                else if (consonants.Contains(letter))
                {
                    consonantCount += 1;
                }
            }
            resultLabel.Text = String.Format("Vowel Count: {0}<br />Consonant Count: {1}", 
                vowelCount, 
                consonantCount);
        }
    }
}