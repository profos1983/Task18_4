using System;
using System.Collections.Generic;
using System.Text;
using VideoLibrary;

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
        public override void Run()
        {

            Console.WriteLine("Команда на получение информации о видео отправлена...");
            // Запускаем и ждем завершения прямо здесь
            CheckYouTubeAvailability(Url).GetAwaiter().GetResult();

            Console.WriteLine("Продолжаем работу...");
            //_reciver.ProvideVideoInfo(Url);
            //var youTube = YouTube.Default;
            //var video = youTube.GetVideo(this.Url);

            //string title = video.Title;
            //Console.WriteLine($"{title}");
            //VideoInfo info = video.Info;
            //string fileExtension = video.FileExtension;
            //string fullname = video.FullName;
            //int resolution = video.Resolution;


        }
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public async Task CheckYouTubeAvailability(string url)
        {
            // Используем static или Singleton HttpClient, чтобы не плодить подключения
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Добавляем User-Agent, чтобы не выглядеть как подозрительный бот
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                    Console.WriteLine("Проверка соединения с YouTube...");

                    // Отправляем запрос (только заголовки)
                    HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Соединение успешно установлено! Сервер ответил: " + response.StatusCode);
                    }
                    else
                    {
                        Console.WriteLine($"Сервер доступен, но вернул ошибку: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nОшибка запроса!");
                    Console.WriteLine($"Сообщение: {e.Message}");
                    if (e.InnerException != null)
                        Console.WriteLine($"Внутренняя ошибка: {e.InnerException.Message}");
                }
            }
        }

    }
}
