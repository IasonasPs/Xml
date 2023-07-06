namespace XmlConvertor.services
{
    public class Save
    {
        public static void SaveToFile(string text, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, filename);
                File.WriteAllText(filePath, text);
            }
        }
    }
}
