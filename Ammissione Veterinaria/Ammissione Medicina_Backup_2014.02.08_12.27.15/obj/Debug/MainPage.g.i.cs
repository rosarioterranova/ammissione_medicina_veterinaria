﻿#pragma checksum "C:\Users\Rosario\documents\visual studio 2012\Projects\Ammissione Medicina\Ammissione Medicina\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DF5E92D508AC0C2A6B5B11A781DD72F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.34003
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using RateMyApp.Controls;
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


namespace Ammissione_Medicina {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PanoramaItem novità;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image logo;
        
        internal System.Windows.Controls.Button loadFeedButton;
        
        internal System.Windows.Controls.ListBox feedListBox;
        
        internal System.Windows.Controls.Border border1;
        
        internal Microsoft.Phone.Controls.PanoramaItem servizi;
        
        internal System.Windows.Controls.StackPanel bandoPannel;
        
        internal System.Windows.Controls.StackPanel provePannel;
        
        internal System.Windows.Controls.StackPanel datePannel;
        
        internal System.Windows.Controls.StackPanel punteggiMinPannel;
        
        internal Microsoft.Phone.Controls.PanoramaItem info;
        
        internal System.Windows.Controls.Button votaApp;
        
        internal System.Windows.Controls.Button contattami;
        
        internal System.Windows.Controls.Button altre_app;
        
        internal RateMyApp.Controls.FeedbackOverlay votami;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Ammissione%20Medicina;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.novità = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("novità")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.logo = ((System.Windows.Controls.Image)(this.FindName("logo")));
            this.loadFeedButton = ((System.Windows.Controls.Button)(this.FindName("loadFeedButton")));
            this.feedListBox = ((System.Windows.Controls.ListBox)(this.FindName("feedListBox")));
            this.border1 = ((System.Windows.Controls.Border)(this.FindName("border1")));
            this.servizi = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("servizi")));
            this.bandoPannel = ((System.Windows.Controls.StackPanel)(this.FindName("bandoPannel")));
            this.provePannel = ((System.Windows.Controls.StackPanel)(this.FindName("provePannel")));
            this.datePannel = ((System.Windows.Controls.StackPanel)(this.FindName("datePannel")));
            this.punteggiMinPannel = ((System.Windows.Controls.StackPanel)(this.FindName("punteggiMinPannel")));
            this.info = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("info")));
            this.votaApp = ((System.Windows.Controls.Button)(this.FindName("votaApp")));
            this.contattami = ((System.Windows.Controls.Button)(this.FindName("contattami")));
            this.altre_app = ((System.Windows.Controls.Button)(this.FindName("altre_app")));
            this.votami = ((RateMyApp.Controls.FeedbackOverlay)(this.FindName("votami")));
        }
    }
}
