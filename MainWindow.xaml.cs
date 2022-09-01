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
        Color bgColorHex;
        
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

            string colorbg = new BrushConverter().ConvertToString(Background);
            Color bg = (Color) ColorConverter.ConvertFromString(colorbg);

            bgColorHex = bg;
            bgColorA = bg.A;
            bgColorR = bg.R;
            bgColorG = bg.G;
            bgColorB = bg.B;
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

                SetBCCHexVal.Text = bgColorHex.ToString();
                SetBCCAVal.Text = bgColorA.ToString();
                SetBCCRVal.Text = bgColorR.ToString();
                SetBCCGVal.Text = bgColorG.ToString();
                SetBCCBVal.Text = bgColorB.ToString();
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
        private void SetBCCAVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Alpha/Opacity SetBCC
        {
            if(Byte.TryParse(SetBCCAVal.Text, out bgColorA))
            {
                if(bgColorA > 255)
                {
                    //do nothing
                }
                else
                {
                    Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                    string colorbg = new ColorConverter().ConvertToString(bg);
                    Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
                }
            }else
            {
                bgColorA = 0;
                Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                string colorbg = new ColorConverter().ConvertToString(bg);
                Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
            }

        }
        private void SetBCCRVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Red SetBCC
        {
            if (Byte.TryParse(SetBCCRVal.Text, out bgColorR))
            {
                if (bgColorR > 255)
                {
                    //do nothing
                }
                else
                {
                    Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                    string colorbg = new ColorConverter().ConvertToString(bg);
                    Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
                }
            }
            else
            {
                bgColorR = 0;
                Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                string colorbg = new ColorConverter().ConvertToString(bg);
                Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
            }

        }
        private void SetBCCGVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Green SetBCC
        {
            if (Byte.TryParse(SetBCCGVal.Text, out bgColorG))
            {
                if (bgColorG > 255)
                {
                    //do nothing
                }
                else
                {
                    Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                    string colorbg = new ColorConverter().ConvertToString(bg);
                    Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
                }
            }
            else
            {
                bgColorG = 0;
                Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                string colorbg = new ColorConverter().ConvertToString(bg);
                Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
            }
        }
        private void SetBCCBVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Blue SetBCC
        {
            if (Byte.TryParse(SetBCCBVal.Text, out bgColorB))
            {
                if (bgColorB > 255)
                {
                    //do nothing
                }
                else
                {
                    Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                    string colorbg = new ColorConverter().ConvertToString(bg);
                    Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
                }
            }
            else
            {
                bgColorB = 0;
                Color bg = Color.FromArgb(bgColorA, bgColorR, bgColorG, bgColorB);
                string colorbg = new ColorConverter().ConvertToString(bg);
                Background = (Brush)new BrushConverter().ConvertFromString(colorbg);
            }
        }

        private void SetBCCHexVal_TextChanged(object sender, TextChangedEventArgs e)//Any input to the Hex SetBCC
        {//Improvement needed//run against a list that will look for specific characters to remove from input
            string color = new ColorConverter().ConvertToString(bgColorHex);
            Background = (Brush)new BrushConverter().ConvertFromString(color);

            //additonal code for change accross the board
        }
    }
}
