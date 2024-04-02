using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp.Validatori_input
{
    public class ValidatorAccent
    {
        public static bool ValidateInput(ErrorProvider errorProvider, bool validateID, List<Accent> accente, Control tbID, Control tbDenumire, Control tbPretPerMl)
        {
            errorProvider.Clear();
            bool isValid = true;

            if (validateID)
            {
                if (string.IsNullOrWhiteSpace(tbID.Text))
                {
                    errorProvider.SetError(tbID, "Introduceti ID-ul.");
                    isValid = false;
                }
                else if (!int.TryParse(tbID.Text, out int enteredId))
                {
                    errorProvider.SetError(tbID, "ID-ul trebuie sa fie numeric.");
                    isValid = false;
                }
                else
                {
                    foreach (Accent accent in accente)
                    {
                        if (accent.Id == enteredId)
                        {
                            errorProvider.SetError(tbID, "Exista deja un accent cu acest ID.");
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(tbDenumire.Text))
            {
                errorProvider.SetError(tbDenumire, "Introduceti denumirea.");
                isValid = false;
            }
            else if (tbDenumire.Text.Length < 3)
            {
                errorProvider.SetError(tbDenumire, "Denumirea trebuie sa aiba cel putin 3 caractere.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbPretPerMl.Text))
            {
                errorProvider.SetError(tbPretPerMl, "Introduceti pretul.");
                isValid = false;
            }
            else if (!float.TryParse(tbPretPerMl.Text, out float pretPerMl))
            {
                errorProvider.SetError(tbPretPerMl, "Pretul trebuie sa aiba o valoare numerica.");
                isValid = false;
            }
            else if (pretPerMl == 0)
            {
                errorProvider.SetError(tbPretPerMl, "Pretul nu poate fi 0.");
                isValid = false;
            }

            return isValid;
        }
    }
}