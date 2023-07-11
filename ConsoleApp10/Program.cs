using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const ConsoleKey AddDossierInMenu = ConsoleKey.D1;
            const ConsoleKey ShowAllDossierInMenu = ConsoleKey.D2;
            const ConsoleKey RemoveDossierInMenu = ConsoleKey.D3;
            const ConsoleKey ExitInMenu = ConsoleKey.D4;

            List<string> nameSurnamePersonal = new List<string>();
            List<string> postPersonal = new List<string>();

            bool isProgramWork = true;

            while ( isProgramWork )
            {
                Console.Clear();
                Console.WriteLine($"Что бы добавить досье нажмите - {AddDossierInMenu}");
                Console.WriteLine($"Что бы вывести все досье нажмите - {ShowAllDossierInMenu}");
                Console.WriteLine($"XЧто бы удалить досье нажмите - {RemoveDossierInMenu}");
                Console.WriteLine($"Для выхода нажмите - {ExitInMenu}");

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case AddDossierInMenu:
                        AddDossier(nameSurnamePersonal, postPersonal);
                        break;

                    case ShowAllDossierInMenu:
                        ShowAllDossier(nameSurnamePersonal, postPersonal);
                        break;

                    case RemoveDossierInMenu:
                        RemoveDossier(nameSurnamePersonal, postPersonal);
                        break;

                    case ExitInMenu:
                        isProgramWork = false;
                        break;
                }
            }
        }

        static void AddDossier(List<string> nameSurnamePersonal, List<string> postPersonal)
        {
            string nameSurnameOutputText = "Введите Имя Фамилию Отчество через пробел: ";
            string postOutputText = "Введите должность: ";
            
            Console.Clear();

            EnterInList(nameSurnameOutputText, nameSurnamePersonal);
            EnterInList(postOutputText, postPersonal);
        }

        static void EnterInList(string outputText, List<string> storageList)
        {
            string userInput;

            Console.WriteLine(outputText);

            userInput= Console.ReadLine();
            storageList.Add(userInput);
        }

        static void ShowAllDossier(List<string> nameSurnamePersonal, List<string> postPersonal)
        {
            Console.Clear();

            for (int i = 0; i < nameSurnamePersonal.Count; i++)
            {
                Console.Write(i + "- ");
                Console.Write(nameSurnamePersonal[i] + " - ");
                Console.WriteLine(postPersonal[i] + ".");
            }

            Console.ReadKey();
        }

        static void RemoveDossier(List<string> nameSurnamePersonal, List<string> postPersonal)
        {
            Console.Clear();

            int userInput;

            Console.WriteLine("Введите номер досье для удаления: ");

            userInput = Convert.ToInt32(Console.ReadLine());

            RemoveFromList(userInput, nameSurnamePersonal);
            RemoveFromList(userInput, postPersonal);

        }

        static void RemoveFromList (int dossierNumber , List<string> storageList)
        {
            storageList.RemoveAt(dossierNumber);
        }
    }
}
