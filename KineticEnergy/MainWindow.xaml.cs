//Author: Group 1: Abhishek Sawant, Konrad Gaerdes, Rupal Pandya

using System.Windows;

namespace KineticEnergy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            vm.CalcKineticEnergy();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            vm.ClearEverything();
        }
    }
}
