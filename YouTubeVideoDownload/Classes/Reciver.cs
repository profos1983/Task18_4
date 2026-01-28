using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.YouTube.v3;

namespace YouTubeVideoDownload.Classes
{
    class Reciver
    {
        public void ProvideVideoInfo(string Url)
        {
            Console.WriteLine(Url);
            Console.WriteLine("Запускается обработка запроса на предоставление информации о видео...");
        }

        public void DownloadVideo(string Url)
        {
            Console.WriteLine(Url);
            Console.WriteLine("Запускается загрузка видео...");
        }

    }
}
