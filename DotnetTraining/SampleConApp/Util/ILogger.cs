using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Util
{
    internal interface ILogger
    {
        void LogInformation(string message);

        void LogError(string message);
    }

    class FileLogger : ILogger
    {
        string folderPath = ConfigurationManager.AppSettings["LoggerFolder"];
        string fileName = string.Empty;
        public FileLogger()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            DateTime dt = DateTime.Now;
            string date = dt.Day.ToString();
            string month = dt.Month.ToString();
            string year = dt.Year.ToString();
            string dtFile = $"FnFLogs_{date}_{month}_{year}.txt";
            fileName = Path.Combine(folderPath, dtFile);
        }

        public void LogError(string message)
        {
            //It will open the file, if not found, creates the file and appends the text into it. 
            File.AppendAllText(fileName, $"Error: {message}");
        }

        public void LogInformation(string message)
        {
            File.AppendAllText(fileName, $"Info: {message}");
        }
    }
}
