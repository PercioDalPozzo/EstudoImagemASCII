using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemASCII;

public interface ILuminosidade
{
    double GetLuminosidade(Rgba32 pixelColor);
}