using System;
using System.Windows;
using MASES.JNetGraphicCommon;
using MASES.JNet;
using Java.Awt.Event;
using System.ComponentModel;

namespace MASES.JNetWPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            JNetCore.CreateGlobalInstance();

            InitializeComponent();
#if NETFRAMEWORK
            Title = "Main Windows in WPF .NET Framework";
#else
            Title = "Main Windows in WPF .NET Core WindowsDesktop";
#endif
            if (MessageBox.Show("Create AWT?", "AWT/Swing question", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes) == MessageBoxResult.Yes)
            {
                jvmGropuBox.Content = GraphicCommon.CreateAWTContent(ActionDone);
                jvmGropuBox.Header = "JVM Control Area with TextArea and Button";
            }
            else
            {
                jvmGropuBox.Content = GraphicCommon.CreateSwingContent();
                jvmGropuBox.Header = "JVM Control Area with Integrated Swing content";
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            jvmGropuBox.Content = null;
            base.OnClosing(e);
        }

        void ActionDone(ActionEvent args)
        {
            tbOutput.Dispatcher.Invoke(() => tbOutput.Text += GraphicCommon.TextArea.getText() + Environment.NewLine);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = string.Empty;
        }
    }
}
