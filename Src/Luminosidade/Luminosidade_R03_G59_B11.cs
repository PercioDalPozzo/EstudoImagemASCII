using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemASCII;

public class Luminosidade_R03_G59_B11 : ILuminosidade
{
    public double GetLuminosidade(Rgba32 pixelColor)
    {
        //0   => preto total
        //255 => branco total
        
        return 0.03 * pixelColor.R +
               0.59 * pixelColor.G +
               0.11 * pixelColor.B;
    }
}