using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using Windows.Storage;

namespace WeChatRedPacket.Orc
{
    public class TesseractOCR
    {
        /*public string OCR(Bitmap imagePath)
        {
            //Tesseract.Page    chi_sim为中文训练数据包  
            Page page = new TesseractEngine(AppDomain.CurrentDomain.BaseDirectory + @"\tessdata", "chi_sim", EngineMode.Default).Process(PixConverter.ToPix(imagePath));
            //释放程序对图片的占用
            imagePath.Dispose();

            //打印识别率
            Console.WriteLine(String.Format("{0:P}", page.GetMeanConfidence()));

            //打印识别文本 //替换'/n'为'(空)'//替换'(空格)'为'(空)'
            string s = page.GetText().Replace("\n", "").Replace(" ", "");
            Console.WriteLine(s);
            return s;
        }*/
        string path;
        public TesseractOCR() 
        {
            path = ApplicationData.Current.LocalFolder.Path;
            Debug.WriteLine($"--- > ORC_DATA文件存储路径 {path}");

        }
        // 复制数据库文件到本地
        public static async Task<bool> CheckDataFile()
        {
            if (await ApplicationData.Current.LocalFolder.TryGetItemAsync("chi_sim.traineddata") == null)
            {
                Debug.Print("--- > Sqlite文件不存在,从资源文件中复制过去");
                StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/db/chi_sim.traineddata"));
                if (file != null)
                {
                    StorageFile storageFile = await file.CopyAsync(ApplicationData.Current.LocalFolder);
                    //Debug.Print("--- > 复制完成");
                    return storageFile != null;
                    // 再次判断文件是否在App Data文件夹中了
                    // if (await ApplicationData.Current.LocalFolder.TryGetItemAsync("PubgDatabase.db") == null)
                    // {
                }
                // 不需要如果没此文件会报错 Debug.Print($"--- > 包中没有ms-appx:///Assets/db/{dtataBaseName}此文件");
                return false;
            }
            return true;
        }
        public async Task<string> OCR(string imagePath)
        {
            string text = "";
            if (await CheckDataFile()) 
            {
           
            
                //using (var engine = new TesseractEngine(path, "chi_sim", EngineMode.Default))
                using (var engine = new TesseractEngine(path, "chi_sim", EngineMode.Default))
                {
                    using (Pix img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            text = page.GetText();
                            Debug.WriteLine($"识别率 --- >  {page.GetMeanConfidence()}");

                            Debug.WriteLine($"文本 --- >  {text}");
                        }
                    }
                }
            }
            return text;

        }

        public async Task<String> OCRAsync(byte[] imageBytes)
        {

            String text = "";
            if (await CheckDataFile())
            {


                //using (var engine = new TesseractEngine(path, "chi_sim", EngineMode.Default))
                using (var engine = new TesseractEngine(path, "chi_sim", EngineMode.Default))
                {
                   
                    using (Pix img = Pix.LoadFromMemory(imageBytes))
                    {
                        using (var page = engine.Process(img))
                        {
                            text = page.GetText();
                            //Debug.WriteLine($"识别到的文本 --- > {text}   识别率 --- >  {page.GetMeanConfidence()}");
                            //Debug.WriteLine($"识别率 --- >  {page.GetMeanConfidence()}");
                        }
                    }
                }
            }
            return text;

        }
    }
}
