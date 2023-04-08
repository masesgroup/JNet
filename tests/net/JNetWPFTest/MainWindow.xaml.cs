/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using System;
using System.Windows;
using MASES.JNetTest.GraphicCommon;
using Java.Awt.EventNs;
using System.ComponentModel;
using MASES.JNetTest.Common;

namespace MASES.JNetWPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            JNetTestCore.CreateGlobalInstance();

            InitializeComponent();
#if NET462_OR_GREATER
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
            tbOutput.Dispatcher.Invoke(() => tbOutput.Text += GraphicCommon.TextArea.Text + Environment.NewLine);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = string.Empty;
        }
    }
}
