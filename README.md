### Forked from https://github.com/Tyrrrz/YoutubeExplode

<strong style="color:red">Библиотека не касается политики!</strong>

<strong>YoutubeExplode</strong> — это библиотека, которая предоставляет интерфейс для запроса метаданных видео, плейлистов и каналов YouTube, а также для разрешения и загрузки видеопотоков и дорожек со скрытыми субтитрами. За слоем абстракции эта библиотека работает, очищая необработанные данные страницы и используя реверс-инжиниринг внутренних конечных точек.


Пример:
```C#
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

string youtube_link = "https://www.youtube.com/watch?v=Adlozo1VAnc";
YoutubeClient client = new YoutubeClient();

try
{
    VideoId videoId = VideoId.Parse(youtube_link);

    var streamManifest = await client.Videos.Streams.GetManifestAsync(videoId);

    foreach (MuxedStreamInfo item in streamManifest.GetMuxedStreams())
    {
        Console.WriteLine($"{item.Url} | {item.VideoResolution.Area}");
    }
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}
Console.ReadLine();
```
