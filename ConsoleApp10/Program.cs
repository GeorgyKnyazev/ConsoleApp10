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

            List<string> fullNames = new List<string>();
            List<string> posts = new List<string>();

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
                        AddDossier(fullNames, posts);
                        break;

                    case ShowAllDossierInMenu:
                        ShowAllDossier(fullNames, posts);
                        break;

                    case RemoveDossierInMenu:
                        RemoveDossier(fullNames, posts);
                        break;

                    case ExitInMenu:
                        isProgramWork = false;
                        break;
                }
            }
        }

        static void AddDossier(List<string> fullNames, List<string> posts)
        {
            string nameSurnameOutputText = "Введите Имя Фамилию Отчество через пробел: ";
            string postOutputText = "Введите должность: ";
            
            Console.Clear();

            EnterInList(nameSurnameOutputText, fullNames);
            EnterInList(postOutputText, posts);
        }

        static void EnterInList(string outputText, List<string> storageList)
        {
            string userInput;

            Console.WriteLine(outputText);

            userInput= Console.ReadLine();
            storageList.Add(userInput);
        }

        static void ShowAllDossier(List<string> fullNames, List<string> posts)
        {
            Console.Clear();

            for (int i = 0; i < fullNames.Count; i++)
            {
                Console.Write(i + "- ");
                Console.Write(fullNames[i] + " - ");
                Console.WriteLine(posts[i] + ".");
            }

            Console.ReadKey();
        }

        static void RemoveDossier(List<string> fullNames, List<string> posts)
        {
            Console.Clear();

            string userInput;
            int userInputNumber;

            Console.WriteLine("Введите номер досье для удаления: ");

            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userInputNumber))
            {
                RemoveFromList(userInputNumber, fullNames);
                RemoveFromList(userInputNumber, posts);
            }
        }

        static void RemoveFromList (int dossierNumber , List<string> storageList)
        {
            storageList.RemoveAt(dossierNumber);
        }
    }
}
