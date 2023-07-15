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
            Debug.WriteLine($"�Ƿ�ѡ�� --- > {ToggleButton_10_5.IsChecked}");*/
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {

        }
        // �������
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

            // ����Ƿ���ȷ
            if (newDataSum != 10 && newDataSum != 20 && newDataSum != 30 && newDataSum != 40 && newDataSum != 50 && newDataSum != 60)
            {
                Debug.WriteLine($"�������ʧ��,���� ---> {newDataSum}");
                return;
            }

            if (newDataNumber != 5 && newDataNumber != 7)
            {
                Debug.WriteLine($"�������ʧ��,�������� ---> {newDataNumber}");
                return;
            }

            foreach (int i in ints)
            {
                if (i > 9 || i < 0)
                {
                    Debug.WriteLine($"�������ʧ��,λ�������� ---> {i}");
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
                Debug.WriteLine($"�û���ȡ��Ѱ���ļ��� --- > {Text}\nѡ���·������ --- > {path}");
                return;
            }
            Debug.WriteLine($"ѡ����ļ����� --- > {Text}\nѡ���·������ --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // ����ÿ���ļ�
                Debug.WriteLine($"�ļ� --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

                // 1�� �����������Ч����
                //  ��ͼ�ܿ�ȼ�80%����Ч���
                int Width = (int)((float)bitmap.Width * (1f - (80f / 100f)));
                //  ��ͼ�ܸ߶ȼ�����30%����Ч���������ȥ�ܸ߶ȵײ���10%����Ч���
                int topHeight = (int)((float)bitmap.Height * (1f - (30f / 100f)));
                int endHeight = (int)((float)bitmap.Height * (1f - (10f / 100f)));
                //  ������Ч���ܸ߶� = �ܸ߶� - ((��������Ч�߶�) + (�ײ�����Ч�߶�))
                int Height = bitmap.Height - ((bitmap.Height - topHeight) + (bitmap.Height - endHeight));
                // ��ʼ����X = �ܿ�� - ��Ч��ȣ���ʼ����Y = �ܸ߶� - ȥ�����������Ч�߶�
                int X = bitmap.Width - Width;
                int Y = bitmap.Height - topHeight;
                Debug.WriteLine($"��������Ч��� Width --- > {Width} Height --- > {Height}");
                Debug.WriteLine($"��ͼ��ʼ����X --- > {X} ��ͼ��ʼ����Y--- > {Y}");

                // 2���ü���ֻ�н���Сͼ
                Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
                // �����հ׻�������СΪ�ü������С
                Bitmap result = new Bitmap(Width, Height);
                // ����Graphics���󣬲�ָ��Ҫ��result��Ŀ��ͼƬ�������ϻ���ͼ��
                Graphics graphics = Graphics.FromImage(result);
                // ʹ��Graphics�����ԭͼָ������ͼ��ü������������ոմ����Ŀհ׻���
                graphics.DrawImage(bitmap, new Rectangle(0, 0, Rectangle.Width, Rectangle.Height), Rectangle, GraphicsUnit.Pixel);
                //result.Save("C:/Users/hefan/Desktop/wuqi1.png");

                // 3�����ж�ֵ��������ͼƬֻ��2����ɫ
                Mat mat = BitmapConverter.ToMat(result);
                Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
                Mat result1 = mat.Threshold(0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/wuqi2.png");

                // 4��ͼƬ���͡���ʴ���� �˺���
                Mat element1 = new Mat();
                OpenCvSharp.Size size1 = new OpenCvSharp.Size(30, 20);
                element1 = Cv2.GetStructuringElement(MorphShapes.Rect, size1);
                //Mat element2 = new Mat();
                //OpenCvSharp.Size size2 = new OpenCvSharp.Size(15, 9);
                //element2 = Cv2.GetStructuringElement(MorphShapes.Rect, size2);

                // 4.1�����ͣ�͹������(����Ҫ�������ͣ�����Ч�����)
                /*Mat dilation = new Mat();
                Cv2.Dilate(mat3, dilation, element2);*/

                // 5����ʴһ��ȥ��ϸ�ڣ����ļ����
                Mat mat2 = new Mat();
                Cv2.Erode(result1, mat2, element1);

                // 6�� ��������
                OpenCvSharp.Point[][] contours;
                OpenCvSharp.Rect biggestContourRect = new OpenCvSharp.Rect();

                Cv2.FindContours(mat2, out contours, out HierarchyIndex[] hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);


                // 7. ��ѯ���������㣬ɸѡ��Щ���С��
                int s = 1;
                StringBuilder sb = new StringBuilder();
                foreach (OpenCvSharp.Point[] contour in contours)
                {

                    double area = Cv2.ContourArea(contour);
                    //  ���С�Ķ�ɸѡ��
                    if (area < 1000)
                    {
                        continue;
                    }
                    //  �������ƣ����ú�С
                    double epsilon = 0.001 * Cv2.ArcLength(contour, true);
                    //  �ҵ���С�ľ���
                    biggestContourRect = Cv2.BoundingRect(contour);
                    if (biggestContourRect.Height > (biggestContourRect.Width * 1.2))
                    {
                        continue;
                    }
                    // ��ԭͼ�ϻ�������
                    mat.Rectangle(biggestContourRect, Scalar.LightGreen, 2);
                    //Debug.WriteLine($"X --- > {biggestContourRect.X}\tY --- > {biggestContourRect.Y}\tSize --- > {biggestContourRect.Width} * {biggestContourRect.Height}");

                    // �ü�������
                    Mat mat4 = OpenCVToCut(mat, biggestContourRect);
                    //mat4.SaveImage($"C:/Users/hefan/Desktop/{s}.png");
                    s++;
                    // ��ÿ�����ν�������ʶ��Ȼ����ӵ�StringBuilder
                    string iamegText = await tesseractOCR.OCRAsync(mat4.ToBytes());
                    //Debug.WriteLine($"�ҵ��ı� --->  {iamegText}");
                    sb.Append(iamegText);
                }
                //Cv2.ImShow("SSS", mat);

                
                String text = sb.ToString();
                if (text == null) 
                {
                    await FailedFileSave(file, "δ֪����");
                    continue;
                }
                // text =  " 10.34Ԫ5.1 7Ԫ\n9.31Ԫ 5.17 Ԫ 5.18\nԪ  5.17Ԫ 5.1 9Ԫ  " ;
                //Debug.WriteLine($"ʶ�𵽵�ԭʼ�ı� --- >  {text}");
                String v = text.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(" ", "");
                //v = v.Replace("Ԫ","Ԫ,"); // ����stringתfloatС����Ϊ0�Ĳ��ᱣ����
                Debug.WriteLine($"�������ı� --->  {v}");
                v = v.Remove(v.Length - 1);
                String[] strings = v.Split("Ԫ");
               // Debug.WriteLine($"Length --->  {strings.Length}");


                // �ַ���תfloat
                float[] price = toArr(strings);
                if (price == null)
                {
                    await FailedFileSave(file, "ʶ��ʧ��");
                    continue;
                }

                // �ж��Ƿ���5������7��
                if (price.Length != 5 && price.Length != 7)
                {
                    await FailedFileSave(file, "��������");
                    Debug.WriteLine($"�����������ʧ�� ---> {file} ʶ�𵽵ĺ������--- > {price.Length}");
                    continue;
                }

                Decimal sum = 0;
                // �������Ƿ���ȷ
                for (int i = 0; i < price.Length; i++)
                {
                    sum += (decimal)price[i];
                    
                }
                //Debug.WriteLine($"�ܽ�� ---> {sum}");
                if (sum != 10 && sum != 20 && sum != 30 && sum != 40 && sum != 50 && sum != 60)
                {
                    await FailedFileSave(file, "����ܽ���");
                    Debug.WriteLine($"����ܽ��� ---> {file} ʶ�𵽵ĺ���ܽ���--- > {sum}");
                    continue;
                }
                

                RedPacket redPacket = new RedPacket();
                redPacket.sum = (long)sum;
                redPacket.number = (int)price.Length;
                for (int i = 0; i < price.Length; i++)
                {
                    
                    
                    //string v1 = price[i].ToString();
                    string v1 = price[i].ToString("F2");
                    Debug.WriteLine($"��� ---> {v1}");
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
                Debug.WriteLine($"ʶ��ɹ� ---> {file} ������� --- > {redPacket.ToString()}");
            }

            
        }

        private static async Task FailedFileSave(string filePath, string TAG)
        {
            StorageFile imageFile = await StorageFile.GetFileFromPathAsync(filePath);
            // ��ȡͼƬ�ĸ�Ŀ¼
            StorageFolder storageFolder = await imageFile.GetParentAsync();
            string ParentPath = storageFolder.Path;
            string failedPath = ParentPath + $"\\{TAG}\\";
            if (!Directory.Exists(failedPath))
            {
                Directory.CreateDirectory(failedPath);
            }
            // ���Ƶ�ǰʶ��ʧ�ܵ�ͼƬ��ָ��Ŀ¼
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
            Debug.WriteLine($"ѡ����ļ����� --- > {Text}\nѡ���·������ --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // ����ÿ���ļ�
                Debug.WriteLine($"�ļ� --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

                //  �����������Ч����
                //  ��ͼ�ܿ�ȼ�80%����Ч���
                int Width = (int)((float)bitmap.Width * (1f - (80f / 100f)));
                //  ��ͼ�ܸ߶ȼ�����30%����Ч���������ȥ�ܸ߶ȵײ���10%����Ч���
                int topHeight = (int)((float)bitmap.Height * (1f - (30f / 100f)));
                int endHeight = (int)((float)bitmap.Height * (1f - (10f / 100f)));
                //  ������Ч���ܸ߶� = �ܸ߶� - ((��������Ч�߶�) + (�ײ�����Ч�߶�))
                int Height = bitmap.Height - ((bitmap.Height - topHeight) + (bitmap.Height - endHeight));

                // ��ʼ����X = �ܿ�� - ��Ч��ȣ���ʼ����Y = �ܸ߶� - ȥ�����������Ч�߶�
                int X = bitmap.Width - Width;
                int Y = bitmap.Height - topHeight;
                Debug.WriteLine($"��������Ч��� Width --- > {Width} Height --- > {Height}");
                Debug.WriteLine($"��ͼ��ʼ����X --- > {X} ��ͼ��ʼ����Y--- > {Y}");

                Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
                // �����հ׻�������СΪ�ü������С
                Bitmap result = new Bitmap(Width, Height);
                // ����Graphics���󣬲�ָ��Ҫ��result��Ŀ��ͼƬ�������ϻ���ͼ��
                Graphics graphics = Graphics.FromImage(result);
                // ʹ��Graphics�����ԭͼָ������ͼ��ü������������ոմ����Ŀհ׻���
                graphics.DrawImage(bitmap, new Rectangle(0, 0, Rectangle.Width, Rectangle.Height), Rectangle, GraphicsUnit.Pixel);
                //result.Save("C:/Users/hefan/Desktop/wuqi1.png");Screenshot_20230713-005444_WeChat
                Mat mat = BitmapConverter.ToMat(result);
                Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
                Mat result1 = mat.Threshold(0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/wuqi2.png");



                String text = await tesseractOCR.OCRAsync(result1.ToBytes());
                //String text =  " 10.34Ԫ5.1 7Ԫ\n9.31Ԫ 5.17 Ԫ 5.18\nԪ  5.17Ԫ 5.1 9Ԫ  " ;
                Debug.WriteLine($"ʶ�𵽵�ԭʼ�ı� --- >  {text}");
                String v = text.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(" ", "");
                Debug.WriteLine($"�������ı� --->  {v}");
                v = v.Remove(v.Length - 1);
                String[] strings = v.Split("Ԫ");
                Debug.WriteLine($"Length --->  {strings.Length}");



                // �ַ���תfloat
                float[] price = toArr(strings);
                if (price == null)
                {
                    await FailedFileSave(file, result1, "ʶ��ʧ��");

                    continue;
                }


                // �ж��Ƿ���5������7��
                if (price.Length != 5 && price.Length != 7)
                {
                    await FailedFileSave(file, result1, "��������");
                    Debug.WriteLine($"�����������ʧ�� ---> {file} ʶ�𵽵ĺ������--- > {price.Length}");
                    continue;
                }

                Decimal sum = 0;
                // �������Ƿ���ȷ
                for (int i = 0; i < price.Length; i++)
                {
                    sum += (decimal)price[i];
                }
                Debug.WriteLine($"�ܽ�� ---> {sum}");
                if (sum != 10 && sum != 20 && sum != 30 && sum != 40 && sum != 50 && sum != 60)
                {
                    await FailedFileSave(file, result1, "����");
                    Debug.WriteLine($"����ܽ��� ---> {file} ʶ�𵽵ĺ���ܽ���--- > {sum}");
                    continue;
                }

                Debug.WriteLine($"ʶ��ɹ� ---> {file} ��� --- > {sum}");
            }


        }

       
        private static async Task FailedFileSave(string path, Mat mat, string TAG)
        {
            /**
             * path Դ�ļ��洢·��
             * mat  ��ֵ����ȡ���ͼƬ
             * TAG  ��ȡ���ͼƬҪ�洢�����ļ���
             */
            Debug.WriteLine($"path ---> {path} TAG--- > {TAG}");
            StorageFile imageFile = await StorageFile.GetFileFromPathAsync(path);
            // ��ȡͼƬ�ĸ�Ŀ¼
            StorageFolder storageFolder = await imageFile.GetParentAsync();
            string ParentPath = storageFolder.Path;
            string failedPath = ParentPath + $"\\{TAG}\\";
            Debug.WriteLine($"failedPath ---> {failedPath} ");
            if (!Directory.Exists(failedPath))
            {
                Directory.CreateDirectory(failedPath);
            }
            failedPath = ParentPath + $"\\{TAG}\\{imageFile.Name}";
            // ���Ƶ�ǰʶ��ʧ�ܵ�ͼƬ��ָ��Ŀ¼
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
                    //Debug.WriteLine($"�ַ���ת��Ϊ���ֽ�� --->  {price[i]}");
                }
                catch
                {
                    //await FailedFileSave(file,"ʶ��ʧ��");
                    Debug.WriteLine($"����ʧ��--- > {strings[i]}");
                    return null;
                }

            }
            return price;
        }

        // ����ͼƬ�е�����
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
                Text = "�Ѿ�ȡ������";
            }
            
            Debug.WriteLine($"ѡ����ļ����� --- > {Text}\nѡ���·������ --- > {path}");

            TesseractOCR tesseractOCR = new TesseractOCR();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                // ����ÿ���ļ�
                Debug.WriteLine($"�ļ� --- > {file}");
                using Bitmap bitmap = new Bitmap(file);

              

                Mat mat = BitmapConverter.ToMat(bitmap);
                Mat mat1 = new Mat();
                Mat mat2 = new Mat();
                Cv2.CvtColor(mat, mat1, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(mat1,mat2, 0, 255, ThresholdTypes.Otsu);
                //result1.SaveImage("C:/Users/hefan/Desktop/��ֵ����.png");

                // 3. ��Û�͸��g�����ĺ˺���
                Mat element1 = new Mat();
                OpenCvSharp.Size size1 = new OpenCvSharp.Size(15, 9);
                element1 = Cv2.GetStructuringElement(MorphShapes.Rect, size1);

                //4. ���ͣ�͹������
                /*Mat dilation = new Mat();
                Cv2.Dilate(mat3, dilation, element2);*/

                //5. ��ʴһ��ȥ��ϸ�ڣ����ļ����
                Mat mat3 = new Mat();
                Cv2.Erode(mat2, mat3, element1);



                // 1. ��������
                OpenCvSharp.Point[][] contours;
                OpenCvSharp.Rect biggestContourRect = new OpenCvSharp.Rect();

                Cv2.FindContours(mat3, out contours, out HierarchyIndex[] hierarchly, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

                int i = 1;
                // 2. ɸѡ��Щ���С��
                foreach (OpenCvSharp.Point[] contour in contours)
                {
                   
                    double area = Cv2.ContourArea(contour);
                    //���С�Ķ�ɸѡ��
                    if (area < 1000)
                    {
                        continue;
                    }
                    //�������ƣ����ú�С
                    double epsilon = 0.001 * Cv2.ArcLength(contour, true);
                    //�ҵ���С�ľ���
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

                // ����
                //mat.Rectangle(biggestContourRect, new Scalar(0, 255, 0), 2);
                //Cv2.DrawContours(mat, contours, -1, new Scalar(0, 255, 0),1);
                Cv2.ImShow("��ֵ��", mat2);
                Cv2.ImShow("��ʴ", mat3);
                Cv2.ImShow("���������ѡ", mat);
                mat.SaveImage("C:/Users/hefan/Desktop/��������.png");
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
