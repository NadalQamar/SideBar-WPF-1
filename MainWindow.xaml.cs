using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SideBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //field values
        bool accessFlag = false;//For Mouse Entry to and from SideBar
        bool settingsFlag = false;//For When user clicks on setting button
        byte bgColorA;//Color of the Background
        byte bgColorR;
        byte bgColorG;
        byte bgColorB;
        string bgColorHex;
        byte tColorA;//Color of the Text Color (ForegroundGet/Set)
        byte tColorR;
        byte tColorG;
        byte tColorB;
        string tColorHex;
        byte cColorA;//Color of the Control color (BackgroundTextBoxGet/Set)
        byte cColorR;
        byte cColorG;
        byte cColorB;
        string cColorHex;
        
        //Load on Startup
        public MainWindow()
        {
            InitializeComponent();
            Width = 40;
            Height = SystemParameters.PrimaryScreenHeight;
            Left = SystemParameters.PrimaryScreenWidth - 2;
            ControlBox.Height = SystemParameters.PrimaryScreenHeight;

            BackgroundColorChangerPanel.IsEnabled = false;
            BackgroundColorChangerPanel.Visibility = Visibility.Hidden;

            //Background Color Get
            string colorbg = new BrushConverter().ConvertToString(Background);
            Color bg = (Color) ColorConverter.ConvertFromString(colorbg);

            bgColorHex = colorbg;
            bgColorA = bg.A;
            bgColorR = bg.R;
            bgColorG = bg.G;
            bgColorB = bg.B;

            //Text Color Get
            string colort = new BrushConverter().ConvertToString(ForegroundGet());
            Color t = (Color)ColorConverter.ConvertFromString(colort);

            tColorHex = colort;
            tColorA = t.A;
            tColorR = t.R;
            tColorG = t.G;
            tColorB = t.B;

            //Control Color Get
            string colorc = new BrushConverter().ConvertToString(BackgroundTextBoxGet());
            Color c = (Color)ColorConverter.ConvertFromString(colorc);

            cColorHex = colorc;
            cColorA = c.A;
            cColorR = c.R;
            cColorG = c.G;
            cColorB = c.B;

        }
        
        //Methods
        private Brush ForegroundGet()
        {
            Brush brush;

            //PrimarySideBarPanel
            brush = CloseButton.Foreground;
            brush = VisiblityButton.Foreground;
            brush = SettingsButton.Foreground;

            //Background Text
            brush = SetBCCLabel.Foreground;
            brush = SetBCCARGBALabel.Foreground;
            brush = SetBCCARGBRLabel.Foreground;
            brush = SetBCCARGBGLabel.Foreground;
            brush = SetBCCARGBBLabel.Foreground;
            brush = SetBCCHexValLabel.Foreground;
            brush = SetBCCHexLabel.Foreground;

            //Text Text
            brush = SetTCCLabel.Foreground;   
            brush = SetTCCARGBALabel.Foreground;
            brush = SetTCCARGBRLabel.Foreground;
            brush = SetTCCARGBGLabel.Foreground;
            brush = SetTCCARGBBLabel.Foreground;
            brush = SetTCCHexValLabel.Foreground;
            brush = SetTCCHexLabel.Foreground;

            //Control Text
            brush = SetCCCLabel.Foreground;
            brush = SetCCCARGBALabel.Foreground;
            brush = SetCCCARGBRLabel.Foreground;
            brush = SetCCCARGBGLabel.Foreground;
            brush = SetCCCARGBBLabel.Foreground;
            brush = SetCCCHexValLabel.Foreground;
            brush = SetCCCHexLabel.Foreground;

            return brush;
        }

        private Brush ForegroundTextBoxGet()
        {
            Brush brush;

            //Background Text
            brush = SetBCCARGBAVal.Foreground;
            brush = SetBCCARGBRVal.Foreground;
            brush = SetBCCARGBGVal.Foreground;
            brush = SetBCCARGBBVal.Foreground;
            brush = SetBCCHexVal.Foreground;

            //Text Text
            brush = SetTCCARGBAVal.Foreground;
            brush = SetTCCARGBRVal.Foreground;
            brush = SetTCCARGBGVal.Foreground;
            brush = SetTCCARGBBVal.Foreground;
            brush = SetTCCHexVal.Foreground;

            //Control Text
            brush = SetCCCARGBAVal.Foreground;
            brush = SetCCCARGBRVal.Foreground;
            brush = SetCCCARGBGVal.Foreground;
            brush = SetCCCARGBBVal.Foreground;
            brush = SetCCCHexVal.Foreground;

            return brush;
        }

        private Brush BackgroundGet()
        {
            Brush brush;

            //PrimarySideBarPanel
            brush = CloseButton.Background;
            brush = VisiblityButton.Background;
            brush = SettingsButton.Background;

            return brush;
        }

        private Brush BackgroundTextBoxGet()
        {
            Brush brush;

            //Background Control
            brush = SetBCCARGBAVal.Background;
            brush = SetBCCARGBRVal.Background;
            brush = SetBCCARGBGVal.Background;
            brush = SetBCCARGBBVal.Background;
            brush = SetBCCHexVal.Background;

            //Text Control
            brush = SetTCCARGBAVal.Background;
            brush = SetTCCARGBRVal.Background;
            brush = SetTCCARGBGVal.Background;
            brush = SetTCCARGBBVal.Background;
            brush = SetTCCHexVal.Background;

            //Control Control
            brush = SetCCCARGBAVal.Background;
            brush = SetCCCARGBRVal.Background;
            brush = SetCCCARGBGVal.Background;
            brush = SetCCCARGBBVal.Background;
            brush = SetCCCHexVal.Background;

            return brush;
        }

        private void ForegroundSet(Brush brush)
        {
            //PrimarySideBarPanel
            CloseButton.Foreground = brush;
            VisiblityButton.Foreground = brush;
            SettingsButton.Foreground = brush;

            //Background Text
            SetBCCLabel.Foreground = brush;
            SetBCCARGBALabel.Foreground = brush;
            SetBCCARGBRLabel.Foreground = brush;
            SetBCCARGBGLabel.Foreground = brush;
            SetBCCARGBBLabel.Foreground = brush;
            SetBCCHexValLabel.Foreground = brush;
            SetBCCHexLabel.Foreground = brush;

            //Text Text
            SetTCCLabel.Foreground = brush;
            SetTCCARGBALabel.Foreground = brush;
            SetTCCARGBRLabel.Foreground = brush;
            SetTCCARGBGLabel.Foreground = brush;
            SetTCCARGBBLabel.Foreground = brush;
            SetTCCHexValLabel.Foreground = brush;
            SetTCCHexLabel.Foreground = brush;

            //Control Text
            SetCCCLabel.Foreground = brush;
            SetCCCARGBALabel.Foreground = brush;
            SetCCCARGBRLabel.Foreground = brush;
            SetCCCARGBGLabel.Foreground = brush;
            SetCCCARGBBLabel.Foreground = brush;
            SetCCCHexValLabel.Foreground = brush;
            SetCCCHexLabel.Foreground = brush;
        }

        private void ForegroundTextBoxSet(Brush brush)
        {
            //Background Text
            SetBCCARGBAVal.Foreground = brush;
            SetBCCARGBRVal.Foreground = brush;
            SetBCCARGBGVal.Foreground = brush;
            SetBCCARGBBVal.Foreground = brush;
            SetBCCHexVal.Foreground = brush;

            //Text Text
            SetTCCARGBAVal.Foreground = brush;
            SetTCCARGBRVal.Foreground = brush;
            SetTCCARGBGVal.Foreground = brush;
            SetTCCARGBBVal.Foreground = brush;
            SetTCCHexVal.Foreground = brush;

            //Control Text
            SetCCCARGBAVal.Foreground = brush;
            SetCCCARGBRVal.Foreground = brush;
            SetCCCARGBGVal.Foreground = brush;
            SetCCCARGBBVal.Foreground = brush;
            SetCCCHexVal.Foreground = brush;
        }

        private void BackgroundSet(Brush brush)
        {
            //PrimarySideBarPanel
            CloseButton.Background = brush;
            VisiblityButton.Background = brush;
            SettingsButton.Background = brush;
        }

        private void BackgroundTextBoxSet(Brush brush)
        {

            //Background Control
            SetBCCARGBAVal.Background = brush;
            SetBCCARGBRVal.Background = brush;
            SetBCCARGBGVal.Background = brush;
            SetBCCARGBBVal.Background = brush;
            SetBCCHexVal.Background = brush;

            //Text Control
            SetTCCARGBAVal.Background = brush;
            SetTCCARGBRVal.Background = brush;
            SetTCCARGBGVal.Background = brush;
            SetTCCARGBBVal.Background = brush;
            SetTCCHexVal.Background = brush;

            //Control Control
            SetCCCARGBAVal.Background = brush;
            SetCCCARGBRVal.Background = brush;
            SetCCCARGBGVal.Background = brush;
            SetCCCARGBBVal.Background = brush;
            SetCCCHexVal.Background = brush;
        }

        private Brush ConversionToBrushFromARGB(byte A, byte R, byte G, byte B)
        {
            Color brush = Color.FromArgb(A, R, G, B);
            string colorBrush = new ColorConverter().ConvertToString(brush);
            return (Brush)new BrushConverter().ConvertFromString(colorBrush);
        }

        private string ConversionFromBrushHex(Brush brush)
        {
            return new BrushConverter().ConvertToString(brush);
        }

        private Brush ConversionToBrushHex(string str)
        {
            return (Brush)new BrushConverter().ConvertFromString(str);
        }

        private Color ConversionToColorFromBrush(Brush brush)
        {
            string color = new BrushConverter().ConvertToString(brush);
            return (Color)ColorConverter.ConvertFromString(color);

        }
        
        //SideBar Controls
        private void ControlBox_MouseEnter(object sender, MouseEventArgs e)//EventHandler for whe the user mouse hover enters/leaves the Sidebar
        {
            if(accessFlag == true && settingsFlag == true)
            {
                Left = SystemParameters.PrimaryScreenWidth - 2;
                Width = 40;
                ControlBox.Margin = new Thickness(-35,0,0,0);
                BackgroundColorChangerPanel.Visibility = Visibility.Hidden;
                BackgroundColorChangerPanel.IsEnabled = false;
                accessFlag = false;
                settingsFlag = false;
            }
            else if (accessFlag == false)
            {
                Left = SystemParameters.PrimaryScreenWidth - 40;
                accessFlag = true;
            }
            else
            {
                Left = SystemParameters.PrimaryScreenWidth - 2;
                accessFlag = false;
            }
        }
 
        private void CloseButton_Click(object sender, RoutedEventArgs e)//Closes the application
        {
            this.Close();
            
        }

        private void VisiblityButton_Click(object sender, RoutedEventArgs e)//Makes the SideBar stick around or auto hide again
        {   
            if(accessFlag == true && settingsFlag == true && ControlBox.IsEnabled == true)
            {
                ControlBox.IsEnabled = false;
            }
            else if (accessFlag == true && settingsFlag == true && ControlBox.IsEnabled == false)
            {
                ControlBox.IsEnabled = true;
            }
            else if(ControlBox.IsEnabled == true)
            {
                ControlBox.IsEnabled = false;
            }
            else
            {
                ControlBox.IsEnabled = true;
            }
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)//Opens the Settings Panel
        {
            if(settingsFlag == false)
            {
                Left = SystemParameters.PrimaryScreenWidth - 550;
                Width = 550;
                ControlBox.Margin = new Thickness(-550,0,0,0);
                BackgroundColorChangerPanel.Visibility = Visibility.Visible;
                BackgroundColorChangerPanel.IsEnabled = true;
                settingsFlag = true;

                //Background Color Display
                SetBCCHexVal.Text = bgColorHex;
                SetBCCARGBAVal.Text = bgColorA.ToString();
                SetBCCARGBRVal.Text = bgColorR.ToString();
                SetBCCARGBGVal.Text = bgColorG.ToString();
                SetBCCARGBBVal.Text = bgColorB.ToString();

                //Text Color Display
                SetTCCHexVal.Text = tColorHex;
                SetTCCARGBAVal.Text = tColorA.ToString();
                SetTCCARGBRVal.Text = tColorR.ToString();
                SetTCCARGBGVal.Text = tColorG.ToString();
                SetTCCARGBBVal.Text = tColorB.ToString();

                //Control Color Display
                SetCCCHexVal.Text = cColorHex;
                SetCCCARGBAVal.Text = cColorA.ToString();
                SetCCCARGBRVal.Text = cColorR.ToString();
                SetCCCARGBGVal.Text = cColorG.ToString();
                SetCCCARGBBVal.Text = cColorB.ToString();
            }
            else
            {
                Left = SystemParameters.PrimaryScreenWidth - 40;
                Width = 40;
                ControlBox.Margin = new Thickness(-35, 0, 0, 0);
                BackgroundColorChangerPanel.Visibility = Visibility.Hidden;
                BackgroundColorChangerPanel.IsEnabled = false;
                settingsFlag = false;
            }

        }

        //Settings Panel Controls

        //Background Color Changer Controls
        private void SetBCCARGBAVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Alpha/Opacity SetBCC
        {
            if(Byte.TryParse(SetBCCARGBAVal.Text, out bgColorA))
            {
                if(bgColorA > 255)
                {
                    //do nothing
                }
                else
                {                   
                    Background = ConversionToBrushFromARGB(bgColorA,bgColorR,bgColorG,bgColorB);

                    //Code to Syncronize Hex
                    bgColorHex = ConversionFromBrushHex(Background);
                    SetBCCHexVal.Text = bgColorHex;

                }
            }else
            {
                bgColorA = 0;
                Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                //Code to Syncronize Hex 
                bgColorHex = ConversionFromBrushHex(Background);
                SetBCCHexVal.Text = bgColorHex;
            }

        }
        private void SetBCCARGBRVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Red SetBCC
        {
            if (Byte.TryParse(SetBCCARGBRVal.Text, out bgColorR))
            {
                if (bgColorR > 255)
                {
                    //do nothing
                }
                else
                {
                    Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                    //Code to Syncronize Hex
                    bgColorHex = ConversionFromBrushHex(Background);
                    SetBCCHexVal.Text = bgColorHex;

                }
            }
            else
            {
                bgColorR = 0;
                Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                //Code to Syncronize Hex
                bgColorHex = ConversionFromBrushHex(Background);
                SetBCCHexVal.Text = bgColorHex;
            }

        }
        private void SetBCCARGBGVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Green SetBCC
        {
            if (Byte.TryParse(SetBCCARGBGVal.Text, out bgColorG))
            {
                if (bgColorG > 255)
                {
                    //do nothing
                }
                else
                {
                    Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                    //Code to Syncronize Hex
                    bgColorHex = ConversionFromBrushHex(Background);
                    SetBCCHexVal.Text = bgColorHex;

                }
            }
            else
            {
                bgColorG = 0;
                Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                //Code to Syncronize Hex
                bgColorHex = ConversionFromBrushHex(Background);
                SetBCCHexVal.Text = bgColorHex;
            }
        }
        private void SetBCCARGBBVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Blue SetBCC
        {
            if (Byte.TryParse(SetBCCARGBBVal.Text, out bgColorB))
            {
                if (bgColorB > 255)
                {
                    //do nothing
                }
                else
                {
                    Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                    //Code to Syncronize Hex
                    bgColorHex = ConversionFromBrushHex(Background);
                    SetBCCHexVal.Text = bgColorHex;

                }
            }
            else
            {
                bgColorB = 0;
                Background = ConversionToBrushFromARGB(bgColorA, bgColorR, bgColorG, bgColorB);

                //Code to Syncronize Hex
                bgColorHex = ConversionFromBrushHex(Background);
                SetBCCHexVal.Text = bgColorHex;
            }
        }

        private void SetBCCHexVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Hex SetBCC
        {
            bgColorHex = SetBCCHexVal.Text;
            Char[] chars = bgColorHex.ToCharArray();
            
            if(bgColorHex == "")
            {
                SetBCCHexVal.Text = "#";
            }
            else
            {
                bool invalidFlag = false;
                bool lengthFlag = false;

                for(int i = 0; i < chars.Length; i++)
                {
                    if (chars.Length < 2)
                    {
                        SetBCCHexValLabel.Content = "Nothing";
                        lengthFlag = true;
                        break;
                    }
                    else if (chars.Length < 6)
                    {
                        SetBCCHexValLabel.Content = "Too Short";
                        lengthFlag = true;
                        break;
                    }
                    else if(chars.Length < 9)
                    {
                        SetBCCHexValLabel.Content = "Short";
                        lengthFlag = true;
                        break;
                    }
                    else if(ColorCharacterAvoidList.CheckChar(chars[i]) == 'y'){
                        SetBCCHexValLabel.Content = "Invalid";
                        invalidFlag = true;
                        break;
                    }
                    else
                    {
                        SetBCCHexValLabel.Content = "";
                        lengthFlag = false;
                        invalidFlag = false;
                    }
                }
                if (invalidFlag || lengthFlag)
                {
                    //do nothing
                }
                else
                {
                    Background = ConversionToBrushHex(bgColorHex);

                    //Code to syncronize the ARGB
                    Color bg = ConversionToColorFromBrush(Background);

                    //Makes an unintended bug of putting a zero when user nulls the textbox
                    bgColorA = bg.A;
                    bgColorR = bg.R;
                    bgColorG = bg.G;
                    bgColorB = bg.B;

                    SetBCCARGBAVal.Text = bgColorA.ToString();
                    SetBCCARGBRVal.Text = bgColorR.ToString();
                    SetBCCARGBGVal.Text = bgColorG.ToString();
                    SetBCCARGBBVal.Text = bgColorB.ToString();
                }
                
            }
        }

        //Text Color Changer Controls
        private void SetTCCARGBAVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Alpha/Opacity SetTCC
        {
            if (Byte.TryParse(SetTCCARGBAVal.Text, out tColorA))
            {
                if (tColorA > 255)
                {
                    //do nothing
                }
                else
                {
                    ForegroundSet(ConversionToBrushFromARGB(tColorA,tColorR,tColorG,tColorB));

                    //Code to Syncronize Hex
                    tColorHex = ConversionFromBrushHex(ForegroundGet());
                    SetTCCHexVal.Text = tColorHex;

                }
            }
            else
            {
                tColorA = 0;
                ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                //Code to Syncronize Hex
                tColorHex = ConversionFromBrushHex(ForegroundGet());
                SetTCCHexVal.Text = tColorHex;
            }
        }

        private void SetTCCARGBRVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Red SetTCC
        {
            if (Byte.TryParse(SetTCCARGBRVal.Text, out tColorR))
            {
                if (tColorR > 255)
                {
                    //do nothing
                }
                else
                {
                    ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                    //Code to Syncronize Hex
                    tColorHex = ConversionFromBrushHex(ForegroundGet());
                    SetTCCHexVal.Text = tColorHex;

                }
            }
            else
            {
                tColorR = 0;
                ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                //Code to Syncronize Hex
                tColorHex = ConversionFromBrushHex(ForegroundGet());
                SetTCCHexVal.Text = tColorHex;
            }
        }

        private void SetTCCARGBGVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Green SetTCC
        {
            if (Byte.TryParse(SetTCCARGBGVal.Text, out tColorG))
            {
                if (tColorG > 255)
                {
                    //do nothing
                }
                else
                {
                    ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                    //Code to Syncronize Hex
                    tColorHex = ConversionFromBrushHex(ForegroundGet());
                    SetTCCHexVal.Text = tColorHex;

                }
            }
            else
            {
                tColorG = 0;
                ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                //Code to Syncronize Hex
                tColorHex = ConversionFromBrushHex(ForegroundGet());
                SetTCCHexVal.Text = tColorHex;
            }
        }

        private void SetTCCARGBBVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Blue SetTCC
        {
            if (Byte.TryParse(SetTCCARGBBVal.Text, out tColorB))
            {
                if (tColorB > 255)
                {
                    //do nothing
                }
                else
                {
                    ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                    //Code to Syncronize Hex
                    tColorHex = ConversionFromBrushHex(ForegroundGet());
                    SetTCCHexVal.Text = tColorHex;

                }
            }
            else
            {
                tColorB = 0;
                ForegroundSet(ConversionToBrushFromARGB(tColorA, tColorR, tColorG, tColorB));

                //Code to Syncronize Hex
                tColorHex = ConversionFromBrushHex(ForegroundGet());
                SetTCCHexVal.Text = tColorHex;
            }
        }

        private void SetTCCHexVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Hex SetTCC
        {
            tColorHex = SetTCCHexVal.Text;
            Char[] chars = tColorHex.ToCharArray();

            if (tColorHex == "")
            {
                SetTCCHexVal.Text = "#";
            }
            else
            {
                bool invalidFlag = false;
                bool lengthFlag = false;

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars.Length < 2)
                    {
                        SetTCCHexValLabel.Content = "Nothing";
                        lengthFlag = true;
                        break;
                    }
                    else if (chars.Length < 6)
                    {
                        SetTCCHexValLabel.Content = "Too Short";
                        lengthFlag = true;
                        break;
                    }
                    else if (chars.Length < 9)
                    {
                        SetTCCHexValLabel.Content = "Short";
                        lengthFlag = true;
                        break;
                    }
                    else if (ColorCharacterAvoidList.CheckChar(chars[i]) == 'y')
                    {
                        SetTCCHexValLabel.Content = "Invalid";
                        invalidFlag = true;
                        break;
                    }
                    else
                    {
                        SetTCCHexValLabel.Content = "";
                        lengthFlag = false;
                        invalidFlag = false;
                    }
                }
                if (invalidFlag || lengthFlag)
                {
                    //do nothing
                }
                else
                {
                    ForegroundSet(ConversionToBrushHex(tColorHex));

                    //Code to syncronize the ARGB
                    Color t = ConversionToColorFromBrush(ForegroundGet());

                    //Makes an unintended bug of putting a zero when user nulls the textbox
                    tColorA = t.A;
                    tColorR = t.R;
                    tColorG = t.G;
                    tColorB = t.B;

                    SetTCCARGBAVal.Text = tColorA.ToString();
                    SetTCCARGBRVal.Text = tColorR.ToString();
                    SetTCCARGBGVal.Text = tColorG.ToString();
                    SetTCCARGBBVal.Text = tColorB.ToString();
                }

            }
        }

        //Control Color Changer Controls
        private void SetCCCARGBAVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Alpha/Opacity SetCCC
        {
            if (Byte.TryParse(SetCCCARGBAVal.Text, out cColorA))
            {
                if (cColorA > 255)
                {
                    //do nothing
                }
                else
                {
                    BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                    //Code to Syncronize Hex
                    cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                    SetCCCHexVal.Text = cColorHex;

                }
            }
            else
            {
                cColorA = 0;
                BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                //Code to Syncronize Hex 
                cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                SetCCCHexVal.Text = cColorHex;
            }
        }

        private void SetCCCARGBRVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Red SetCCC
        {
            if (Byte.TryParse(SetCCCARGBRVal.Text, out cColorR))
            {
                if (cColorR > 255)
                {
                    //do nothing
                }
                else
                {
                    BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                    //Code to Syncronize Hex
                    cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                    SetCCCHexVal.Text = cColorHex;

                }
            }
            else
            {
                cColorR = 0;
                BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                //Code to Syncronize Hex 
                cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                SetCCCHexVal.Text = cColorHex;
            }
        }

        private void SetCCCARGBGVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Green SetCCC
        {
            if (Byte.TryParse(SetCCCARGBGVal.Text, out cColorG))
            {
                if (cColorG > 255)
                {
                    //do nothing
                }
                else
                {
                    BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                    //Code to Syncronize Hex
                    cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                    SetCCCHexVal.Text = cColorHex;

                }
            }
            else
            {
                cColorG = 0;
                BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                //Code to Syncronize Hex 
                cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                SetCCCHexVal.Text = cColorHex;
            }
        }

        private void SetCCCARGBBVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Blue SetCCC
        {
            if (Byte.TryParse(SetCCCARGBBVal.Text, out cColorB))
            {
                if (cColorB > 255)
                {
                    //do nothing
                }
                else
                {
                    BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                    //Code to Syncronize Hex
                    cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                    SetCCCHexVal.Text = cColorHex;

                }
            }
            else
            {
                cColorB = 0;
                BackgroundTextBoxSet(ConversionToBrushFromARGB(cColorA, cColorR, cColorG, cColorB));

                //Code to Syncronize Hex 
                cColorHex = ConversionFromBrushHex(BackgroundTextBoxGet());
                SetCCCHexVal.Text = cColorHex;
            }
        }

        private void SetCCCHexVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Hex SetCCC
        {
            cColorHex = SetCCCHexVal.Text;
            Char[] chars = tColorHex.ToCharArray();

            if (cColorHex == "")
            {
                SetCCCHexVal.Text = "#";
            }
            else
            {
                bool invalidFlag = false;
                bool lengthFlag = false;

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars.Length < 2)
                    {
                        SetCCCHexValLabel.Content = "Nothing";
                        lengthFlag = true;
                        break;
                    }
                    else if (chars.Length < 6)
                    {
                        SetCCCHexValLabel.Content = "Too Short";
                        lengthFlag = true;
                        break;
                    }
                    else if (chars.Length < 9)
                    {
                        SetCCCHexValLabel.Content = "Short";
                        lengthFlag = true;
                        break;
                    }
                    else if (ColorCharacterAvoidList.CheckChar(chars[i]) == 'y')
                    {
                        SetCCCHexValLabel.Content = "Invalid";
                        invalidFlag = true;
                        break;
                    }
                    else
                    {
                        SetCCCHexValLabel.Content = "";
                        lengthFlag = false;
                        invalidFlag = false;
                    }
                }
                if (invalidFlag || lengthFlag)
                {
                    //do nothing
                }
                else
                {
                    BackgroundTextBoxSet(ConversionToBrushHex(cColorHex));

                    //Code to syncronize the ARGB
                    Color c = ConversionToColorFromBrush(BackgroundTextBoxGet());

                    //Makes an unintended bug of putting a zero when user nulls the textbox
                    cColorA = c.A;
                    cColorR = c.R;
                    cColorG = c.G;
                    cColorB = c.B;

                    SetTCCARGBAVal.Text = cColorA.ToString();
                    SetTCCARGBRVal.Text = cColorR.ToString();
                    SetTCCARGBGVal.Text = cColorG.ToString();
                    SetTCCARGBBVal.Text = cColorB.ToString();
                }

            }
        }
    }
}
