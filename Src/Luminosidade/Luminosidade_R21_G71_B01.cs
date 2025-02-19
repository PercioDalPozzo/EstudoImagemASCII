using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemASCII;

public class Luminosidade_R21_G71_B01 : ILuminosidade
{
    public double GetLuminosidade(Rgba32 pixelColor)
    {
        //0   => preto total
        //255 => branco total
        
        return 0.2126 * pixelColor.R +
               0.7152 * pixelColor.G +
               0.0722 * pixelColor.B;
    }
}