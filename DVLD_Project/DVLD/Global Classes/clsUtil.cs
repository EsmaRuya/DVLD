using System;

namespace DVLD.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid NewGuid = Guid.NewGuid();
            return NewGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if(!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}", "Error!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            FileInfo fi = new FileInfo(SourceFile);
            string extn = fi.Extension;
            return (GenerateGUID() + extn);
        }

        public static bool CopyImageToProjectImagesFolder(ref string SourceFile)
        {
            string DestinationFolder = @"C:\DVLD_Images\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder)) return false;

            string ImageNewPath = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try { File.Copy(SourceFile, ImageNewPath, true); }
            catch(IOException e)
            {
                MessageBox.Show($"Error:\n{e.Message}","Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFile = ImageNewPath;
            return true;
        }
    }
}
