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
//         var novoHeight = resolution * _image.Height / 100;
//         var novoWidth = resolution * _image.Width / 100;
//
//         var yRangeBase = (decimal)_image.Height / novoHeight;
//         var xRangeBase = (decimal)_image.Width / novoWidth;
//
//         
//         var ySobra = 0m;
//         var yInicio = 0;
//         var yFim = 0;
//         for (int y = 0; y < novoHeight; y++)
//         {
//             var yRange = (int)Math.Round(yRangeBase);
//             ySobra += yRange - yRangeBase;
//             
//             var ytem = (int)Math.Truncate(ySobra);
//             if (ytem >= 1)
//             {
//                 yRange -= ytem;
//                 ySobra -= ytem;
//             }
//             yFim = yInicio + yRange-1;
//             if (yFim >= _image.Height)
//                 yFim = _image.Height-1;
//             
//             
//             var xSobra = 0m;
//             var xInicio = 0;
//             var xFim = 0;
//             for (int x = 0; x < novoWidth; x++)
//             {
//                 var xRange = (int)Math.Round(xRangeBase);
//                 xSobra += xRange - xRangeBase;
//
//                 var xtem = (int)Math.Truncate(xSobra);
//                 if (xtem >= 1)
//                 {
//                     xRange -= xtem;
//                     xSobra -= xtem;
//                 }
//                     
//                 xFim = xInicio + xRange-1;
//                 if (xFim >= _image.Width)
//                     xFim = _image.Width-1;
//                 
//             
//                 var pixelColor = BuildPixel(_image, yInicio, xInicio, yFim, xFim);
//                 
//                 builder.Append(pixelConverter.PixelToChar(pixelColor));
//
//                 xInicio = xFim+1;
//                 
//                 if (xInicio > _image.Width)
//                     xRange = _image.Width-1;                                
//                  
//             }
//             
//             yInicio = yFim+1;
//             if (yInicio > _image.Height)
//                 yRange = _image.Height - 1;
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