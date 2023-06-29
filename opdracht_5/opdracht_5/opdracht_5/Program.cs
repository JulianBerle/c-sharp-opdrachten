using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Geef een startfolder op als argument.");
            return;
        }

        string startFolder = args[0];
        ShowFolders(startFolder);
    }

    static void ShowFolders(string folder)
    {
        try
        {
            // Toon de huidige folder
            Console.WriteLine(folder);

            // Haal alle subfolders op
            string[] subFolders = Directory.GetDirectories(folder);

            // Roep ShowFolders recursief aan voor elke subfolder
            foreach (string subFolder in subFolders)
            {
                ShowFolders(subFolder);
            }
        }
        catch (UnauthorizedAccessException)
        {
            // Het programma kan geen toegang krijgen tot de folder
            // Dus ga verder met de volgende folder
            return;
        }
    }
}
