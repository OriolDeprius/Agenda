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
            Console.Write("Introdueix una opcio --> ");
        }


        //Mètode endevant o cancelar
        static bool endevantOcancelar()
        {
            bool valid = false;
            if
        }

        //Mètode per Triar Opció
        static void TriarOpció(char cas)
        {
            Console.Clear();
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


        //StreamWriter sW;
        //sW = new StreamWriter(new FileStream(@".\agenda.txt", FileMode.Append));


        //mètode per eliminar l'usuari
        //mètode mostrar usuari

        static void EliminarUsuari()
        {
            Console.WriteLine("Escriu el nom i cognom de l'usuari que vulguis eliminar:");
            string NomCognomEliminar = Console.ReadLine();

            sR = new StreamReader(@".\agenda.txt");

            string NomCognom, linia = "", filaSuport = "", nomFitxer = "", cognomFitxer = "", nomCognomFitxer = "", agenda = "";
            char cas = '0';

            StreamReader sR;
            StreamWriter sW;

            while (!llegir.EndOfStream)
            {
                linia = sR.ReadLine();
                nomFitxer = linia.Substring(0, linia.IndexOf(';'));
                filaSuport = linia.Substring(linia.IndexOf(';') + 1);
                cognomFitxer = filaSuport.Substring(0, filaSuport.IndexOf(';'));
                nomCognomFitxer = nomFitxer + ' ' + cognomFitxer;

                if (NomCognom != nomCognomFitxer)
                {
                    if (agenda == "") agenda += linia;
                    else agenda += "\n" + linia;
                }
            }

            sR.Close();
            sW = new StreamWriter(@".\agenda.txt");
            sW.WriteLine(agenda);
            sW.Close();
        }

    }
}

static bool Eliminar(int[] t, ref int nElem, int index)
{
    bool res = true;
    if (index >= 0 && index < nElem)
    {
        for (int i = index; i < nElem - 1; i++)
            t[i] = t[i + 1];
        nElem–;
    }
}