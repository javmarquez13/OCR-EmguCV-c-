using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using ZXing;
using System.IO;
using Emgu.CV.UI;
using Emgu.CV.Features2D;
using Emgu.Util;
using OpenCV_Vision_Functions;
using Patagames.Ocr;
using Emgu.CV.Util;
using System.Runtime.CompilerServices;

namespace EmguOpenCVExample
{
    public partial class Form1 : Form
    {
        
        string[] _inputArgs;

        public Form1(string[] args)
        {
            InitializeComponent();

            _inputArgs = args;
            this.TopMost = false;
            if (!Directory.Exists(@"C:\Images\")) Directory.CreateDirectory(@"C:\Images\");
            txtWidthX0.Text = integerVariable1.ToString();  //"Argument7", "X1");
            txtHeightY0.Text = integerVariable2.ToString();    //("Argument8", "Y1");
            txtWidthX1.Text = integerVariable3.ToString();  //"Argument9", "X2");
            txtHeightY1.Text = integerVariable4.ToString();   //"Argument10", "Y2");           
        }

        VideoCapture video = new VideoCapture(1);
        string _modeActive;
        bool _testPass = false;

        Image<Hsv, byte> _imgRealTime = (Image<Hsv, byte>)null;
        string _SerialNumberFromBarcode = string.Empty;
        string _SerialNumberFromOCR = string.Empty;

        void function()
        {
            //VideoCapture video = new VideoCapture(0);
            //ICapture capture = (ICapture)video;

            //Mat ImageMat = capture.QueryFrame();

            //image = new Image<Hsv, byte>(ImageMat.Bitmap);



            //Hsv hsv2 = new Hsv(120.0, (double)byte.MaxValue, (double)byte.MaxValue);


            //Rectangle rect = new Rectangle(100, 100, 50, 50);
            //image.Draw(rect, new Hsv(0.0, 0.0, (double)byte.MaxValue), 1, Emgu.CV.CvEnum.LineType.EightConnected, 0);
            //Image _ImagenRec = image.ToBitmap();


            //ImageViewer imageViewer = new ImageViewer(_ImagenRec);
            //imageViewer.Show();
        }
        //$MinH = 180; 
        //$MinS = 60; 
        //$MinV = 50; 
        //$MaxH = 235; 
        //$MaxS = 100; 
        //$MaxV = 100;
        double floatVariable1 = 0; //"Argument1", "H Min Threshold");
        double floatVariable2 = 0; //"Argument2", "S Min Threshold");
        double floatVariable3 = 0; //"Argument3", "V Min Threshold");
        double floatVariable4 = 255; //"Argument4", "H Max Threshold");
        double floatVariable5 = 100; //"Argument5", "S Max Threshold");
        double floatVariable6 = 36; //"Argument6", "V Max Threshold");
        int integerVariable1 = 80; //"Argument7", "X1");
        int integerVariable2 = 30; //("Argument8", "Y1");
        int integerVariable3 = 570;//"Argument9", "X2");
        int integerVariable4 = 430; //"Argument10", "Y2");
        bool booleanVariable = true;


        int PixelCountExample()
        {
            double num1 = floatVariable1 / 2.0;
            double num2 = floatVariable4 / 2.0;
            double num3 = floatVariable2 / 100.0 * (double)byte.MaxValue;
            double num4 = floatVariable5 / 100.0 * (double)byte.MaxValue;
            double num5 = floatVariable3 / 100.0 * (double)byte.MaxValue;
            double num6 = floatVariable6 / 100.0 * (double)byte.MaxValue;

            Image<Hsv, byte> image1 = (Image<Hsv, byte>)null;
            Image<Hsv, byte> image2 = (Image<Hsv, byte>)null;

            //VideoCapture video = new VideoCapture(0);  
            //video.SetCaptureProperty(CapProp.Focus, 150);
            ICapture capture = (ICapture)video;
           

            System.Threading.Thread.Sleep(2000);           
            Mat ImageMat = capture.QueryFrame();
            IImage image3 = (IImage)ImageMat;

            //image3.Save(@"C:\\Images\example.jpeg");
            image3 = new Image<Hsv, byte>(ImageMat.Bitmap);


            image2 = new Image<Hsv, byte>(image3.Bitmap);
            image1 = image2.Copy();
            int num7 = 0;
            Hsv hsv1 = new Hsv();
            Hsv hsv2 = new Hsv(120.0, (double)byte.MaxValue, (double)byte.MaxValue);
            for (int index1 = integerVariable2; index1 < integerVariable4; ++index1)
            {
                for (int index2 = integerVariable1; index2 < integerVariable3; ++index2)
                {
                    Hsv hsv3 = image2[index1, index2];
                    if (hsv3.Value >= num5 && hsv3.Value <= num6 && (hsv3.Satuation >= num3 && hsv3.Satuation <= num4))
                    {
                        if (num1 > num2)
                        {
                            if (hsv3.Hue >= num1 || hsv3.Hue <= num2)
                            {
                                ++num7;
                                if (booleanVariable)
                                    image1[index1, index2] = hsv2;
                            }
                        }
                        else if (hsv3.Hue >= num1 && hsv3.Hue <= num2)
                        {
                            ++num7;
                            if (booleanVariable)
                                image1[index1, index2] = hsv2;
                        }
                    }
                }
            }
            if (booleanVariable)
            {
                int width = integerVariable3 - integerVariable1;
                int height = integerVariable4 - integerVariable2;
                Rectangle rect = new Rectangle(integerVariable1, integerVariable2, width, height);
                image1.Draw(rect, new Hsv(0.0, 0.0, (double)byte.MaxValue), 1, Emgu.CV.CvEnum.LineType.EightConnected, 0);

                //ImageViewer imageViewer = new ImageViewer(image1.Bitmap, num7);
                //imageViewer.Show();
                pictureBox2.Image = image1.Bitmap;
            }

            return num7;
        }

        void MatchTemplaeExample()
        {
            //Argumentos de entrada necesarios para algoritmo.
            object objectVariable1 = Image.FromFile(@"C:\Images\Debug\Test1.jpg"); //Search image
            object objectVariable2 = Image.FromFile(@"C:\Images\Debug\Test2.jpg"); //Template image
            string upper = "CCOEFF_NORMALIZED";  //Example:CCOEFF_NORMALIZED, CCORR_NORMALIZED, SQDIFF_NORMALIZED  Matching Algorithm
            bool booleanVariable = true; //Show debug image 


            TemplateMatchingType method = new TemplateMatchingType();
            bool flag = false;
            if (upper == "CCOEFF_NORMALIZED")
            {
                method = TemplateMatchingType.CcoeffNormed;
                flag = true;
            }
            else if (upper == "CCORR_NORMALIZED")
            {
                method = TemplateMatchingType.CcorrNormed;
                flag = true;
            }
            else if (upper == "SQDIFF_NORMALIZED")
            {
                method = TemplateMatchingType.SqdiffNormed;
                flag = false;
            }
            try
            {
                if (objectVariable1 != null && objectVariable2 != null)
                {

                    Image<Bgr, Byte> myImage1 = new Image<Bgr, Byte>((Bitmap)objectVariable1); //Convert from bitmap to Emgu.CV.Image
                    Image<Bgr, Byte> myImage2 = new Image<Bgr, Byte>((Bitmap)objectVariable2); //Convert from bitmap to Emgu.CV.Image
                    IImage image1 = (IImage)myImage1;
                    IImage image2 = (IImage)myImage2;
                    //IImage image1 = (IImage)objectVariable1; //Original
                    //IImage image2 = (IImage)objectVariable2; //Original
                    Image<Bgr, byte> image3 = new Image<Bgr, byte>(image1.Bitmap);
                    Image<Bgr, byte> template = new Image<Bgr, byte>(image2.Bitmap);
                    Image<Gray, float> image4 = image3.MatchTemplate(template, method);
                    //this.VariableSpace.UpdateStatusText("OpenCV_MatchTemplate: Locating Best Matches Found in Image...");
                    double[] minValues;
                    double[] maxValues;
                    Point[] minLocations;
                    Point[] maxLocations;
                    image4.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                    double x = maxValues[0];
                    double num1 = minValues[0];
                    double num2;
                    if (flag)
                    {
                        if (maxValues.Length > 1)
                        {
                            //this.VariableSpace.UpdateStatusText("OpenCV_MatchTemplate: Multiple Optimal Matches Have Been Found in the Image, returning the first best match.");
                        }

                        num2 = Math.Pow(x, 3.0) * 100.0;
                        //this.VariableSpace.UpdateStatusText(string.Format("OpenCV_MatchTemplate: First Best Match Located At [{0}, {1}]. Match Confidence = [{2}%].", (object)maxLocations[0].X, (object)maxLocations[0].Y, (object)num2));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue0", VariableType.Float, (object)num2));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue1", VariableType.Integer, (object)maxLocations[0].X));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue2", VariableType.Integer, (object)maxLocations[0].Y));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue3", VariableType.Object, (object)new Image<Gray, byte>(image4.Bitmap)));
                    }
                    else
                    {
                        if (minValues.Length > 1)
                        {
                            //this.VariableSpace.UpdateStatusText("OpenCV_MatchTemplate: Multiple Optimal Matches Have Been Found in the Image, returning the first best match.");
                        }
                        num2 = Math.Pow(1.0 - num1, 3.0) * 100.0;
                        //this.VariableSpace.UpdateStatusText(string.Format("OpenCV_MatchTemplate: First Best Match Located At [{0},{1}]. Match Confidence = [{2}%].", (object)minLocations[0].X, (object)minLocations[0].Y, (object)num2));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue0", VariableType.Float, (object)num2));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue1", VariableType.Integer, (object)minLocations[0].X));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue2", VariableType.Integer, (object)minLocations[0].Y));
                        //this.VariableSpace.setVariable(new ScriptVariable("ReturnValue3", VariableType.Object, (object)new Image<Gray, byte>(image4.Bitmap)));
                    }
                    if (booleanVariable)
                    {
                        Image<Bgr, byte> image5 = image3.ConcateVertical(new Image<Bgr, byte>(image4.Bitmap));
                        Point[] pts = new Point[4];
                        if (flag)
                        {
                            pts[0].X = maxLocations[0].X;
                            pts[0].Y = maxLocations[0].Y;
                            pts[1].X = pts[0].X;
                            pts[1].Y = pts[0].Y + template.Height;
                            pts[2].X = pts[0].X + template.Width;
                            pts[2].Y = pts[0].Y + template.Height;
                            pts[3].X = pts[0].X + template.Width;
                            pts[3].Y = maxLocations[0].Y;
                        }
                        else
                        {
                            pts[0].X = minLocations[0].X;
                            pts[0].Y = minLocations[0].Y;
                            pts[1].X = pts[0].X;
                            pts[1].Y = pts[0].Y + template.Height;
                            pts[2].X = pts[0].X + template.Width;
                            pts[2].Y = pts[0].Y + template.Height;
                            pts[3].X = pts[0].X + template.Width;
                            pts[3].Y = minLocations[0].Y;
                        }
                        image5.DrawPolyline(pts, true, new Bgr((double)byte.MaxValue, 0.0, 0.0), 2, Emgu.CV.CvEnum.LineType.EightConnected, 0);
                        //int num3 = (int)new ImageViewer((IImage)image5, string.Format("Pattern Match Confidence: [{0}%].", (object)num2)).ShowDialog();                       
                        ImageViewer imageViewer = new ImageViewer(image5.Bitmap, num2);
                        imageViewer.Show();
                        image5.Dispose();
                    }
                    image3.Dispose();
                    image4.Dispose();
                }
            }
            catch (Exception ex)
            {

            }
        }

        Result[] ScanBarCode()
        {
            Result[] resultArray = null;
            ICapture capture = (ICapture)video;
            Mat img = capture.QueryFrame();
            int with = img.Width;
            int heigh = img.Height;
            Image<Hsv, byte> image1 = (Image<Hsv, byte>)null;
            image1 = new Image<Hsv, byte>(img.Bitmap);
            int width = integerVariable3 - integerVariable1;
            int height = integerVariable4 - integerVariable2;
            Rectangle rect = new Rectangle(integerVariable1, integerVariable2, width, height);
            image1.Draw(rect, new Hsv(0.0, 0.0, (double)byte.MaxValue), 10, Emgu.CV.CvEnum.LineType.AntiAlias, 0);
            image1.Save(@"C:\Images\Labe.jpg");
            image1.Dispose();


            Image Image1 = Bitmap.FromFile(@"C:\Images\Labe.jpg");
            Image<Bgr, Byte> myImage1 = new Image<Bgr, Byte>((Bitmap)Image1);
            int length = 0;
            string[] strArray1 = (string[])null;
            string[] strArray2 = (string[])null;
            bool flag;
            try
            {
                resultArray = new BarcodeReader().DecodeMultiple(myImage1.Bitmap);
                flag = false;
                if (resultArray != null)
                    length = resultArray.Length;
                if (length > 0)
                {
                    flag = true;
                    strArray1 = new string[length];
                    strArray2 = new string[length];
                    for (int index = 0; index < length; ++index)
                    {
                        Result result = resultArray[index];
                        strArray1[index] = result.Text;
                        strArray2[index] = result.BarcodeFormat.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            Image1.Dispose();
            return resultArray;
        }

        //Eventos para probar funciones
        private async void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            _SerialNumberFromBarcode = string.Empty;
            _SerialNumberFromOCR = string.Empty;
      
            TryScanBarcode:
            _modeActive = "Scanning Barcode...";
            Task<Result[]> _taskBarcode = new Task<Result[]>(ScanBarCode);
            _taskBarcode.Start();
            Result[] _res = await _taskBarcode;

            if (_res != null)
            {
                Result _result = _res[0];
                _SerialNumberFromBarcode = _result.Text;
                lblSerialNumber.Text = _SerialNumberFromBarcode;

                if (_inputArgs[1] != _SerialNumberFromBarcode)
                {
                    _testPass = false;
                    goto Evaluation;
                }
                   
            }
            else                
                goto TryScanBarcode;


            TryOCR:
            Task<string> _taskOCR = new Task<string>(TesseractAPI);
            _taskOCR.Start();
            string OCRResult = await _taskOCR;
            bool _isNamePlate = false;        


            if (OCRResult.Contains(_SerialNumberFromBarcode))
            {
                string[] _splitOCR = OCRResult.Split('\n');

                foreach (string _split in _splitOCR)
                {
                    if (_split.StartsWith("Model:"))
                    {
                        _isNamePlate = true;
                        break;
                    }
                }

                lblOCRRecon.Text = "OCR: " + _SerialNumberFromBarcode;
                _SerialNumberFromOCR = _SerialNumberFromBarcode;
                if(_isNamePlate) _testPass = true;
                if(!_isNamePlate) _testPass = false;
            }
            else
                goto TryOCR;


            Evaluation:
            timer1.Stop();
            CvInvoke.PutText(_imgRealTime, "BarCode: " + _SerialNumberFromBarcode, new Point(100, 60), FontFace.HersheyComplex, 1.0, new Rgb(0, 0, 0).MCvScalar, 2);
            CvInvoke.PutText(_imgRealTime, "OCR: " + _SerialNumberFromOCR, new Point(100, 100), FontFace.HersheyComplex, 1.0, new Rgb(0, 0, 0).MCvScalar, 2);
            MCvScalar _colorPass = new MCvScalar(0, 255, 0, 120);
            if(_testPass) CvInvoke.PutText(_imgRealTime, "STATUS: PASS", new Point(110, 400), FontFace.HersheySimplex, 2, _colorPass, 3);
            if(!_testPass) CvInvoke.PutText(_imgRealTime, "STATUS: FAIL", new Point(110, 400), FontFace.HersheySimplex, 2, _colorPass, 3);
            pictureBox1.Image = _imgRealTime.Bitmap;
            _testPass = true;

  

            //TryVerifyLabel:
            //Task<int> _task = new Task<int>(PixelCountExample);
            //_task.Start();
            //int response = await _task;

            //lblPixelInt.Text = response.ToString();

            //if (response > 14000 && response < 17000)
            //{
            //    timer1.Stop();
            //}
            //else
            //    goto TryVerifyLabel;



            this.Refresh();
            System.Threading.Thread.Sleep(3000);
            Application.Exit();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            integerVariable1 = Convert.ToInt32(txtWidthX0.Text); //"Argument7", "X1");
            integerVariable2 = Convert.ToInt32(txtHeightY0.Text); //("Argument8", "Y1");
            integerVariable3 = Convert.ToInt32(txtWidthX1.Text);//"Argument9", "X2");
            integerVariable4 = Convert.ToInt32(txtHeightY1.Text); //"Argument10", "Y2");

            video.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Autofocus, 0);
            //video.SetCaptureProperty(CapProp.Focus, 75);
            ICapture capture = (ICapture)video;           
            Mat img = capture.QueryFrame();
            _imgRealTime = (Image<Hsv, byte>)null;
            _imgRealTime = new Image<Hsv, byte>(img.Bitmap);
            int width = integerVariable3 - integerVariable1;
            int height = integerVariable4 - integerVariable2;
            Rectangle rect = new Rectangle(integerVariable1, integerVariable2, width, height);
            _imgRealTime.Draw(rect, new Hsv(0.0, 0.0, (double)byte.MaxValue), 5, Emgu.CV.CvEnum.LineType.AntiAlias, 0);          
            CvInvoke.PutText(_imgRealTime, "BarCode: " +_SerialNumberFromBarcode, new Point(100, 60), FontFace.HersheyComplex, 1.0, new Rgb(0, 0, 0).MCvScalar, 2);
            CvInvoke.PutText(_imgRealTime, "OCR: " + _SerialNumberFromOCR, new Point(100, 100), FontFace.HersheyComplex, 1.0, new Rgb(0, 0, 0).MCvScalar, 2);
            pictureBox1.Image = _imgRealTime.Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TesseractAPI();         
            var model = new Mat(@"C:\Images\ImgTest.jpg");
            var scene = new Mat(@"C:\Images\ImgModel.jpg");

            int _Confidence = 0;
            var result = Draw(model, scene, out _Confidence);            
            pictureBox1.Image = result.Bitmap;
            lblPixelInt.Text = _Confidence.ToString();
        }

        void PerfromOCV()
        {
            string str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz +-/1234567890{}()_<>\"\\;:*#%$&";
            string language = "eng";
   
            
            ICapture capture = (ICapture)video;
            System.Threading.Thread.Sleep(2000);
            Mat ImageMat = capture.QueryFrame();
            IImage image1 = (IImage)ImageMat;     //"Argument0", "Image Object");
            language = "eng";                    //"Argument1", "OCR Language");
            int integerVariable1 = 70;           //"Argument2", "Upper Left Corner X coordinate of ROI");
            int integerVariable2 = 70;            //"Argument3", "Upper Left Corner Y coordinate of ROI");
            int integerVariable3 = 70;            //"Argument4", "ROI Width (Number of Pixels");
            int integerVariable4 = 70;            //"Argument5", "ROI Height (Number of Pixels");
            bool booleanVariable = false;            //"Argument6", "Display Debug Window");

            Image<Bgr, byte> image2 = new Image<Bgr, byte>(image1.Bitmap);
            image2.ROI = new Rectangle(integerVariable1, integerVariable2, integerVariable3, integerVariable4);
            string str2 = @".\\tessdata";

            if (!Directory.Exists(str2)) Directory.CreateDirectory(str2);
            HelperMethods.LoadLanguage(str2, language);
            HelperMethods.LoadLanguage(str2, "osd");
            //HelperMethods.LoadLanguage(str2, language);
            //string path = Path.GetFullPath(@"C:\Users\MarquezFr\source\repos\EmguOpenCVExample\EmguOpenCVExample\bin\Debug\tessdata\");      
            var tesseract = new Tesseract(Path.GetFullPath(str2.Length == 0 || str2.Substring(str2.Length - 1, 1).Equals(Path.DirectorySeparatorChar.ToString()) ? str2 : string.Format("{0}{1}", (object)str2, (object)Path.DirectorySeparatorChar)), language, OcrEngineMode.Default);
            tesseract.Init(Path.GetFullPath(str2.Length == 0 || str2.Substring(str2.Length - 1, 1).Equals(Path.DirectorySeparatorChar.ToString()) ? str2 : string.Format("{0}{1}", (object)str2, (object)Path.DirectorySeparatorChar)), language, OcrEngineMode.Default);
            //Tesseract tesseract = new Tesseract(path, language, OcrEngineMode.TesseractOnly);
            tesseract.SetVariable("tessedit_char_whitelist", str1);
            Image<Bgr, byte> image3 = new Image<Bgr, byte>(image2.Bitmap);
          
            if (image1.NumberOfChannels == 1)
                CvInvoke.CvtColor((IInputArray)image2, (IOutputArray)image3, ColorConversion.Gray2Bgr, 0);
            else
                //image3 = (Image<Bgr, byte>)image1.Clone(); //original
                image3 = image1.Clone() as Image<Bgr, byte>;
            //tesseract.SetImage((IInputArray)image3); original
            tesseract.SetImage((IInputArray)image3);            
            if (tesseract.Recognize() != 0)
            {
                MessageBox.Show(string.Format("OpenCV_PerformOCR: OCR system failed to recognize image. OCR returned: {0}", (object)tesseract.Recognize()));              
            }
            string utF8Text = tesseract.GetUTF8Text();
            char[] separator = new char[3]
            {
              ' ',
              '\r',
              '\n'
            };
            int length = utF8Text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            if (booleanVariable)
            {
                //ImageViewer imageViewer = new ImageViewer((IImage)image2);
                //int num = (int)imageViewer.ShowDialog();
                //imageViewer.Dispose();
            }
            image2.Dispose();
            image3.Dispose();
            tesseract.Dispose();

        }

        string TesseractAPI()
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                objOcr.SetVariable("tessedit_char_whitelist", "0123456789-Model:");
                ICapture capture = (ICapture)video;
                Mat img = capture.QueryFrame();
                int with = img.Width;
                int heigh = img.Height;
                Image<Hsv, byte> image1 = (Image<Hsv, byte>)null;
                image1 = new Image<Hsv, byte>(img.Bitmap);
                int width = integerVariable3 - integerVariable1;
                int height = integerVariable4 - integerVariable2;
                Rectangle rect = new Rectangle(integerVariable1, integerVariable2, width, height);
                image1.Draw(rect, new Hsv(0.0, 0.0, (double)byte.MaxValue), 10, Emgu.CV.CvEnum.LineType.AntiAlias, 0);
                image1.Save(@"C:\Images\Labe.jpg");
                image1.Dispose();                
                var _bmp = Bitmap.FromFile(@"C:\Images\Labe.jpg");
                string _OCR = objOcr.GetTextFromImage((Bitmap)_bmp);
                _bmp.Dispose();
                return _OCR;
            }
        }

        void NewORBDetector()
        {
            float ms_MIN_RATIO = 100;
            float ms_MAX_DIST = 100;

            (Image<Bgr, byte> Image, VectorOfKeyPoint Keypoints, Mat Descriptors) _imgModel = (new Image<Bgr, byte>(@"C:\Images\ImgModel.jpg").Resize(0.2, Inter.Area), new VectorOfKeyPoint(), new Mat());
            (Image<Bgr, byte> Image, VectorOfKeyPoint Keypoints, Mat Descriptors) _imgTest = (new Image<Bgr, byte>(@"C:\Images\ImgTest.jpg").Resize(0.2, Inter.Area), new VectorOfKeyPoint(), new Mat());
            Mat imgKeypointsModel = new Mat();
            Mat imgKeypointsTest = new Mat();
            Mat imgMatches = new Mat();
            Mat imgWarped = new Mat();
            VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();
            VectorOfVectorOfDMatch filteredMatches = new VectorOfVectorOfDMatch();
            List<MDMatch[]> filteredMatchesList = new List<MDMatch[]>();

            ORBDetector _ORB = new ORBDetector();
            BFMatcher _BFMatcher = new BFMatcher(DistanceType.Hamming2);

            _ORB.DetectAndCompute(_imgModel.Image, null, _imgModel.Keypoints, _imgModel.Descriptors, false);
            _ORB.DetectAndCompute(_imgTest.Image, null, _imgTest.Keypoints, _imgTest.Descriptors, false);

            _BFMatcher.Add(_imgModel.Descriptors);
            _BFMatcher.KnnMatch(_imgTest.Descriptors, matches, k: 2, mask: null);

            MDMatch[][] matchesArray = matches.ToArrayOfArray();

            //Apply ratio test
            for (int i = 0; i < matchesArray.Length; i++)
            {
                MDMatch first = matchesArray[i][0];
                float dist1 = matchesArray[i][0].Distance;
                float dist2 = matchesArray[i][1].Distance;

                if (dist1 < ms_MIN_RATIO * dist2)
                {
                    filteredMatchesList.Add(matchesArray[i]);
                }
            }

            //Filter by threshold
            MDMatch[][] defCopy = new MDMatch[filteredMatchesList.Count][];
            filteredMatchesList.CopyTo(defCopy);
            filteredMatchesList = new List<MDMatch[]>();

            foreach (var item in defCopy)
            {
                if (item[0].Distance < ms_MAX_DIST)
                {
                    filteredMatchesList.Add(item);
                }
            }

            filteredMatches = new VectorOfVectorOfDMatch(filteredMatchesList.ToArray());


            Mat homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(_imgModel.Keypoints, _imgTest.Keypoints, filteredMatches, null, 10);
            CvInvoke.WarpPerspective(_imgTest.Image, imgWarped, homography, _imgTest.Image.Size);

            Features2DToolbox.DrawKeypoints(_imgModel.Image, _imgModel.Keypoints, imgKeypointsModel, new Bgr(0, 0, 255));
            Features2DToolbox.DrawKeypoints(_imgTest.Image, _imgTest.Keypoints, imgKeypointsTest, new Bgr(0, 0, 255));
            Features2DToolbox.DrawMatches(_imgModel.Image, _imgModel.Keypoints, _imgTest.Image, _imgTest.Keypoints, filteredMatches, imgMatches, new MCvScalar(0, 255, 0), new MCvScalar(0, 0, 255), null, Features2DToolbox.KeypointDrawType.Default);

            Task.Factory.StartNew(() => Emgu.CV.UI.ImageViewer.Show(imgKeypointsModel, "Keypoints Model"));
            Task.Factory.StartNew(() => Emgu.CV.UI.ImageViewer.Show(imgKeypointsTest, "Keypoints Test"));
            Task.Factory.StartNew(() => Emgu.CV.UI.ImageViewer.Show(imgMatches, "Matches"));
            Task.Factory.StartNew(() => Emgu.CV.UI.ImageViewer.Show(imgWarped, "Warp"));                   
        }

        //Option1
        public static void FindMatch(Mat modelImage, Mat observedImage, out VectorOfKeyPoint modelKeyPoints, out VectorOfKeyPoint observedKeyPoints, VectorOfVectorOfDMatch matches, out Mat mask, out Mat homography)
        {
            int k = 2;
            double uniquenessThreshold = 0.80;
            homography = null;
            modelKeyPoints = new VectorOfKeyPoint();
            observedKeyPoints = new VectorOfKeyPoint();
            using (UMat uModelImage = modelImage.GetUMat(AccessType.Read))
            using (UMat uObservedImage = observedImage.GetUMat(AccessType.Read))
            {
                var featureDetector = new ORBDetector(9000);
                Mat modelDescriptors = new Mat();
                featureDetector.DetectAndCompute(uModelImage, null, modelKeyPoints, modelDescriptors, false);
                Mat observedDescriptors = new Mat();
                
                featureDetector.DetectAndCompute(uObservedImage, null, observedKeyPoints, observedDescriptors, false);
                using (var matcher = new BFMatcher(DistanceType.Hamming, false))
                {
                    matcher.Add(modelDescriptors);

                    matcher.KnnMatch(observedDescriptors, matches, k, null);
                    mask = new Mat(matches.Size, 1, DepthType.Cv8U, 1);
                    mask.SetTo(new MCvScalar(255));
                    Features2DToolbox.VoteForUniqueness(matches, uniquenessThreshold, mask);

                    int nonZeroCount = CvInvoke.CountNonZero(mask);
                    if (nonZeroCount >= 4)
                    {
                        nonZeroCount = Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints, observedKeyPoints,
                            matches, mask, 1.5, 20);
                        if (nonZeroCount >= 4)
                            homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints,
                                observedKeyPoints, matches, mask, 2);
                    }
                }
            }
        }

        //Option 2 watch the process to draw found matchesimages
        public static Mat Draw(Mat modelImage, Mat observedImage, out int Confidence)
        {         
            Mat homography;
            VectorOfKeyPoint modelKeyPoints;
            VectorOfKeyPoint observedKeyPoints;
            using (VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch())
            {
                Mat mask;
                FindMatch(modelImage, observedImage, out modelKeyPoints, out observedKeyPoints, matches, out mask, out homography);
                Mat result = new Mat();
                Features2DToolbox.DrawMatches(modelImage, modelKeyPoints, observedImage, observedKeyPoints,
                    matches, result, new MCvScalar(255, 0, 0), new MCvScalar(0, 0, 255), mask);

                Confidence = matches.Size;

           
                if (homography != null)
                {
                    var imgWarped = new Mat();
                    CvInvoke.WarpPerspective(observedImage, imgWarped, homography, modelImage.Size, Inter.Linear, Warp.InverseMap);
                    Rectangle rect = new Rectangle(Point.Empty, modelImage.Size);
                    var pts = new PointF[]
                    {
                  new PointF(rect.Left, rect.Bottom),
                  new PointF(rect.Right, rect.Bottom),
                  new PointF(rect.Right, rect.Top),
                  new PointF(rect.Left, rect.Top)
                    };

                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    var points = new Point[pts.Length];
                    for (int i = 0; i < points.Length; i++)
                        points[i] = Point.Round(pts[i]);

                    using (var vp = new VectorOfPoint(points))
                    {
                        CvInvoke.Polylines(result, vp, true, new MCvScalar(255, 0, 0, 255), 1, LineType.AntiAlias, 0);
                    }
                }
                return result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_testPass) Environment.Exit(0);
            if (!_testPass) Environment.Exit(1);
        }
    }
}


