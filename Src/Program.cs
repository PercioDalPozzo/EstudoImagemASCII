using SixLabors.ImageSharp; 
using SixLabors.ImageSharp.PixelFormats; 
using System.Text;
using EstudoImagemASCII;

class Program
{
    static void Main()
    {
        string imagePath = "../../../../eu.jpg";
        string pathDestino = "../../../../";
        
        const int resolucao = 50;
        //const int chars = 2;
        
        using (var image = Image.Load<Rgba32>(imagePath))
        {
            //Converter(image, chars, resolucao, pathDestino);
            Converter(image, 2, resolucao, pathDestino);
            Converter(image, 5, resolucao, pathDestino);
            Converter(image, 10, resolucao, pathDestino);
            Converter(image, 20, resolucao, pathDestino);
        }
       
        Console.WriteLine("Feito!");
    }

    private static void Converter(Image<Rgba32> image, int chars, int resolucao, string pathDestino)
    {
        var builder = new ImageConverter(image).Convert(new PixelConverter(new Luminosidade_R21_G71_B01(),chars), resolucao);
        File.WriteAllText($"{pathDestino}Imagem1 chars{chars} resolucao{resolucao} - {DateTime.Now.ToString("hh_mm_ss")}.txt", builder.ToString());
        
        var builder2 = new ImageConverter(image).Convert(new PixelConverter(new Luminosidade_R03_G59_B11(),chars), resolucao);
        File.WriteAllText($"{pathDestino}Imagem2 chars{chars} resolucao{resolucao} - {DateTime.Now.ToString("hh_mm_ss")}.txt", builder2.ToString());
        
    }
}

