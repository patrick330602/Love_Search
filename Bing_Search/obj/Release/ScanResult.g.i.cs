﻿#pragma checksum "C:\Users\Backup\documents\visual studio 2013\Projects\Bing_Search\Bing_Search\ScanResult.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29D98DAF490434C77B10F7970C9BD4EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WP7BarcodeScannerExample {
    
    
    public partial class ScanResult : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Imaging.BitmapImage s;
        
        internal System.Windows.Media.ImageBrush h;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock scanResult;
        
        internal System.Windows.Controls.Button btn_CreateSimple;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Bing_Search;component/ScanResult.xaml", System.UriKind.Relative));
            this.s = ((System.Windows.Media.Imaging.BitmapImage)(this.FindName("s")));
            this.h = ((System.Windows.Media.ImageBrush)(this.FindName("h")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.scanResult = ((System.Windows.Controls.TextBlock)(this.FindName("scanResult")));
            this.btn_CreateSimple = ((System.Windows.Controls.Button)(this.FindName("btn_CreateSimple")));
        }
    }
}
