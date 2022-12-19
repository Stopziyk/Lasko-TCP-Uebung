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
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TCPDemoClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Client";
            IPAddress serverip =
                IPAddress.Parse("127.0.0.1");
            TcpClient meClient =
                new TcpClient("127.0.0.1", 8088);
            StreamWriter writer =
                new StreamWriter(
                    meClient.GetStream());
            writer.WriteLine("Moin!");
            writer.Flush();
        }
    }
}
