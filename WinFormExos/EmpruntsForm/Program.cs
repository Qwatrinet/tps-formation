using BankLibrary;
using System;
using System.IO;
using System.Security.Principal;
using System.Text.Json;

using System.Windows.Forms;

namespace EmpruntsForm
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            string loanToDeserialize = "";
            Loan PreviousLoan = new Loan();
            string fileName = "Loan.json";
            string chemin = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "Emprunts";
            if (Directory.Exists(chemin))
            {
                if (File.Exists(chemin + Path.DirectorySeparatorChar + fileName))
                {
                    loanToDeserialize = File.ReadAllText(chemin + Path.DirectorySeparatorChar + fileName);
                    if (loanToDeserialize.Length > 0)
                    {
                        PreviousLoan = JsonSerializer.Deserialize<Loan>(loanToDeserialize);
                    }
                }
            }

            if (PreviousLoan == null)
            {
                PreviousLoan = new Loan();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LendingForm form1 = new LendingForm(PreviousLoan);
            Application.Run(form1);

            Loan loanToSerialize = form1.Loan;

            string jsonString = JsonSerializer.Serialize(loanToSerialize);
            if (!Directory.Exists(chemin))
            {
                Directory.CreateDirectory(chemin);
            }
            File.WriteAllText(chemin + Path.DirectorySeparatorChar + fileName, jsonString);
        }
    }
}
