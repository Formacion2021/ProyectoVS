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

namespace _180221CursoLuckia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        double resFinal, resAcum;
        bool suma, resta, multiplicacion, division;

        private void Btn_clean_Click(object sender, RoutedEventArgs e)
        {
            textBoxResultado.Text = "0";
            resAcum = 0;
            resFinal = 0;
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "1";
            }
            else
            {
                textBoxResultado.Text += "1";
            }
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "2";
            }
            else
            {
                textBoxResultado.Text += "2";
            }
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "3";
            }
            else
            {
                textBoxResultado.Text += "3";
            }
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "4";
            }
            else
            {
                textBoxResultado.Text += "4";
            }
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "5";
            }
            else
            {
                textBoxResultado.Text += "5";
            }
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "6";
            }
            else
            {
                textBoxResultado.Text += "6";
            }
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "7";
            }
            else
            {
                textBoxResultado.Text += "7";
            }
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "8";
            }
            else
            {
                textBoxResultado.Text += "8";
            }
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "9";
            }
            else
            {
                textBoxResultado.Text += "9";
            }
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "0";
            }
            else
            {
                textBoxResultado.Text += "0";
            }
        }

        private void Btn_decimal_Click(object sender, RoutedEventArgs e)
        {
            if(!textBoxResultado.Text.EndsWith(","))
            {
                textBoxResultado.Text += ",";
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Version v_version = new Version();
            v_version.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItemAvanzada_Click(object sender, RoutedEventArgs e)
        {
            if (btn_masmenos.Visibility == Visibility.Visible && btn_porcentaje.Visibility == Visibility.Visible
                && btn_cuadrado.Visibility == Visibility.Visible)
            {
                menuItemAvanzada.Header = "Avanzada";
                btn_masmenos.Visibility = Visibility.Collapsed;
                btn_porcentaje.Visibility = Visibility.Collapsed;
                btn_cuadrado.Visibility = Visibility.Collapsed;
            }
            else if (btn_masmenos.Visibility == Visibility.Collapsed && btn_porcentaje.Visibility == Visibility.Collapsed
              && btn_cuadrado.Visibility == Visibility.Collapsed)
            {
                menuItemAvanzada.Header = "Simple";
                btn_masmenos.Visibility = Visibility.Visible;
                btn_porcentaje.Visibility = Visibility.Visible;
                btn_cuadrado.Visibility = Visibility.Visible;
            }
        }

        private void Btn_suma_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            textBoxResultado.Text = "";
            suma = true;
            resta = false;
            multiplicacion = false;
            division = false;
        }

        private void Btn_resta_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            textBoxResultado.Text = "";
            suma = false;
            resta = true;
            multiplicacion = false;
            division = false;
        }        

        private void Btn_mul_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            textBoxResultado.Text = "";
            suma = false;
            resta = false;
            multiplicacion = true;
            division = false;
        }

        private void Btn_div_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            textBoxResultado.Text = "";
            suma = false;
            resta = false;
            multiplicacion = false;
            division = true;
        }

        private void Btn_masmenos_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            resAcum = resAcum * (-1);
            textBoxResultado.Text = resAcum.ToString();
        }

        private void Btn_cuadrado_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            resAcum = resAcum * resAcum;
            textBoxResultado.Text = resAcum.ToString();
        }

        private void Btn_porcentaje_Click(object sender, RoutedEventArgs e)
        {
            resAcum = Convert.ToDouble(textBoxResultado.Text);
            resAcum = resAcum / 100;
            textBoxResultado.Text = resAcum.ToString();
        }

        private void Btn_resultado_Click(object sender, RoutedEventArgs e)
        {
            if (suma == true)
            {
                resFinal = resAcum + Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = resFinal.ToString();
                resAcum = 0;
            }
            else if (resta == true)
            {
                resFinal = resAcum - Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = resFinal.ToString();
                resAcum = 0;
            }
            else if (multiplicacion == true)
            {
                resFinal = resAcum * Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = resFinal.ToString();
                resAcum = 0;
            }
            else if (division == true)
            {
                resFinal = resAcum / Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = resFinal.ToString();
                resAcum = 0;
            }
        }
        
    }
}
