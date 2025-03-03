using System;
using System.IO;
using SixLabors.ImageSharp; 
using SixLabors.ImageSharp.PixelFormats; 
using System.Text;
using EstudoImagemASCII;

class Program
{
    static void Main()
    {
        var caminhoImagem = "../../../../eu.jpg";
        var caminhoDestino = "../../../../";
        const int resolucao = 100;
        
        using (var image = Image.Load<Rgba32>(caminhoImagem))
        {
            Converter(image, 2, resolucao, caminhoDestino);
            Converter(image, 5, resolucao, caminhoDestino);
            Converter(image, 10, resolucao, caminhoDestino);
            Converter(image, 20, resolucao, caminhoDestino);
        }
       
        Console.WriteLine("Feito!");
    }

    private static void Converter(Image<Rgba32> image, int chars, int resolucao, string pathDestino)
    {
        var builder = new ImageConverter(image).Convert(new PixelConverter(new Luminosidade_R21_G71_B01(),chars), resolucao);
        File.WriteAllText($"{pathDestino}Imagem chars{chars} resolucao{resolucao} - {DateTime.Now.ToString("hh_mm_ss")}.txt", builder.ToString());
    }
}

