using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp.Validatori_input
{
    public class ValidatorNota
    {
        public static bool ValidateInput(ErrorProvider errorProvider, bool validateID, List<Nota> note, Control tbID, Control tbDenumire, Control tbPretPerMl)
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
                    foreach (Nota nota in note)
                    {
                        if (nota.Id == enteredId)
                        {
                            errorProvider.SetError(tbID, "Exista deja o nota cu acest ID.");
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
