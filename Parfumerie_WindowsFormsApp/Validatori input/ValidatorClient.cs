using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp.Validatori_input
{
    public class ValidatorClient
    {
        public static bool ValidateInput(Control tbID, Control tbNume, Control tbPrenume, Control tbTelefon,
            Control tbEmail, ErrorProvider errorProvider, bool validateID, List<Client> clienti)
        {
            errorProvider.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                errorProvider.SetError(tbID, "Introduceti ID-ul.");
                isValid = false;
            }
            else
            {
                if (!int.TryParse(tbID.Text, out int enteredId))
                {
                    errorProvider.SetError(tbID, "ID-ul trebuie sa fie numeric.");
                    isValid = false;
                }
                else
                {
                    foreach (Client client in clienti)
                    {
                        if (client.Id == enteredId)
                        {
                            errorProvider.SetError(tbID, "Exista deja un client cu acest ID.");
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorProvider.SetError(tbNume, "Introduceti numele.");
                isValid = false;
            }
            else if (tbNume.Text.Length < 3)
            {
                errorProvider.SetError(tbNume, "Numele trebuie sa aiba cel putin 3 caractere.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                errorProvider.SetError(tbPrenume, "Introduceti prenumele.");
                isValid = false;
            }
            else if (tbPrenume.Text.Length < 3)
            {
                errorProvider.SetError(tbPrenume, "Prenumele trebuie sa aiba cel putin 3 caractere.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                errorProvider.SetError(tbTelefon, "Introduceti numarul de telefon.");
                isValid = false;
            }
            else if (!tbTelefon.Text.All(char.IsDigit))
            {
                errorProvider.SetError(tbTelefon, "Numarul de telefon trebuie sa contina doar cifre.");
                isValid = false;
            }
            else if (tbTelefon.Text.Length != 10)
            {
                errorProvider.SetError(tbTelefon, "Numarul de telefonul trebuie sa aiba 10 cifre.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                errorProvider.SetError(tbEmail, "Introduceti adresa de email.");
                isValid = false;
            }
            else if (!EmailIsValid(tbEmail.Text))
            {
                errorProvider.SetError(tbEmail, "Adresa de email nu este valida.");
                isValid = false;
            }

            return isValid;
        }

        private static bool EmailIsValid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }
    }
}