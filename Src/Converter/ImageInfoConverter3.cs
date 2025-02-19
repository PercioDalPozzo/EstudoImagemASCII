// using System.Text;
// using SixLabors.ImageSharp;
// using SixLabors.ImageSharp.PixelFormats;
//
// namespace EstudoImagemASCII;
//
// public class ImageInfoConverter
// {
//     private readonly Image<Rgba32> _image;
//
//     public ImageInfoConverter(Image<Rgba32> image)
//     {
//         _image = image;
//     }
//
//     public StringBuilder Convert(PixelConverter pixelConverter, int resolution)
//     {
//         var builder = new StringBuilder();
//         
//         // var novoHeight = resolution * _image.Height / 100;
//         // var novoWidth = resolution * _image.Width / 100;
//         //
//         // var yRangeBase = (decimal)_image.Height / novoHeight;
//         // var xRangeBase = (decimal)_image.Width / novoWidth;
//
//         var controlador = new ControladorIterator(_image.Height, _image.Width, resolution);
//         
//         for (int y = 0; y < controlador.NovoHeight; y++)
//         {
//             // var yInicio = (int)Math.Truncate(y * yRangeBase);
//             // var yFim = (int)Math.Truncate((y+1) * yRangeBase);
//             //
//             // if (yFim >= _image.Height)
//             //     yFim = _image.Height-1;
//
//             var (yInicio, yFim) = controlador.GetY(y);
//
//             for (int x = 0; x < controlador.NovoWidth; x++)
//             {
//                 // var xInicio = (int)Math.Truncate(x * xRangeBase);
//                 // var xFim = (int)Math.Truncate((x+1) * xRangeBase);
//                 //
//                 // if (xFim >= _image.Width)
//                 //     xFim = _image.Width-1;
//                 var (xInicio, xFim) = controlador.GetX(x);
//                 
//                 var pixelColor = BuildPixel(_image, yInicio, xInicio, yFim, xFim);
//                 
//                 builder.Append(pixelConverter.PixelToChar(pixelColor));
//             }
//             
//             builder.AppendLine("");
//         }
//         
//          return builder;
//     }
//
//     private Rgba32 BuildPixel(Image<Rgba32> image, int yInicio, int xInicio, int yFim, int xFim)
//     {
//         var pixels = new List<Rgba32>();
//         for (int y = yInicio; y <= yFim; y++)
//         {
//             for (int x = xInicio; x <= xFim; x++)
//             {
//                 pixels.Add(image[x, y]);
//             }
//         }
//         
//         return PixelMedio(pixels);
//     }
//
//     private Rgba32 PixelMedio(List<Rgba32> pixels)
//     {
//         if (pixels == null || pixels.Count == 0)
//         {
//             throw new ArgumentException("A lista de pixels vazia.", nameof(pixels));
//         }
//
//         byte CalcularMedia(Func<Rgba32, byte> seletor)
//         {
//             return (byte)(pixels.Sum(p => seletor(p)) / (float)pixels.Count);
//         }
//         
//         var r = CalcularMedia(p => p.R);
//         var g = CalcularMedia(p => p.G);
//         var b = CalcularMedia(p => p.B);
//         
//         return new Rgba32(r, g, b);
//     }
// }