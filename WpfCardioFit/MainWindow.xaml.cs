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
using AllenamentoEfficace;

namespace WpfCardioFit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            string frequenza;
            frequenza = Gestione.btmMaxMin(int.Parse(txt_letturaeta.Text));
            string[] freqMaxMin = new string[2];
            freqMaxMin = frequenza.Split(" ");
            lbl_frequenzaMax.Content = freqMaxMin[0] + " btm";
            lbl_FrequenzaMin.Content = freqMaxMin[1] + " btm";
            int valore = int.Parse(txt_btmDaCercare.Text);
            bool Risultato = Gestione.BattitiRisposo(valore);
            if (Risultato)
                lbl_RIspostaBtmMedio.Content = "il valore inserito è presente nel file";
            else
                lbl_RIspostaBtmMedio.Content= "il valore  inserito non è presente nel file";



        }
    }
}
