using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JTTT_1._0
{
    class FileWritter
    {
        string filepath;
        readonly string fileName = "jttt";
        readonly string fileExtension = ".log";
        readonly string pathSeparator = "/";

        public FileWritter()
        {
            if (string.IsNullOrEmpty(filepath))
                filepath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        public void SaveTextFile(string localname, string data)
        {
            string path = filepath + pathSeparator + localname + fileExtension;
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            StreamWriter file = new StreamWriter(path, false);
            file.Write(data);
            file.Close();
        }

        public void AppendTextFile(string data)
        {
            string path = filepath + pathSeparator + fileName + fileExtension;
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            StreamWriter file = new StreamWriter(path, true);
            file.Write(data);
            file.Close();
        }
    }
}
