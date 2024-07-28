using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace lab_mdk_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Queue<string> queue1 = new Queue<string>();
        public MainWindow()
        {
            InitializeComponent();
            lbQueue.DataContext = this;

        }
        public Queue<string> Queue1
        {
            get { return queue1; }
            set
            {
                queue1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Queue1"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queue1.Enqueue(tbElementQueue.Text);
            Queue1 = new Queue<string>(queue1);
            tbElementQueue.Text = "";
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            queue1.Dequeue();
            Queue1 = new Queue<string>(queue1);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int totalLength = 0;
            foreach (string item in queue1)
            {
                totalLength += item.Length;
            }

            tbResultQueue.Text = $"суммарная длина очереди: {totalLength}";
        }
    }
}