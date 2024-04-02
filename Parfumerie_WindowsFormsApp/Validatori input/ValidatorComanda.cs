using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp.Validatori_input
{
    public class ValidatorComanda
    {
        public static bool ValidateInput(TextBox tbID, ComboBox cbClient, ComboBox cbCategorie, ComboBox cbNota,
             CheckedListBox clbAccente, ToolStrip toolStrip, TextBox tbCantitate, ErrorProvider errorProvider,
             List<Comanda> comenzi)
        {
            errorProvider.Clear();
            bool isValid = true;

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
                foreach (Comanda comanda in comenzi)
                {
                    if (comanda.Id == enteredId)
                    {
                        errorProvider.SetError(tbID, "Exista deja o comanda cu acest ID.");
                        isValid = false;
                        break;
                    }
                }
            }

            if (cbClient.SelectedItem == null)
            {
                errorProvider.SetError(cbClient, "Selectati un client.");
                isValid = false;
            }

            if (cbCategorie.SelectedItem == null)
            {
                errorProvider.SetError(cbCategorie, "Selectati o categorie.");
                isValid = false;
            }

            if (cbNota.SelectedItem == null)
            {
                errorProvider.SetError(cbNota, "Selectati o nota.");
                isValid = false;
            }

            if (clbAccente.CheckedItems.Count == 0)
            {
                errorProvider.SetError(toolStrip, "Selectati cel putin un accent.");
                isValid = false;
            }

            if (!int.TryParse(tbCantitate.Text, out int cantitate))
            {
                errorProvider.SetError(tbCantitate, "Cantitatea trebuie sa aiba o valoare numerica.");
                isValid = false;
            }
            else if (string.IsNullOrWhiteSpace(tbCantitate.Text))
            {
                errorProvider.SetError(tbCantitate, "Introduceti cantitatea.");
                isValid = false;
            }
            else if (cantitate == 0)
            {
                errorProvider.SetError(tbCantitate, "Cantitatea nu poate fi 0.");
            }

            return isValid;
        }

    }
}