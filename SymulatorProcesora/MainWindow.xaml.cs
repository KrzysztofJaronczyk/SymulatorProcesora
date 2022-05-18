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

namespace SymulatorProcesora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            movButton.Click += MovButton_Click;
            xchgButton.Click += XchgButton_Click;

            resetButton.Click += ResetValuesButton_Click;
            resetButton_Copy.Click += ResetSelectedButton_Click;

            //fromAX.Checked += fromAX_Checked;
            //onAX.Checked += onAX_Checked;

            //fromBX.Checked += fromBX_Checked;
            //onBX.Checked += onBX_Checked;

            //fromCX.Checked += fromCX_Checked;
            //onCX.Checked += onCX_Checked;

            //fromDX.Checked += fromDX_Checked;
            //onDX.Checked += onDX_Checked;
        }

        #region RadioButtonsEvents
        private void raxbx_Checked(object sender, RoutedEventArgs e)
        {
            raxbx.IsChecked = false;
        }

        private void raxcx_Checked(object sender, RoutedEventArgs e)
        {
            raxcx.IsChecked = false;
        }

        private void raxdx_Checked(object sender, RoutedEventArgs e)
        {
            raxdx.IsChecked = false;
        }

        private void rbxax_Checked(object sender, RoutedEventArgs e)
        {
            rbxax.IsChecked = false;
        }

        private void rbxcx_Checked(object sender, RoutedEventArgs e)
        {
            rbxcx.IsChecked = false;
        }

        private void rbxdx_Checked(object sender, RoutedEventArgs e)
        {
            rbxdx.IsChecked = false;
        }

        private void rcxax_Checked(object sender, RoutedEventArgs e)
        {
            rcxax.IsChecked = false;
        }

        private void rcxbx_Checked(object sender, RoutedEventArgs e)
        {
            rcxbx.IsChecked = false;
        }

        private void rcxdx_Checked(object sender, RoutedEventArgs e)
        {
            rcxdx.IsChecked = false;
        }

        private void rdxax_Checked(object sender, RoutedEventArgs e)
        {
            rdxax.IsChecked = false;
        }

        private void rdxbx_Checked(object sender, RoutedEventArgs e)
        {
            rdxbx.IsChecked = false;
        }

        private void rdxcx_Checked(object sender, RoutedEventArgs e)
        {
            rdxcx.IsChecked = false;
        }
        #endregion




        private void ResetValuesButton_Click(object sender, RoutedEventArgs e)
        {
            axValue.Text = "0";
            bxValue.Text = "0";
            cxValue.Text = "0";
            dxValue.Text = "0";
        }

        private void ResetSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            axValue_Copy.Text = "0";
            bxValue_Copy.Text = "0";
            cxValue_Copy.Text = "0";
            dxValue_Copy.Text = "0";
        }


        #region Xchcg
        private void XchgButton_Click(object sender, RoutedEventArgs e)
        {
            if (raxbx.IsChecked == true)
            {
                string temp = bxValue_Copy.Text;
                bxValue_Copy.Text = OnlyHexInString(axValue.Text);
                axValue.Text = temp;
            }
            else if (raxcx.IsChecked == true)
            {

                string temp = cxValue_Copy.Text;
                cxValue_Copy.Text = OnlyHexInString(axValue.Text);
                axValue.Text = temp;
            }
            else if (raxdx.IsChecked == true)
            {
                string temp = dxValue_Copy.Text;
                dxValue_Copy.Text = OnlyHexInString(axValue.Text);
                axValue.Text = temp;
            }
            else if (rbxax.IsChecked == true)
            {
                string temp = axValue_Copy.Text;
                axValue_Copy.Text = OnlyHexInString(bxValue.Text);
                bxValue.Text = temp;
            }
            else if (rbxcx.IsChecked == true)
            {
                string temp = cxValue_Copy.Text;
                cxValue_Copy.Text = OnlyHexInString(bxValue.Text);
                bxValue.Text = temp;
            }
            else if (rbxdx.IsChecked == true)
            {
                string temp = dxValue_Copy.Text;
                dxValue_Copy.Text = OnlyHexInString(bxValue.Text);
                bxValue.Text = temp;
            }
            else if (rcxax.IsChecked == true)
            {
                string temp = axValue_Copy.Text;
                axValue_Copy.Text = OnlyHexInString(cxValue.Text);
                cxValue.Text = temp;
            }
            else if (rcxbx.IsChecked == true)
            {
                string temp = bxValue_Copy.Text;
                bxValue_Copy.Text = OnlyHexInString(cxValue.Text);
                cxValue.Text = temp;
            }
            else if (rcxdx.IsChecked == true)
            {
                string temp = dxValue_Copy.Text;
                dxValue_Copy.Text = OnlyHexInString(cxValue.Text);
                cxValue.Text = temp;
            }
           

            else if (rdxax.IsChecked == true)
            {
                string temp = axValue_Copy.Text;
                axValue_Copy.Text = OnlyHexInString(dxValue.Text);
                dxValue.Text = temp;
            }
            else if (rdxbx.IsChecked == true)
            {
                string temp = bxValue_Copy.Text;
                bxValue_Copy.Text = OnlyHexInString(dxValue.Text);
                dxValue.Text = temp;
            }
            else if (rdxcx.IsChecked == true)
            {
                string temp = cxValue_Copy.Text;
                cxValue_Copy.Text = OnlyHexInString(dxValue.Text);
                dxValue.Text = temp;
            }

            else
            {
                MessageBox.Show("Invalid selection for the MOV command.", "Invalid selection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion

        #region MoV
        private void MovButton_Click(object sender, RoutedEventArgs e)
        {
           if( raxbx.IsChecked == true)
            {
                bxValue_Copy.Text = OnlyHexInString(axValue.Text);
            }
            else if (raxcx.IsChecked == true)
            {
                cxValue_Copy.Text = OnlyHexInString(axValue.Text);
            }
           else  if (raxdx.IsChecked == true)
            {
                dxValue_Copy.Text = OnlyHexInString(axValue.Text);
            }

            else if (rbxax.IsChecked == true)
            {
                axValue_Copy.Text = OnlyHexInString(bxValue.Text);
            }
            else if (rbxcx.IsChecked == true)
            {
                cxValue_Copy.Text = OnlyHexInString(bxValue.Text);
            }
            else if (rbxdx.IsChecked == true)
            {
                dxValue_Copy.Text = OnlyHexInString(bxValue.Text);
            }

            else if (rcxax.IsChecked == true)
            {
                axValue_Copy.Text = OnlyHexInString(cxValue.Text);
            }

          else  if (rcxbx.IsChecked == true)
            {
                bxValue_Copy.Text = OnlyHexInString(cxValue.Text);
            }

          else  if (rcxdx.IsChecked == true)
            {
                dxValue_Copy.Text = OnlyHexInString(cxValue.Text);
            }

           else if (rdxax.IsChecked == true)
            {
                axValue_Copy.Text = OnlyHexInString(dxValue.Text);
            }

           else  if (rdxbx.IsChecked == true)
            {
                bxValue_Copy.Text = OnlyHexInString(dxValue.Text);
            }

           else if (rdxcx.IsChecked == true)
            {
                cxValue_Copy.Text = OnlyHexInString(dxValue.Text);
            }
else
            {
                MessageBox.Show("Invalid selection for the MOV command.", "Invalid selection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion

        public string OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            if (System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"))
            {
                return test;
            }
            else
            {
                MessageBox.Show($"{test} is not a valid hexadecimal number.", "Invalid value", MessageBoxButton.OK, MessageBoxImage.Information);
                //return "Podano złą wartość";
                return "0";
            }
        }
    }
}
