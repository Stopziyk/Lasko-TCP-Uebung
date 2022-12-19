﻿using System;
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

namespace TCPDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBox lb = new ListBox();
            Content = lb;
            FontSize = 21;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener server = 
                new TcpListener(ip,8088);
            server.Start();
            MessageBox.Show("server started");
            TcpClient client = 
            server.AcceptTcpClient();
            MessageBox.Show("new client");
            StreamReader reader =
                new StreamReader(client.GetStream());
            string Nachricht = reader.ReadLine();
            lb.Items.Add(Nachricht);
        }
    }
}
