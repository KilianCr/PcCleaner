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
        private DirectoryInfo winTemp { get; }
        private DirectoryInfo appTemp{ get; }

    public Cleaner()
        {
            winTemp = new DirectoryInfo(@"C:\Windows\Temp");
            appTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
        }

        public long DirectorySize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(f => f.Length) + dir.GetDirectories().Sum(di => DirectorySize(di));
        }
        public List<string> Clear(DirectoryInfo dir)
        {
            List<string> list = new List<string>();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    file.Delete();
                    list.Add(file.FullName);

                }
                catch (Exception e)
                {
                    continue;
                }

            }
            list.Add("-");
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                try
                {
                    di.Delete();
                    list.Add(di.FullName);

                }
                catch (Exception e)
                {
                    continue;
                }

            }
            return list;
        }
    }
  
}
