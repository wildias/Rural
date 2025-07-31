using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Rural.ImageUtil
{
    public static class ImageUtil
    {
        /// <summary>
        /// Converte a imagem para uma string em Base64
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToBase64(this Image image, ImageFormat format)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }


            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Retorna uma lista com as 5 cores predominantes da imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        public static List<Color> CoresPredominantes(this Image imagem, bool ignorarEscalaCinza = false, bool ignorarBranco = false)
        {

            try
            {
                if (imagem == null) return null;

                var theBitMap = (Bitmap)imagem;
                var TenMostUsedColors = new List<Color>();
                var TenMostUsedColorIncidences = new List<int>();

                var dctColorIncidence = new Dictionary<int, int>();


                for (int row = 0; row < theBitMap.Size.Width; row++)
                {
                    for (int col = 0; col < theBitMap.Size.Height; col++)
                    {
                        var pixelColor = theBitMap.GetPixel(row, col).ToArgb();

                        if (Color.FromArgb(pixelColor).A < 8) continue;

                        if (ignorarEscalaCinza)
                        {
                            var c = Color.FromArgb(pixelColor);
                            var r = c.R;
                            var g = c.G;
                            var b = c.B;

                            if (r > 100 && g > 100 && b > 100)
                            {
                                continue;
                            }
                        }

                        if (ignorarBranco)
                        {
                            var c = Color.FromArgb(pixelColor);
                            if (c.R == 255 && c.G == 255 && c.B == 255)
                            {
                                continue;
                            }
                        }

                        if (dctColorIncidence.Keys.Contains(pixelColor))
                        {
                            dctColorIncidence[pixelColor]++;
                        }
                        else
                        {
                            dctColorIncidence.Add(pixelColor, 1);
                        }
                    }
                }

                var dctSortedByValueHighToLow = dctColorIncidence.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                var listaRetorno = new List<Color>();

                foreach (KeyValuePair<int, int> kvp in dctSortedByValueHighToLow.Take(5))
                {
                    listaRetorno.Add(Color.FromArgb(kvp.Key));
                }

                if (listaRetorno?.Count < 5)
                {
                    while (listaRetorno?.Count < 5)
                    {
                        var corAdd = listaRetorno.Last();

                        var r = corAdd.R > 20 ? corAdd.R - 20 : corAdd.R;
                        var g = corAdd.G > 20 ? corAdd.G - 20 : corAdd.G;
                        var b = corAdd.B > 20 ? corAdd.B - 20 : corAdd.B;

                        var novaCor = Color.FromArgb(r, g, b);

                        listaRetorno.Add(novaCor);
                    }
                }

                return listaRetorno;

            }
            catch
            {
                return null;
            }
        }

        public static List<Color> CoresPredominantesDistintas(this Image imagem, bool ignorarEscalaCinza = false, bool ignorarBranco = false)
        {
            try
            {
                if (imagem == null) return null;

                var theBitMap = (Bitmap)imagem;
                var dctColorIncidence = new Dictionary<Color, int>();

                for (int row = 0; row < theBitMap.Width; row++)
                {
                    for (int col = 0; col < theBitMap.Height; col++)
                    {
                        var pixelColor = theBitMap.GetPixel(row, col);

                        // Ignora pixels transparentes
                        if (pixelColor.A < 8) continue;

                        // Ignora tons de cinza se a opção estiver ativada
                        if (ignorarEscalaCinza && pixelColor.R > 100 && pixelColor.G > 100 && pixelColor.B > 100) continue;

                        // Ignora branco se a opção estiver ativada
                        if (ignorarBranco && pixelColor.R == 255 && pixelColor.G == 255 && pixelColor.B == 255) continue;

                        // Conta a incidência de cada cor
                        if (dctColorIncidence.ContainsKey(pixelColor))
                        {
                            dctColorIncidence[pixelColor]++;
                        }
                        else
                        {
                            dctColorIncidence.Add(pixelColor, 1);
                        }
                    }
                }

                // Ordena as cores pela incidência (do maior para o menor)
                var coresOrdenadas = dctColorIncidence.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

                // Retorna as três cores que mais aparecem na imagem, excluindo cores parecidas
                var coresPredominantes = new List<Color>();
                foreach (var cor in coresOrdenadas)
                {
                    if (!CoresParecidas(coresPredominantes, cor))
                    {
                        coresPredominantes.Add(cor);
                        if (coresPredominantes.Count == 10)
                            break; // Sai do loop quando encontrar as 3 cores distintas
                    }
                }
                return coresPredominantes;
            }
            catch
            {
                return null;
            }
        }


        private static bool CoresParecidas(List<Color> cores, Color novaCor)
        {
            foreach (Color cor in cores)
            {
                // Calcula a diferença entre as cores em termos de distância euclidiana no espaço de cores RGB
                double distancia = Math.Sqrt(Math.Pow(novaCor.R - cor.R, 2) + Math.Pow(novaCor.G - cor.G, 2) + Math.Pow(novaCor.B - cor.B, 2));

                // Define um limite para considerar as cores como parecidas
                double limiteDistancia = 100; // Ajuste conforme necessário

                // Se a distância entre as cores for menor que o limite, considera as cores como parecidas
                if (distancia < limiteDistancia)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Converte uma stringbase64 de volta para imagem
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static Image FromBase64(this string base64String)
        {

            try
            {

                if (string.IsNullOrEmpty(base64String)) return null;
                byte[] imageBytes = Convert.FromBase64String(base64String);
                if (imageBytes.Length < 200) return null;
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Converte uma string para um array de byte em base 64
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static byte[] ImageBase64ToArray(this string base64String)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    return new byte[1];
                }
                byte[] imageBytes = Convert.FromBase64String(base64String);
                if (imageBytes.Length < 360) return null;

                return imageBytes;
            }
            catch
            {
                return null;
            }


        }

        /// <summary>
        /// Converte a imagem do caminho para uma string em base 64
        /// </summary>
        /// <param name="CaminhoImg">Caminho da Imagem em um diretório</param>
        /// <param name="format">Formato em que a imagem será criada</param>
        /// <param name="redimencionar">Percentual de dimensão que a imagem será mantida</param>
        /// <returns></returns>
        public static string StringImageToBase64(string CaminhoImg, ImageFormat format, decimal redimencionar = 0, bool proporcao = false, bool altura = false)
        {
            try
            {
                string Retorno = "";

                Image image = Image.FromFile(CaminhoImg);

                Retorno = ImageToBase64(image, format, redimencionar, proporcao, altura);

                image.Dispose();

                return Retorno;
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Não deixa a imagem passar de 1200px X 800px
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        public static Image TamanhoMaximoPDV(this Image imagem, bool semCor = false)
        {
            try
            {
                if (imagem == null) return null;

                Image reduzida = RedimensionarImagem800x600(imagem);

                if (semCor)
                {
                    Image pnb = ConverterParaPretoBranco(reduzida);
                    return pnb;
                }

                return reduzida;

                //var altura = imagem.Height > imagem.Width;

                //if (!altura && imagem.Width >= 1200)
                //{
                //    return imagem.Redimensionar(1200, false, true);
                //}
                //else if (altura && imagem.Width >= 800)
                //{
                //    return imagem.Redimensionar(800, true, true);
                //}
                //else
                //{
                //    return imagem;
                //}

            }
            catch
            {
                return imagem;
            }

        }

        public static string ImageToBase64(Image image, ImageFormat format, decimal redimencionar = 0, bool proporcao = false, bool altura = false)
        {

            try
            {


                if (redimencionar > 0)
                {
                    if (proporcao)
                    {
                        var inteiro = (int)redimencionar;

                        image = image.Redimensionar(inteiro, altura);
                    }
                    else
                    {
                        image = image.Redimensionar(redimencionar);
                    }


                }

                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert Image to byte[]

                    image.Save(ms, format);

                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }

            }
            catch
            {
                return null;
            }

        }


        /// <summary>
        /// Transforma uma imagem em preto e branco
        /// </summary>
        /// <param name="Bmp"></param>
        /// <returns></returns>
        public static Image RemoverCores(this Image original)
        {

            try
            {
                if (original == null) return null;

                //create a blank bitmap the same size as original
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);
                //get a graphics object from the new image
                Graphics g = Graphics.FromImage(newBitmap);
                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                  {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
                  });
                //create some image attributes
                ImageAttributes attributes = new ImageAttributes();
                //set the color matrix attribute
                attributes.SetColorMatrix(colorMatrix);
                //draw the original image on the new image
                //using the grayscale color matrix
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                   0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                //dispose the Graphics object
                g.Dispose();
                return newBitmap;
            }
            catch
            {
                return original;
            }
        }

        public static Image ReverterCores(this Image original)
        {
            Bitmap pic = new Bitmap(original);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }

            return pic;
        }

        /// <summary>
        /// Rediciomensiona a imagem para o percentual desejado
        /// </summary>
        /// <param name="percentual">Percentual da imagem a ser mantido</param>
        /// <returns></returns>
        public static Image Redimensionar(this Image img, decimal percentual)
        {

            try
            {
                var wdOriginal = img.Width;
                var heOriginal = img.Height;

                var wdRed = (int)decimal.Round((wdOriginal / 100) * percentual, 0);
                var heRed = (int)decimal.Round((heOriginal / 100) * percentual, 0);
                if (wdRed <= 0 || heRed <= 0) return img;
                //LogPdv.Instance.Debug($"Imagem redimencionada! {percentual}%");

                return (new Bitmap(img, new Size(wdRed, heRed)));

            }
            catch
            {
                return img;
            }
        }
        /// <summary>
        /// Redimensiona a imagem para os atributos enviados
        /// </summary>
        /// <param name="largura">Largura em pixel</param>
        /// <param name="altura">Altura em pixel</param>
        /// <returns></returns>
        public static Image Redimensionar(this Image img, int largura, int altura)
        {

            try
            {
                if (img == null) return null;

                //LogPdv.Instance.Debug($"Imagem redimencionada! L:{largura} A:{altura}%");

                return (new Bitmap(img, new Size(largura, altura)));

            }
            catch
            {
                return img;
            }
        }
        /// <summary>
        /// Redimenciona altura ou largura da imagem mantendo a proporsão
        /// </summary>
        /// <param name="valor">Valor em pixel</param>
        /// <param name="altura">true:Altura false:Largura</param>
        /// <returns></returns>
        public static Image Redimensionar(this Image img, int valor, bool altura, bool manterProporcao = true)
        {
            try
            {
                if (img == null) return null;
                decimal alturaR = 0;
                decimal larguraR = 0;

                var wdOriginal = (decimal)img.Width;
                var heOriginal = (decimal)img.Height;


                if (manterProporcao)
                {
                    if (altura)
                    {
                        alturaR = valor;
                        larguraR = (int)decimal.Round(valor * (wdOriginal / heOriginal), 0);
                    }
                    else
                    {
                        larguraR = valor;

                        var pDif = ((heOriginal / wdOriginal) * 100);

                        var aaltura = (larguraR / 100) * pDif;

                        //alturaR = 

                        alturaR = (int)aaltura;
                    }
                }
                else
                {
                    if (altura)
                    {
                        alturaR = valor;
                        larguraR = (int)wdOriginal;

                    }
                    else
                    {
                        larguraR = valor;
                        alturaR = (int)heOriginal;

                    }
                }

                return (new Bitmap(img, new Size((int)larguraR, (int)alturaR)));

            }
            catch
            {
                return img;
            }
        }

        /// <summary>
        /// Retorna um Icon a partir da imagem enviada
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Icon GerarIcone(this Image img)
        {
            try
            {

                var myBitmap = new Bitmap(img);

                // Get an Hicon for myBitmap.
                var Hicon = myBitmap.GetHicon();

                // Create a new icon from the handle. 
                var newIcon = Icon.FromHandle(Hicon);

                // Set the form Icon attribute to the new icon.

                myBitmap.Dispose();

                return newIcon;
            }
            catch
            {
                return null;
            }

        }
        /// <summary>
        /// Retorna um Icon a partir da imagem enviada
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Icon GerarIcone(this Bitmap img)
        {
            try
            {

                var myBitmap = img;

                // Get an Hicon for myBitmap.
                var Hicon = myBitmap.GetHicon();

                // Create a new icon from the handle. 
                var newIcon = Icon.FromHandle(Hicon);

                // Set the form Icon attribute to the new icon.

                return newIcon;

            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Converte um texto para imagem
        /// </summary>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static Image ToImage(this string text, Font font, Color textColor, Color backColor)
        {
            try
            {

                //first, create a dummy bitmap just to get a graphics object
                Image img = new Bitmap(1, 1);
                Graphics drawing = Graphics.FromImage(img);

                //measure the string to see how big the image needs to be
                SizeF textSize = drawing.MeasureString(text, font);

                //free up the dummy image and old graphics object
                img.Dispose();
                drawing.Dispose();

                //create a new image of the right size
                img = new Bitmap((int)textSize.Width, (int)textSize.Height);

                drawing = Graphics.FromImage(img);

                //paint the background
                drawing.Clear(backColor);

                //create a brush for the text
                Brush textBrush = new SolidBrush(textColor);

                drawing.DrawString(text, font, textBrush, 0, 0);

                drawing.Save();

                textBrush.Dispose();
                drawing.Dispose();

                return img;

            }
            catch
            {
                return null;
            }

        }

        public static Image JuntarImagens(params Image[] imagens)
        {

            //lê todas as imagens para a memória

            Bitmap imagemFinal = null;

            try
            {
                int width = imagens.Sum(n => (n?.Width ?? 0));
                int height = imagens.Max(n => (n?.Height ?? 0));

                //cria um bitmap para tratar a imagem combinada
                imagemFinal = new Bitmap(width + 4, height);

                //Obtem o objeto gráfico da imagem 
                using (var g = Graphics.FromImage(imagemFinal))
                {
                    //define a cor de fundo
                    g.Clear(Color.Transparent);

                    //percorre imagem por imagem e gera uma unica imagem final
                    int offset = 0;
                    foreach (Bitmap image in imagens)
                    {
                        if (image == null) continue;

                        g.DrawImage(image,
                          new Rectangle(offset, 0, image.Width, image.Height));
                        offset += (image.Width + 4);
                    }
                }

                return imagemFinal;
            }
            catch (Exception ex)
            {
                if (imagemFinal != null)
                    imagemFinal.Dispose();
                return null;
            }
            finally
            {
                //limpa a memória
                foreach (Bitmap image in imagens)
                {
                    if (image == null) continue;
                    image.Dispose();
                }
            }

        }

        public static async Task<Image> GetImageAsync(string url)
        {
            try
            {
                var tcs = new TaskCompletionSource<Image>();
                Image webImage = null;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                    .ContinueWith(task =>
                    {
                        var webResponse = (HttpWebResponse)task.Result;
                        Stream responseStream = webResponse.GetResponseStream();
                        if (webResponse.ContentEncoding.ToLower().Contains("gzip"))
                            responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                        else if (webResponse.ContentEncoding.ToLower().Contains("deflate"))
                            responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

                        if (responseStream != null) webImage = Image.FromStream(responseStream);
                        tcs.TrySetResult(webImage);
                        webResponse.Close();
                        responseStream.Close();
                    });

                return tcs.Task.Result;
            }
            catch (Exception erro)
            {
                return null;
            }
        }

        public static Image RedimensionarImagem800x600(Image img)
        {
            if (img == null) return null;

            int altura = 800;
            int largura = 600;

            Bitmap novaImagem = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, largura, altura);
            }
            return novaImagem;
        }

        public static Image ConverterParaPretoBranco(Image img)
        {
            if (img == null) return null;

            Bitmap bmp = new Bitmap(img.Width, img.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = ((Bitmap)img).GetPixel(x, y);
                    int cinza = (int)((pixel.R + pixel.G + pixel.B) / 3);
                    Color novaCor = Color.FromArgb(cinza, cinza, cinza);
                    bmp.SetPixel(x, y, novaCor);
                }
            }

            return bmp;
        }
    }
}
