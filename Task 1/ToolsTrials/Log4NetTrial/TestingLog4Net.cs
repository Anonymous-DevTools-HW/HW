using System;
using System.Linq;
using log4net;
using log4net.Config;
using log4net.Appender;
using log4net.Layout;
using System.IO;

namespace TestRun
{
    class TestingLog4Net
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TestingLog4Net));

        static void Main(string[] args)
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "../../resultOutput.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(fileAppender);

            log.Info("This is some info to be found in this file.");

            try
            {
                File.ReadAllLines("unexistingFile.txt");
            }
            catch(FileNotFoundException fnfe)
            {
                log.Fatal(fnfe);
            }
        }
    }
}
