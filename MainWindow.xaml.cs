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
        bool accessFlag = false;
        bool settingsFlag = false;
        string barColorA;
        string barColorR;
        string barColorG;
        string barColorB;
        public MainWindow()
        {
            InitializeComponent();
            Width = 40;
            Height = SystemParameters.PrimaryScreenHeight;
            Left = SystemParameters.PrimaryScreenWidth - 2;
            ControlBox.Height = SystemParameters.PrimaryScreenHeight;

            BackgroundColorChangerPanel.IsEnabled = false;
            BackgroundColorChangerPanel.Visibility = Visibility.Hidden;

            Brush background = Background;
            string bg = new BrushConverter().ConvertToString(background);
            
            for(int i = 0; i < bg.Length; i++)
            {
                if(i == 0)
                {
                    //do nothing
                }
                else if (i == 1 || i == 2)
                {
                    barColorA += bg[i];
                }
                else if (i == 3 || i == 4)
                {
                    barColorR += bg[i];
                }
                else if (i == 5 || i == 6)
                {
                    barColorG += bg[i];
                }
                else
                {
                    barColorB += bg[i];
                }

            }

            
        }

        private void ControlBox_MouseEnter(object sender, MouseEventArgs e)
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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void VisiblityButton_Click(object sender, RoutedEventArgs e)
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

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            if(settingsFlag == false)
            {
                Left = SystemParameters.PrimaryScreenWidth - 550;
                Width = 550;
                ControlBox.Margin = new Thickness(-550,0,0,0);
                BackgroundColorChangerPanel.Visibility = Visibility.Visible;
                BackgroundColorChangerPanel.IsEnabled = true;
                settingsFlag = true;

                SettingsBCCA.Text = barColorA;
                SettingsBCCR.Text = barColorR;
                SettingsBCCG.Text = barColorG;
                SettingsBCCB.Text = barColorB;
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

        private void SettingsBCCA_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SettingsBCCA.Text == null)
            {
                //do nothing
            }
            else if(SettingsBCCA.Text.Length == 0)
            {
                //do noting
            }
            else if(SettingsBCCA.Text.Length == 1)
            {
                //do nothing
            }
            else if(SettingsBCCA.Text.Length > 2)
            {
                //do nothing
            }
            else
            {
                barColorA = SettingsBCCA.Text;
                barColorR = SettingsBCCR.Text;
                barColorG = SettingsBCCG.Text;
                barColorB = SettingsBCCB.Text;

                string barBackground = "#";
                barBackground += barColorA;
                barBackground += barColorR;
                barBackground += barColorG;
                barBackground += barColorB;

                Brush brush = null;
                BrushConverter m = new BrushConverter();
                if (m.CanConvertFrom(typeof(string)))
                {
                    brush = (Brush)m.ConvertFromString(barBackground);
                }
                Background = brush;

            }

        }
        private void SettingsBCCR_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SettingsBCCR.Text == null)
            {
                //do nothing
            }
            else if (SettingsBCCR.Text.Length == 0)
            {
                //do noting
            }
            else if (SettingsBCCR.Text.Length == 1)
            {
                //do nothing
            }
            else if (SettingsBCCR.Text.Length > 2)
            {
                //do nothing
            }
            else
            {
                barColorA = SettingsBCCA.Text;
                barColorR = SettingsBCCR.Text;
                barColorG = SettingsBCCG.Text;
                barColorB = SettingsBCCB.Text;

                string barBackground = "#";
                barBackground += barColorA;
                barBackground += barColorR;
                barBackground += barColorG;
                barBackground += barColorB;

                Brush brush = null;
                BrushConverter m = new BrushConverter();
                if (m.CanConvertFrom(typeof(string)))
                {
                    brush = (Brush)m.ConvertFromString(barBackground);
                }
                Background = brush;


            }

        }
        private void SettingsBCCG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SettingsBCCG.Text == null)
            {
                //do nothing
            }
            else if (SettingsBCCG.Text.Length == 0)
            {
                //do noting
            }
            else if (SettingsBCCG.Text.Length == 1)
            {
                //do nothing
            }
            else if (SettingsBCCG.Text.Length > 2)
            {
                //do nothing
            }
            else
            {
                barColorA = SettingsBCCA.Text;
                barColorR = SettingsBCCR.Text;
                barColorG = SettingsBCCG.Text;
                barColorB = SettingsBCCB.Text;

                string barBackground = "#";
                barBackground += barColorA;
                barBackground += barColorR;
                barBackground += barColorG;
                barBackground += barColorB;

                Brush brush = null;
                BrushConverter m = new BrushConverter();
                if (m.CanConvertFrom(typeof(string)))
                {
                    brush = (Brush)m.ConvertFromString(barBackground);
                }
                Background = brush;


            }
        }
        private void SettingsBCCB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SettingsBCCB.Text == null)
            {
                //do nothing
            }
            else if (SettingsBCCB.Text.Length == 0)
            {
                //do noting
            }
            else if (SettingsBCCB.Text.Length == 1)
            {
                //do nothing
            }
            else if (SettingsBCCB.Text.Length > 2)
            {
                //do nothing
            }
            else
            {
                barColorA = SettingsBCCA.Text;
                barColorR = SettingsBCCR.Text;
                barColorG = SettingsBCCG.Text;
                barColorB = SettingsBCCB.Text;

                string barBackground = "#";
                barBackground += barColorA;
                barBackground += barColorR;
                barBackground += barColorG;
                barBackground += barColorB;

                Brush brush = null;
                BrushConverter m = new BrushConverter();
                if (m.CanConvertFrom(typeof(string)))
                {
                    brush = (Brush)m.ConvertFromString(barBackground);
                }
                Background = brush;


            }
        }
    }
}
