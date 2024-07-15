using System.Diagnostics;

namespace ConsoleApp1;

static class Program
{
    static void Main()
    {
        const string sourceFolder = @"E:\MostIconicSongsofAllTime";
        const string targetFolder = @"D:\mp3\MostIconicSongsofAllTime";


        if (!Directory.Exists(targetFolder))
        {
            Directory.CreateDirectory(targetFolder);
        }


        var webmFiles = Directory.GetFiles(sourceFolder, "*.webm", SearchOption.AllDirectories);


        foreach (var webmFile in webmFiles)
        {

            string relativePath = Path.GetRelativePath(sourceFolder, webmFile);
            string targetFilePath = Path.Combine(targetFolder, Path.ChangeExtension(relativePath, ".mp3"));


            string targetDirectory = Path.GetDirectoryName(targetFilePath);
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            ConvertWebmToMp3(webmFile, targetFilePath);
            Thread.Sleep(100);
        }
    }

    static void ConvertWebmToMp3(string webmFilePath, string mp3FilePath)
    {

        const string ffmpegPath = @"D:\ffmpeg.exe"; // FFmpeg'in sisteminizdeki yolu
        string arguments = $"-i \"{webmFilePath}\" \"{mp3FilePath}\"";


        ProcessStartInfo startInfo = new(ffmpegPath, arguments)
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using Process process = new();
        process.StartInfo = startInfo;
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();
        Debug.WriteLine($"{webmFilePath} dönüştürüldü ");
      

    }
}