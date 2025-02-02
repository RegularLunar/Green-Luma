using System;
using System.Collections.Generic;
using System.IO;

namespace GreenLuma
{
    public static class Luma
    {
        private const string localDynamicLibraryPath = "GreenLuma.dll";
        public static string GetLocalDynamicLibraryPath()
        {
            return localDynamicLibraryPath;
        }


        public static string GetDynamicLibraryPath()
        {
            string clientPath = Steam.GetClientPath();
            if (clientPath == null || Directory.Exists(clientPath) == false)
                return null;


            return Path.Combine(clientPath, "user32.dll");
        }






        public static bool IsInstalled()
        {
            string dynamicLibraryPath = GetDynamicLibraryPath();
            if (dynamicLibraryPath == null || File.Exists(dynamicLibraryPath) == false)
                return false;


            return true;
        }






        public static string GetGamesListPath()
        {
            string clientPath = Steam.GetClientPath();
            if (clientPath == null || Directory.Exists(clientPath) == false)
                return null;


            return Path.Combine(clientPath, "AppList");
        }


        public static List<string> GetGamesList()
        {
            string gamesListPath = GetGamesListPath();


            if (gamesListPath == null)
                return null;


            if (Directory.Exists(gamesListPath) == false)
                return null;


            List<string> gamesList = new List<string>();
            
            string[] detectedFiles = Directory.GetFiles(gamesListPath, "*.txt", SearchOption.AllDirectories);
            Array.Sort(detectedFiles);

            foreach (string file in detectedFiles)
            {
                try
                {
                    string fileContent = File.ReadAllText(file);

                    if (Int64.TryParse(fileContent, out long appId))
                        gamesList.Add(fileContent);
                }
                catch (Exception ex) 
                { 
                    ExceptionController.ShowException(ex); 
                }
            }


            return gamesList;
        }


        public static bool WriteGamesList(List<string> gamesList)
        {
            string gamesListPath = GetGamesListPath();


            if (gamesListPath == null)
                return false;
                

            if (Directory.Exists(gamesListPath) == false && Directory.Exists(Directory.GetParent(gamesListPath).FullName))
            {
                try
                {
                    Directory.CreateDirectory(gamesListPath);
                }
                catch (Exception ex)
                {
                    ExceptionController.ShowException(ex);
                    return false;
                }
            }


            int gamesCount = gamesList.Count;
            for (int i = 0; i < gamesCount; i++)
            {
                string filePath = Path.Combine(gamesListPath, $"{i}.txt");


                try
                {
                    File.WriteAllText(filePath, gamesList[i]);
                }
                catch (Exception ex)
                {
                    ExceptionController.ShowException(ex);
                }
            }


            return true;
        }


        public static bool ClearGamesList()
        {
            try
            {
                string gamesListPath = GetGamesListPath();

                if (Directory.Exists(gamesListPath))
                    Directory.Delete(GetGamesListPath(), true);

                return true;
            }
            catch (Exception ex)
            {
                ExceptionController.ShowException(ex);
                return false;
            }
        }
    }
}
