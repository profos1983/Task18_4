using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideoDownload.Classes
{
    internal class GetVideoInfo : Command
    {
        Reciver _reciver;
        string Url { get; set; }

        public GetVideoInfo(Reciver Reciver, string url)
        {
            this._reciver = Reciver;
            this.Url = url;
        }
        public override void Run(string videoUrl)
        {
            Console.WriteLine("Команда на получение информации о видео отправлена...");
            _reciver.ProvideVideoInfo(Url);

        }
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

    }
}
