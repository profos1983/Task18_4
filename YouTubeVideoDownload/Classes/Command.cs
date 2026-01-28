using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideoDownload.Classes
{
    abstract class Command
    {
        public abstract void Run(string url);
        public abstract void Cancel();

    }
}
