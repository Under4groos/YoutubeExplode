
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
