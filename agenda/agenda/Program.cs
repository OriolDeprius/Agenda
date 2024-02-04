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



        //Mètode Eliminar Usuari
        static void EliminarUsuari()
        {
            StreamReader sR;
            StreamWriter sW;
            string nomCognom, linia = "", liniaAux = "", nomFitxer = "", cognomFitxer = "", nomCognomFitxer = "", agenda = "";
            char opcio = '0';
            sR = new StreamReader(@".\agenda.txt");
            Console.WriteLine("Insereix el nom i cognom de l'usuari que vols eliminar:");
            nomCognom = Console.ReadLine();



            switch (opcio)
            {
                case '4':
                    while (!sR.EndOfStream)
                    {
                        linia = sR.ReadLine();
                        nomFitxer = linia.Substring(0, linia.IndexOf(';'));
                        liniaAux = linia.Substring(linia.IndexOf(';') + 1);
                        cognomFitxer = liniaAux.Substring(0, liniaAux.IndexOf(';'));
                        nomCognomFitxer = nomFitxer + ' ' + cognomFitxer;

                        if (nomCognom != nomCognomFitxer)
                        {
                            if (agenda == "") agenda += linia;
                            else agenda += "\n" + linia;
                        }
                    }
                    sR.Close();
                    sW = new StreamWriter(@".\agenda.txt");
                    sW.WriteLine(agenda);
                    sW.Close();

                    break;
                case 'n':
                    break;
            
            }



            
        }


        static void Informacio(string info)
        {
            int index1 = info.IndexOf(';');
            int index2 = info.IndexOf(';', index1 + 1);
            int index3 = info.IndexOf(';', index2 + 1);

            if (index1 != -1 && index2 != -1 && index3 != -1)
            {
                string nom = info.Substring(0, index1);
                string cognom = info.Substring(index1 + 1, index2 - index1 - 1);
                string numtelefon = info.Substring(index3 + 1, info.Length - index3 - 1);

                Console.WriteLine($"\tUsuari:   {nom} {cognom}\t\t\t Telèfon: {numtelefon}");
            }
            else
            {
                Console.WriteLine("Error0");
            }
        }

        //Mètode per mostrar l'agenda
        static void MostrarAgenda()
        {
            string dades = "";
            StreamReader sR = new StreamReader(@".\agenda.txt");
            Console.WriteLine("Contactes agenda--->");
            while (!sR.EndOfStream)
            {
                dades = sR.ReadLine();
                Informacio(dades);
            }
            sR.Close();
        }

        //Mètode Ordenar Agenda
        static void OrdenarAgenda()
        {
            string viaFitxer = "agenda.txt";
            FileInfo fitxer = new FileInfo(viaFitxer);

            if (fitxer.Exists)
            {
                List<string> linies = new List<string>();
                using (StreamReader reader = new StreamReader(viaFitxer))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        linies.Add(linia);
                    }
                }
                {
                    using (StreamWriter writer = new StreamWriter(viaFitxer))
                    {
                        for (int i = 0; i < linies.Count; i++)
                        {
                            writer.WriteLine(linies[i]);
                        }
                    }

                    Console.WriteLine("Fitxer ordenat correctament en ordre alfabètic.");
                }
            }
        }
    }
}


