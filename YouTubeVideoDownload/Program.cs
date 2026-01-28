
using YouTubeVideoDownload.Classes;

// Создадим отправителя
var sender = new Sender();

// Создаем получателя
var reciver = new Reciver();



// Запрашиваем ссылку на видео в Youtube
// https://www.youtube.com/watch?v=mnBbwFW9Svo

Console.WriteLine("Введите ссылку на виде:");
string videoUrl = Console.ReadLine();

// Создадим команду
var getVideoInfo = new GetVideoInfo(reciver, videoUrl);

// Инициализируем команду
sender.SetCommand(getVideoInfo);

sender.Run();

