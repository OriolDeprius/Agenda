using System.Text.RegularExpressions;

namespace Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            ValidarOpcio();
        }

        static void MenuPrincipal()
        {
            string opcio = "╔═══════════════════════════╗\n" +
                           "║           Agenda          ║\n" +
                           "╠═══════════════════════════╣\n" +
                           "║1. Donar d'alta a l'usuari ║\n" +
                           "║2. Recuperar usuari        ║\n" +
                           "║3. Modificar usuari        ║\n" +
                           "║4. Eliminar usuari         ║\n" +
                           "║5. Mostrar agenda          ║\n" +
                           "║6. ordenar agenda          ║\n" +
                           "║Q. Sortir de l'agenda      ║\n" +
                           "╚═══════════════════════════╝\n";
            Console.WriteLine(opcio);
        }
        static void ValidarOpcio()
        {
            char opcio;
            Console.Write("Introdueix una opcio --> ");
            opcio = Console.ReadKey().KeyChar;
            Console.Clear();
            TriarOpcio(opcio);
        }


        //Mètode endevant o cancelar
        //static bool endevantOcancelar()
        //{
        //    bool valid = false;
        //    if
        //}

        //Mètode per Triar Opció
        static void TriarOpcio(char cas)
        {
            switch (cas)
            {
                case '1':
                    DonarAltaUsuari();
                    break;

                case '2':
                    RecuperarUsuari();
                    break;

                case '3':
                    ModificarUsuari();
                    break;

                case '4':
                    EliminarUsuari();
                    break;

                case '5':
                    MostrarAgenda();
                    break;

                case '6':
                    OrdenarAgenda();
                    break;

                case 'Q':
                    SortirMenu();
                    break;
            }
        }
        static void DonarAltaUsuari()
        {
            string nom, cognom, dni, telefon, dataNaix, correu;
            Console.WriteLine("<--DONAR ALTA USUARI-->");
            Console.WriteLine("Nom: ");
            nom = Console.ReadLine();
            nom = char.ToUpper(nom[0]) + nom.Substring(1);

            Console.WriteLine("Cognom: ");
            cognom = Console.ReadLine();
            cognom = char.ToUpper(cognom[0]) + cognom.Substring(1);

            Console.WriteLine("DNI: ");
            dni = Console.ReadLine();
            Regex regexDni = new Regex(@"^[0-9]{8}[A-Z]$");
            MatchCollection matches = regexDni.Matches(dni);
            if (matches.Count == 1)
            {
                Console.WriteLine("DNI incorrecte");
                Console.WriteLine("DNI: ");
                dni = Console.ReadLine();
            }

            Console.WriteLine("Telefon: ");
            telefon = Console.ReadLine();
            Regex regexTelefon = new Regex(@"^[0-9]{9}$");
            MatchCollection matchesTelefon = regexTelefon.Matches(telefon);
            if (matchesTelefon.Count == 1)
            {
                Console.WriteLine("Telefon incorrecte");
                Console.WriteLine("Telefon: ");
                telefon = Console.ReadLine();
            }


        }


        //StreamWriter sW;
        //sW = new StreamWriter(new FileStream(@".\agenda.txt", FileMode.Append));


        //mètode per eliminar l'usuari
        //mètode mostrar usuari

        //        static void EliminarUsuari()
        //        {
        //            Console.WriteLine("Escriu el nom i cognom de l'usuari que vulguis eliminar:");
        //            string NomCognomEliminar = Console.ReadLine();

        //            sR = new StreamReader(@".\agenda.txt");

        //            string NomCognom, linia = "", filaSuport = "", nomFitxer = "", cognomFitxer = "", nomCognomFitxer = "", agenda = "";
        //            char cas = '0';

        //            StreamReader sR;
        //            StreamWriter sW;

        //            while (!llegir.EndOfStream)
        //            {
        //                linia = sR.ReadLine();
        //                nomFitxer = linia.Substring(0, linia.IndexOf(';'));
        //                filaSuport = linia.Substring(linia.IndexOf(';') + 1);
        //                cognomFitxer = filaSuport.Substring(0, filaSuport.IndexOf(';'));
        //                nomCognomFitxer = nomFitxer + ' ' + cognomFitxer;

        //                if (NomCognom != nomCognomFitxer)
        //                {
        //                    if (agenda == "") agenda += linia;
        //                    else agenda += "\n" + linia;
        //                }
        //            }

        //            sR.Close();
        //            sW = new StreamWriter(@".\agenda.txt");
        //            sW.WriteLine(agenda);
        //            sW.Close();
        //        }

        //    }
        //}

        //static bool Eliminar(int[] t, ref int nElem, int index)
        //{
        //    bool res = true;
        //    if (index >= 0 && index < nElem)
        //    {
        //        for (int i = index; i < nElem - 1; i++)
        //            t[i] = t[i + 1];
        //        nElem–;
        //    }
        //}
    }
}