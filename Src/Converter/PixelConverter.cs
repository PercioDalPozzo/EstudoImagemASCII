using System.Diagnostics;
using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemASCII;

public class PixelConverter 
{
    // private const string chars2 = " #";
    // private const string chars5 = " .:+#";
    // private const string chars10 = " .,:;+*$%#";
    // private const string chars20 = " .,-~:;+=*%#@$&8BWMEH";
     private const string chars50 = " .'`^\",-~:;_+=<*>!i|\\/()1{}[]?rlcvyzJftL7nuxeao%#@$&8BWMEH";

    private const string chars2 = "# ";
    private const string chars5 = "#*+. ";
    private const string chars10 = "#%$*+;:,. ";
    private const string chars20 = "#@%$&*+=-:,.!?^~` ";
    
    private readonly string _chars;

    private readonly ILuminosidade _luminosidade;
    
    public PixelConverter(ILuminosidade luminosidade, int chars)
    {
        _luminosidade = luminosidade;

        _chars = chars switch
        {
            5 => chars5,
            10 => chars10,
            20 => chars20,
            50 => chars50,
            _ => chars2
        };
    }        

    public char PixelToChar(Rgba32 pixelColor)
    {
        var luminosidade = _luminosidade.GetLuminosidade(pixelColor);
        
        int index = (int)Math.Round((luminosidade / 255.0) * (_chars.Length-1));
        return _chars[index];
    }
}