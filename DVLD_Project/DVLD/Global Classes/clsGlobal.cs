using DVLD_Business;
using System;
using System.IO;

namespace DVLD.Global_Classes
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernamePassword(string Username, string Password)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = currentDirectory + "\\infoLogin.txt";
                if(Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                string infoLogin = Username + "#//#" + Password;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(infoLogin);
                    return true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential( ref string Username, ref string Password)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = currentDirectory + "\\infoLogin.txt";
                
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = "";
                        while((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] strArr = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = strArr[0];
                            Password = strArr[1];
                        }

                        return true;
                    }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

    }
}
