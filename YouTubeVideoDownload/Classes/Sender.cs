using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideoDownload.Classes
{
    internal class Sender
    {
        Command _command;
        string Url { get; set; }
        public void SetCommand(Command command)
        {
            _command = command; 
        }

        // Получить данные о видео
        public void Run()
        {
            _command.Run(Url);
        }

        // Скачать видео
        public void Cancel()
        {
            _command.Cancel();
        }

    }
}
