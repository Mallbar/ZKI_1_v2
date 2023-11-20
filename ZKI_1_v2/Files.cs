using Microsoft.Win32;
using System.IO;

static class Files
{
    public static void SavingToFile(string filePath, string text)
    {
        using (StreamWriter writer = new(filePath))
        {
      
            writer.Write(text);
        }
    }
    public static string ExtractFromFile()
    {
        var openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == true)
        {
            return File.ReadAllText(openFileDialog.FileName);
        }
        return File.ReadAllText(openFileDialog.FileName);
    }
}


