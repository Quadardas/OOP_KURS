using System.Windows;
using System.Windows.Input;

namespace OOP_KURS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //public List<string> BadZubs = new List<string>();

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Zubs zubs = new Zubs();
            zubs.Show();
        }
    }
}
