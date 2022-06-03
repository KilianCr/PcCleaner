using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCleaner
{
    internal class Cleaner
    {
        private DirectoryInfo _winTemp;
        public DirectoryInfo winTemp => _winTemp;

        private DirectoryInfo _appTemp;
        public DirectoryInfo appTemp => _appTemp;

        private List<string> clearFiles = new List<string>();

    public Cleaner()
        {
            _winTemp = new DirectoryInfo(@"C:\Windows\Temp");
            _appTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
        }

        public long DirectorySize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(f => f.Length) + dir.GetDirectories().Sum(di => DirectorySize(di));
        }
        public void Clear(DirectoryInfo dir)
        {
            
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    file.Delete();
                    clearFiles.Add(file.FullName);

                }
                catch (Exception e)
                {
                    continue;
                }

            }
            clearFiles.Add("-");
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                try
                {
                    di.Delete(true);
                    clearFiles.Add(di.FullName);

                }
                catch (Exception e)
                {
                    continue;
                }

            }
            
        }
    }
  
}
