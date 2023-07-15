using DolbySoundBeta.Dao;
using Microsoft.UI;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeChatRedPacket.Bean;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.WindowManagement;
using WinRT.Interop;
using WeChatRedPacket.Orc;
using System.Drawing;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using Window = Microsoft.UI.Xaml.Window;
using System.Text;
using OpenCvSharp.ML;
using Microsoft.VisualBasic;
using ABI.Microsoft.UI.Xaml;
using RoutedEventArgs = Microsoft.UI.Xaml.RoutedEventArgs;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WeChatRedPacket
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.SystemBackdrop = new MicaBackdrop();

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);

        }

        private async void HandleCheck(object sender, RoutedEventArgs e)
        {


            if (sender is ToggleButton toggleButton)
            {
                string name = toggleButton.Name;
                Debug.WriteLine($"ButtonName --- > {name}");

                RedPacket redPacket = null;
                switch (name)
                {
                    case "CheckBox_10_5":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(10, 5);
                        //CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_10_7":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(10, 7);
                        CheckBox_10_5.IsChecked = false;
                        //CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_20_5":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(20, 5);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        //CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_20_7":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(20, 7);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        //CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_30_5":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(30, 5);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        //CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_30_7":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(30, 7);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        //CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_40_5":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(40, 5);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        //CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_40_7":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(40, 7);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        //CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_50_5":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(50, 5);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        //CheckBox_50_5.IsChecked = false;
                        CheckBox_50_7.IsChecked = false;
                        break;

                    case "CheckBox_50_7":
                        redPacket = await MySqLite.FindAllRedPacketDatasBySumNumber(50, 7);
                        CheckBox_10_5.IsChecked = false;
                        CheckBox_10_7.IsChecked = false;
                        CheckBox_20_5.IsChecked = false;
                        CheckBox_20_7.IsChecked = false;
                        CheckBox_30_5.IsChecked = false;
                        CheckBox_30_7.IsChecked = false;
                        CheckBox_40_5.IsChecked = false;
                        CheckBox_40_7.IsChecked = false;
                        CheckBox_50_5.IsChecked = false;
                        //CheckBox_50_7.IsChecked = false;
                        break;

                }

                if (redPacket != null)
                {
                    slider_0.Value = redPacket.zero;
                    slider_1.Value = redPacket.one;
                    slider_2.Value = redPacket.two;
                    slider_3.Value = redPacket.three;
                    slider_4.Value = redPacket.four;
                    slider_5.Value = redPacket.five;
                    slider_6.Value = redPacket.six;
                    slider_7.Value = redPacket.seven;
                    slider_8.Value = redPacket.eight;
                    slider_9.Value = redPacket.nine;
                }

            }
            /*int value = (int)new_data_1.Value;
            data5_1.Text = value + "";
            Debug.WriteLine($"是否选中 --- > {ToggleButton_10_5.IsChecked}");*/
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {

        }
        // 添加数据
        private void Button_Click_AddData(object sender, RoutedEventArgs e)
        {
            int newDataSum = (int)new_data_sum.Value;
            int newDataNumber = (int)new_data_number.Value;

            int[] ints = new int[]
            {
               (int)new_data_1.Value,
               (int)new_data_2.Value,
               (int)new_data_3.Value,
               (int)new_data_4.Value,
               (int)new_data_5.Value,
               (int)new_data_6.Value,
               (int)new_data_7.Value,
            };

            // 检测是否正确
            if (newDataSum != 10 && newDataSum != 20 && newDataSum != 30 && newDataSum != 40 && newDataSum != 50 && newDataSum != 60)
            {
                Debug.WriteLine($"添加数据失败,金额不对 ---> {newDataSum}");
                return;
            }

            if (newDataNumber != 5 && newDataNumber != 7)
            {
                Debug.WriteLine($"添加数据失败,包数不对 ---> {newDataNumber}");
                return;
            }

            foreach (int i in ints)
            {
                if (i > 9 || i < 0)
                {
                    Debug.WriteLine($"添加数据失败,位数数不对 ---> {i}");
                    return;
                }
            }

            RedPacket redPacket = new RedPacket();
            redPacket.sum = newDataSum;
            redPacket.number = newDataNumber;
            for (int i = 0; i < ints.Length; i++)
            {
                switch (ints[i])
                {
                    case 0:
                        redPacket.zero += 1;
                        break;

                    case 1:
                        redPacket.one += 1;
                        break;

                    case 2:
                        redPacket.two += 1;
                        break;

                    case 3:
                        redPacket.three += 1;
                        break;

                    case 4:
                        redPacket.four += 1;
                        break;

                    case 5:
                        redPacket.five += 1;
                        break;

                    case 6:
                        redPacket.six += 1;
                        break;

                    case 7:
                        redPacket.seven += 1;
                        break;

                    case 8:
                        redPacket.eight += 1;
                        break;

                    case 9:
                        redPacket.nine += 1;
                        break;

                    default: break;
                }
            }
            List<RedPacket> redPackets = new List<RedPacket>();
            redPackets.Add(redPacket);
            MySqLite.Insert(redPackets);

            new_data_sum.Value = -1;
            new_data_number.Value = -1;
            new_data_1.Value = -1;
            new_data_2.Value = -1;
            new_data_3.Value = -1;
            new_data_4.Value = -1;
            new_data_5.Value = -1;
            new_data_6.Value = -1;
            new_data_7.Value = -1;
        }

        private async void Button_Click_img(object sender, RoutedEventArgs e)
        {
            // Clear previous returned filePath name, if it exists, between iterations of this scenario
            string Text = "";
            string path = "";
            // Create a folder picker
            FolderPicker openPicker = new Windows.Storage.Pickers.FolderPicker();

            // Retrieve the window handle (HWND) of the current WinUI 3 window.
            //var window = GetWindowForElement(this.Content);
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

            // Initialize the folder picker with the window handle (HWND).
            WinRT.Interop.InitializeWithWindow.Initialize(openPicker, hWnd);

            // Set options for your folder picker
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.FileTypeFilter.Add("*");

            // Open the picker for the user to pick a folder
            StorageFolder folder = await openPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                Text = "Picked folder: " + folder.Name;
                path = folder.Path;
            }
            else
            {
                Text = "Operation cancelled.";
                Debug.WriteLine($"用户已取消寻择文件夹 --- > {Text}\n选择的路径夹是 --- > {path}");
                return;
            }
            Debug.WriteLine($"选择的文件夹是 --- > {Text}\n选择的路径夹是 --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // 处理每个文件
                Debug.WriteLine($"文件 --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

                // 1、 计算红包金额有效区域
                //  截图总宽度减80%的无效面积
                int Width = (int)((float)bitmap.Width * (1f - (80f / 100f)));
                //  截图总高度减顶部30%的无效面积，及减去总高度底部的10%的无效面积
                int topHeight = (int)((float)bitmap.Height * (1f - (30f / 100f)));
                int endHeight = (int)((float)bitmap.Height * (1f - (10f / 100f)));
                //  计算有效的总高度 = 总高度 - ((顶部的无效高度) + (底部的无效高度))
                int Height = bitmap.Height - ((bitmap.Height - topHeight) + (bitmap.Height - endHeight));
                // 起始坐标X = 总宽度 - 有效宽度，起始坐标Y = 总高度 - 去掉顶部后的有效高度
                int X = bitmap.Width - Width;
                int Y = bitmap.Height - topHeight;
                Debug.WriteLine($"红包金额有效面积 Width --- > {Width} Height --- > {Height}");
                Debug.WriteLine($"截图起始坐标X --- > {X} 截图起始坐标Y--- > {Y}");

                // 2、裁剪成只有金额的小图
                Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
                // 创建空白画布，大小为裁剪区域大小
                Bitmap result = new Bitmap(Width, Height);
                // 创建Graphics对象，并指定要在result（目标图片画布）上绘制图像
                Graphics graphics = Graphics.FromImage(result);
                // 使用Graphics对象把原图指定区域图像裁剪下来并填充进刚刚创建的空白画布
                graphics.DrawImage(bitmap, new Rectangle(0, 0, Rectangle.Width, Rectangle.Height), Rectangle, GraphicsUnit.Pixel);
                //result.Save("C:/Users/hefan/Desktop/wuqi1.png");

                // 3、进行二值化处理，让图片只有2种颜色
                Mat mat = BitmapConverter.ToMat(result);
                Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
                Mat result1 = mat.Threshold(0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/wuqi2.png");

                // 4、图片膨胀、腐蚀处理 核函数
                Mat element1 = new Mat();
                OpenCvSharp.Size size1 = new OpenCvSharp.Size(30, 20);
                element1 = Cv2.GetStructuringElement(MorphShapes.Rect, size1);
                //Mat element2 = new Mat();
                //OpenCvSharp.Size size2 = new OpenCvSharp.Size(15, 9);
                //element2 = Cv2.GetStructuringElement(MorphShapes.Rect, size2);

                // 4.1、膨胀，凸显轮廓(不需要进行膨胀，不做效果差不多)
                /*Mat dilation = new Mat();
                Cv2.Dilate(mat3, dilation, element2);*/

                // 5、腐蚀一次去掉细节，让文件变大
                Mat mat2 = new Mat();
                Cv2.Erode(result1, mat2, element1);

                // 6、 查找轮廓
                OpenCvSharp.Point[][] contours;
                OpenCvSharp.Rect biggestContourRect = new OpenCvSharp.Rect();

                Cv2.FindContours(mat2, out contours, out HierarchyIndex[] hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);


                // 7. 轮询所有轮廓点，筛选那些面积小的
                int s = 1;
                StringBuilder sb = new StringBuilder();
                foreach (OpenCvSharp.Point[] contour in contours)
                {

                    double area = Cv2.ContourArea(contour);
                    //  面积小的都筛选掉
                    if (area < 1000)
                    {
                        continue;
                    }
                    //  轮廓近似，作用很小
                    double epsilon = 0.001 * Cv2.ArcLength(contour, true);
                    //  找到最小的矩形
                    biggestContourRect = Cv2.BoundingRect(contour);
                    if (biggestContourRect.Height > (biggestContourRect.Width * 1.2))
                    {
                        continue;
                    }
                    // 在原图上画出矩形
                    mat.Rectangle(biggestContourRect, Scalar.LightGreen, 2);
                    //Debug.WriteLine($"X --- > {biggestContourRect.X}\tY --- > {biggestContourRect.Y}\tSize --- > {biggestContourRect.Width} * {biggestContourRect.Height}");

                    // 裁剪出矩形
                    Mat mat4 = OpenCVToCut(mat, biggestContourRect);
                    //mat4.SaveImage($"C:/Users/hefan/Desktop/{s}.png");
                    s++;
                    // 将每个矩形进行文字识别，然后添加到StringBuilder
                    string iamegText = await tesseractOCR.OCRAsync(mat4.ToBytes());
                    //Debug.WriteLine($"找到文本 --->  {iamegText}");
                    sb.Append(iamegText);
                }
                //Cv2.ImShow("SSS", mat);

                
                String text = sb.ToString();
                if (text == null) 
                {
                    await FailedFileSave(file, "未知错误");
                    continue;
                }
                // text =  " 10.34元5.1 7元\n9.31元 5.17 元 5.18\n元  5.17元 5.1 9元  " ;
                //Debug.WriteLine($"识别到的原始文本 --- >  {text}");
                String v = text.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(" ", "");
                //v = v.Replace("元","元,"); // 由于string转float小数点为0的不会保留，
                Debug.WriteLine($"处理后的文本 --->  {v}");
                v = v.Remove(v.Length - 1);
                String[] strings = v.Split("元");
               // Debug.WriteLine($"Length --->  {strings.Length}");


                // 字符串转float
                float[] price = toArr(strings);
                if (price == null)
                {
                    await FailedFileSave(file, "识别失败");
                    continue;
                }

                // 判断是否不是5包或者7包
                if (price.Length != 5 && price.Length != 7)
                {
                    await FailedFileSave(file, "包数不对");
                    Debug.WriteLine($"红包数量处理失败 ---> {file} 识别到的红包数量--- > {price.Length}");
                    continue;
                }

                Decimal sum = 0;
                // 计算金额是否正确
                for (int i = 0; i < price.Length; i++)
                {
                    sum += (decimal)price[i];
                    
                }
                //Debug.WriteLine($"总金额 ---> {sum}");
                if (sum != 10 && sum != 20 && sum != 30 && sum != 40 && sum != 50 && sum != 60)
                {
                    await FailedFileSave(file, "红包总金额不对");
                    Debug.WriteLine($"红包总金额不对 ---> {file} 识别到的红包总金额不对--- > {sum}");
                    continue;
                }
                

                RedPacket redPacket = new RedPacket();
                redPacket.sum = (long)sum;
                redPacket.number = (int)price.Length;
                for (int i = 0; i < price.Length; i++)
                {
                    
                    
                    //string v1 = price[i].ToString();
                    string v1 = price[i].ToString("F2");
                    Debug.WriteLine($"金额 ---> {v1}");
                    switch (v1.Substring(v1.Length - 1, 1)) 
                    {
                        case "0":
                            redPacket.zero++;
                        break;
                        case "1":
                            redPacket.one++;
                        break;
                        case "2":
                            redPacket.two++;
                        break;
                        case "3":
                            redPacket.three++;
                        break;
                        case "4":
                            redPacket.four++;
                        break;
                        case "5":
                            redPacket.five++;
                        break;
                        case "6":
                            redPacket.six++;
                        break;
                        case "7":
                            redPacket.seven++;
                        break;
                        case "8":
                            redPacket.eight++;
                        break;
                        case "9":
                            redPacket.nine++;
                        break;
                                
                    }
                    

                }
                
                
                MySqLite.Insert(redPacket);
                Debug.WriteLine($"识别成功 ---> {file} 红包内容 --- > {redPacket.ToString()}");
            }

            
        }

        private static async Task FailedFileSave(string filePath, string TAG)
        {
            StorageFile imageFile = await StorageFile.GetFileFromPathAsync(filePath);
            // 获取图片的父目录
            StorageFolder storageFolder = await imageFile.GetParentAsync();
            string ParentPath = storageFolder.Path;
            string failedPath = ParentPath + $"\\{TAG}\\";
            if (!Directory.Exists(failedPath))
            {
                Directory.CreateDirectory(failedPath);
            }
            // 复制当前识别失败的图片到指定目录
            File.Copy(filePath, failedPath + imageFile.Name, true);
        }

        /**
         * 
         * 
         */
        private async void Button_Click_img1(object sender, RoutedEventArgs e)
        {
            // Clear previous returned filePath name, if it exists, between iterations of this scenario
            string Text = "";
            string path = "";
            // Create a folder picker
            FolderPicker openPicker = new Windows.Storage.Pickers.FolderPicker();

            // Retrieve the window handle (HWND) of the current WinUI 3 window.
            //var window = GetWindowForElement(this.Content);
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

            // Initialize the folder picker with the window handle (HWND).
            WinRT.Interop.InitializeWithWindow.Initialize(openPicker, hWnd);

            // Set options for your folder picker
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.FileTypeFilter.Add("*");

            // Open the picker for the user to pick a folder
            StorageFolder folder = await openPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                Text = "Picked folder: " + folder.Name;
                path = folder.Path;
            }
            else
            {
                Text = "Operation cancelled.";
            }
            Debug.WriteLine($"选择的文件夹是 --- > {Text}\n选择的路径夹是 --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // 处理每个文件
                Debug.WriteLine($"文件 --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

                //  计算红包金额有效区域
                //  截图总宽度减80%的无效面积
                int Width = (int)((float)bitmap.Width * (1f - (80f / 100f)));
                //  截图总高度减顶部30%的无效面积，及减去总高度底部的10%的无效面积
                int topHeight = (int)((float)bitmap.Height * (1f - (30f / 100f)));
                int endHeight = (int)((float)bitmap.Height * (1f - (10f / 100f)));
                //  计算有效的总高度 = 总高度 - ((顶部的无效高度) + (底部的无效高度))
                int Height = bitmap.Height - ((bitmap.Height - topHeight) + (bitmap.Height - endHeight));

                // 起始坐标X = 总宽度 - 有效宽度，起始坐标Y = 总高度 - 去掉顶部后的有效高度
                int X = bitmap.Width - Width;
                int Y = bitmap.Height - topHeight;
                Debug.WriteLine($"红包金额有效面积 Width --- > {Width} Height --- > {Height}");
                Debug.WriteLine($"截图起始坐标X --- > {X} 截图起始坐标Y--- > {Y}");

                Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
                // 创建空白画布，大小为裁剪区域大小
                Bitmap result = new Bitmap(Width, Height);
                // 创建Graphics对象，并指定要在result（目标图片画布）上绘制图像
                Graphics graphics = Graphics.FromImage(result);
                // 使用Graphics对象把原图指定区域图像裁剪下来并填充进刚刚创建的空白画布
                graphics.DrawImage(bitmap, new Rectangle(0, 0, Rectangle.Width, Rectangle.Height), Rectangle, GraphicsUnit.Pixel);
                //result.Save("C:/Users/hefan/Desktop/wuqi1.png");Screenshot_20230713-005444_WeChat
                Mat mat = BitmapConverter.ToMat(result);
                Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
                Mat result1 = mat.Threshold(0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/wuqi2.png");



                String text = await tesseractOCR.OCRAsync(result1.ToBytes());
                //String text =  " 10.34元5.1 7元\n9.31元 5.17 元 5.18\n元  5.17元 5.1 9元  " ;
                Debug.WriteLine($"识别到的原始文本 --- >  {text}");
                String v = text.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(" ", "");
                Debug.WriteLine($"处理后的文本 --->  {v}");
                v = v.Remove(v.Length - 1);
                String[] strings = v.Split("元");
                Debug.WriteLine($"Length --->  {strings.Length}");



                // 字符串转float
                float[] price = toArr(strings);
                if (price == null)
                {
                    await FailedFileSave(file, result1, "识别失败");

                    continue;
                }


                // 判断是否不是5包或者7包
                if (price.Length != 5 && price.Length != 7)
                {
                    await FailedFileSave(file, result1, "包数不对");
                    Debug.WriteLine($"红包数量处理失败 ---> {file} 识别到的红包数量--- > {price.Length}");
                    continue;
                }

                Decimal sum = 0;
                // 计算金额是否正确
                for (int i = 0; i < price.Length; i++)
                {
                    sum += (decimal)price[i];
                }
                Debug.WriteLine($"总金额 ---> {sum}");
                if (sum != 10 && sum != 20 && sum != 30 && sum != 40 && sum != 50 && sum != 60)
                {
                    await FailedFileSave(file, result1, "金额不对");
                    Debug.WriteLine($"红包总金额不对 ---> {file} 识别到的红包总金额不对--- > {sum}");
                    continue;
                }

                Debug.WriteLine($"识别成功 ---> {file} 金额 --- > {sum}");
            }


        }

       
        private static async Task FailedFileSave(string path, Mat mat, string TAG)
        {
            /**
             * path 源文件存储路径
             * mat  二值化截取后的图片
             * TAG  截取后的图片要存储到的文件夹
             */
            Debug.WriteLine($"path ---> {path} TAG--- > {TAG}");
            StorageFile imageFile = await StorageFile.GetFileFromPathAsync(path);
            // 获取图片的父目录
            StorageFolder storageFolder = await imageFile.GetParentAsync();
            string ParentPath = storageFolder.Path;
            string failedPath = ParentPath + $"\\{TAG}\\";
            Debug.WriteLine($"failedPath ---> {failedPath} ");
            if (!Directory.Exists(failedPath))
            {
                Directory.CreateDirectory(failedPath);
            }
            failedPath = ParentPath + $"\\{TAG}\\{imageFile.Name}";
            // 复制当前识别失败的图片到指定目录
            //File.Copy(path, failedPath + imageFile.Name, true);
            mat.SaveImage(failedPath);
        }

        private static float[] toArr(String[] strings)
        {
            float[] price = new float[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                try
                {
                    price[i] = float.Parse(strings[i]);
                    //Debug.WriteLine($"字符串转换为数字金额 --->  {price[i]}");
                }
                catch
                {
                    //await FailedFileSave(file,"识别失败");
                    Debug.WriteLine($"金额处理失败--- > {strings[i]}");
                    return null;
                }

            }
            return price;
        }

        // 查找图片中的文字
        private async void Button_Click_FindTextByImage(object sender, RoutedEventArgs e)
        {
            // Clear previous returned filePath name, if it exists, between iterations of this scenario
            string Text = "";
            string path = "";
            // Create a folder picker
            FolderPicker openPicker = new Windows.Storage.Pickers.FolderPicker();

            // Retrieve the window handle (HWND) of the current WinUI 3 window.
            //var window = GetWindowForElement(this.Content);
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

            // Initialize the folder picker with the window handle (HWND).
            WinRT.Interop.InitializeWithWindow.Initialize(openPicker, hWnd);

            // Set options for your folder picker
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.FileTypeFilter.Add("*");

            // Open the picker for the user to pick a folder
            StorageFolder folder = await openPicker.PickSingleFolderAsync();
            if (folder != null && folder.Path != null)
            {
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                Text = "Picked folder: " + folder.Name;
                path = folder.Path;
            }
            else
            {
                Text = "已经取消操作";
            }
            
            Debug.WriteLine($"选择的文件夹是 --- > {Text}\n选择的路径夹是 --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // 处理每个文件
                Debug.WriteLine($"文件 --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

              

                Mat mat = BitmapConverter.ToMat(bitmap);
                Mat mat1 = new Mat();
                Mat mat2 = new Mat();
                Cv2.CvtColor(mat, mat1, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(mat1,mat2, 0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/二值化后.png");

                // 3. 膨脹和腐蝕操作的核函數
                Mat element1 = new Mat();
                OpenCvSharp.Size size1 = new OpenCvSharp.Size(15, 9);
                element1 = Cv2.GetStructuringElement(MorphShapes.Rect, size1);

                //4. 膨胀，凸显轮廓
                /*Mat dilation = new Mat();
                Cv2.Dilate(mat3, dilation, element2);*/

                //5. 腐蚀一次去掉细节，让文件变大
                Mat mat3 = new Mat();
                Cv2.Erode(mat2, mat3, element1);



                // 1. 查找轮廓
                OpenCvSharp.Point[][] contours;
                OpenCvSharp.Rect biggestContourRect = new OpenCvSharp.Rect();

                Cv2.FindContours(mat3, out contours, out HierarchyIndex[] hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

                int i = 1;
                // 2. 筛选那些面积小的
                foreach (OpenCvSharp.Point[] contour in contours)
                {
                   
                    double area = Cv2.ContourArea(contour);
                    //面积小的都筛选掉
                    if (area < 1000)
                    {
                        continue;
                    }
                    //轮廓近似，作用很小
                    double epsilon = 0.001 * Cv2.ArcLength(contour, true);
                    //找到最小的矩形
                    biggestContourRect = Cv2.BoundingRect(contour);
                    if (biggestContourRect.Height > (biggestContourRect.Width * 1.2))
                    {
                        continue;
                    }
                    
                    mat.Rectangle(biggestContourRect, Scalar.LightGreen, 2);
                    Debug.WriteLine($"X --- > {biggestContourRect.X}\tY --- > {biggestContourRect.Y}\tSize --- > {biggestContourRect.Width} * {biggestContourRect.Height}");

                    Mat mat4 = OpenCVToCut(mat2, biggestContourRect);
                    mat4.SaveImage($"C:/Users/hefan/Desktop/{i}.png");
                    i++;
                }

                // 画线
                //mat.Rectangle(biggestContourRect, new Scalar(0, 255, 0), 2);
                //Cv2.DrawContours(mat, contours, -1, new Scalar(0, 255, 0),1);
                Cv2.ImShow("二值化", mat2);
                Cv2.ImShow("腐蚀", mat3);
                Cv2.ImShow("文字区域框选", mat);
                mat.SaveImage("C:/Users/hefan/Desktop/轮廓画线.png");
            }
        }
        public static Mat OpenCVToCut(Mat inputMat, OpenCvSharp.Rect TargetRectangle)
        {
            Mat mat = inputMat;
            OpenCvSharp.Rect rect = new OpenCvSharp.Rect(TargetRectangle.X, TargetRectangle.Y, TargetRectangle.Width, TargetRectangle.Height);
            Mat RectMat = new Mat(mat, rect);
            
            //mat.Dispose();
            //RectMat.Dispose();
            return RectMat;
        }
    }
}
