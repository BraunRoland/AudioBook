using System;
using System.Collections.Generic;
using System.Text;

namespace AudioBook
{
    internal interface IDownloadable
    {
        public double GetFileSizeInMB();
        public void Download();
    }
}
