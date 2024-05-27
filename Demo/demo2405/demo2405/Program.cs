using System.Drawing;
using System.Drawing.Imaging;
internal class Program
{
    private static void Main(string[] args)
    {
        //Compression
        string imagePath = @"C:\Users\Dell\Desktop\CSE306\GIT\ONL\CSE306\Demo\demo2405\demo2405\bin\Debug\net8.0\a.jpg";
        string compressedImagePath = @"C:\Users\Dell\Desktop\CSE306\GIT\ONL\CSE306\Demo\demo2405\demo2405\bin\Debug\net8.0\a_compressed.jpg";
        using (Bitmap bm = new Bitmap(imagePath))
        {

            EncoderParameters encoderParameters = new EncoderParameters(1);
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            EncoderParameter qualityEncoder = new EncoderParameter(encoder, 500L);

            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            encoderParameters.Param[0] = qualityEncoder;
            bm.Save(compressedImagePath,jpgEncoder,encoderParameters);

        }
        Console.WriteLine("Done!");
        Console.ReadKey();

    }
    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}