﻿#pragma checksum "..\..\..\DisplayIssueWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80CE8F8D50A2C2AFDD37801184AD088218660971"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ST10048211_PROG7312_POE_PART_1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ST10048211_PROG7312_POE_PART_1 {
    
    
    /// <summary>
    /// DisplayIssueWindow
    /// </summary>
    public partial class DisplayIssueWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\DisplayIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHeading;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\DisplayIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstIssues;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\DisplayIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMainMenu;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\DisplayIssueWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReportIssue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ST10048211_PROG7312_POE_PART_1;component/displayissuewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DisplayIssueWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblHeading = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lstIssues = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnMainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\DisplayIssueWindow.xaml"
            this.btnMainMenu.Click += new System.Windows.RoutedEventHandler(this.btnMainMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReportIssue = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\DisplayIssueWindow.xaml"
            this.btnReportIssue.Click += new System.Windows.RoutedEventHandler(this.btnReportIssue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

