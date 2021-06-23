using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp6
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //DeviceEvents.AddDeviceDownHandler(TestButton, TestButton_OnDeviceDown);
        }


        private void TestButton_OnDeviceDown(object sender, DeviceInputArgs e)
        {
            //MessageBox.Show("TestButton_OnDeviceDown");
        }

        private void TestButton_OnDeviceUp(object sender, DeviceInputArgs e)
        {
            MessageBox.Show("TestButton_OnDeviceUp");
        }

        private void TestButton_OnDeviceMove(object sender, DeviceInputArgs e)
        {
            //MessageBox.Show("TestButton_OnDeviceMove");
        }
    }
}
