using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaYonetimSistemi.Classes
{
    public class Controller
    {
        public string ParolaDogrula(TextBox parolaTextBox, TextBox parolaDogrulamaTextBox )
        {
            if (parolaTextBox.Text.Equals(parolaDogrulamaTextBox.Text))
            {
                return parolaTextBox.Text;
            }
            else
            {
                return null;
            }
        }
    }
}
