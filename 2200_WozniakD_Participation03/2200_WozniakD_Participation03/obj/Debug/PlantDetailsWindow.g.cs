﻿#pragma checksum "..\..\PlantDetailsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D87AD81027A3183CBD95247451F67413FDD17327898CFBEE9913A2436715B04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using _2200_WozniakD_Participation03;


namespace _2200_WozniakD_Participation03 {
    
    
    /// <summary>
    /// PlantDetailsWindow
    /// </summary>
    public partial class PlantDetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEnviornment;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblType;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSniff;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblNameResults;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblEnvResults;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PlantDetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTypResults;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/2200_WozniakD_Participation03;component/plantdetailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlantDetailsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LblEnviornment = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LblType = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BtnSniff = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\PlantDetailsWindow.xaml"
            this.BtnSniff.Click += new System.Windows.RoutedEventHandler(this.BtnSniff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LblNameResults = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.LblEnvResults = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.LblTypResults = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

