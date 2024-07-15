# WebM to MP3 Converter , Console App

**This console application converts all `.webm` files in a specified source folder to `.mp3` format and saves them in a target folder. It uses FFmpeg for the conversion.**

**Bu konsol uygulaması, belirtilen bir kaynak klasördeki tüm `.webm` dosyalarını `.mp3` formatına dönüştürür ve bunları hedef klasöre kaydeder. Dönüştürme için FFmpeg kullanır.**

## **Requirements / Gereksinimler**

- .NET SDK
- FFmpeg

## **Usage / Kullanım**

1. **Set the source and target folder paths in the code:**

   **Koddaki kaynak ve hedef klasör yollarını ayarlayın:**

   ```csharp
   const string sourceFolder = @"E:\MostIconicSongsofAllTime";
   const string targetFolder = @"D:\mp3\MostIconicSongsofAllTime";
