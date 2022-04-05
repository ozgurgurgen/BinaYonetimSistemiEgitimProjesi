using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaYonetimSistemi.Controller
{
    internal class FormControl
    {
        public void TexboxClear(Form form)
        {

            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(RichTextBox))
                {
                    control.Text = "";
                }
            }

        }
        public bool TextBoxesAreEmpty(Form form)
        {
            bool bos = false;

            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(RichTextBox))
                {
                    if (control.Text.Equals(""))
                    {
                        new ErrorProvider().SetError(control, "Bu alan boş bırakılamaz");
                        bos = true;
                    }
                }
            }
            if (bos)
            {


                return false;
            }
            else
            {
                return true;
            }


        }
    }
}

