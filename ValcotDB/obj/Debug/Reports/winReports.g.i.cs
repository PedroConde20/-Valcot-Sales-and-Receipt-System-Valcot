﻿#pragma checksum "..\..\..\Reports\winReports.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EA4E48961BF3B5928B9237E362D186D3EB59C84F50BC31E958F93B7ADBB6C4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RootLibrary.WPF.Localization;
using SAPBusinessObjects.WPF.Viewer;
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
using ValcotDB.Reports;


namespace ValcotDB.Reports {
    
    
    /// <summary>
    /// winReports
    /// </summary>
    public partial class winReports : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpInicio;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFin;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReporte1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReporte2;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReporte3;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Reports\winReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer viewer;
        
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
            System.Uri resourceLocater = new System.Uri("/ValcotDB;component/reports/winreports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reports\winReports.xaml"
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
            
            #line 19 "..\..\..\Reports\winReports.xaml"
            ((ValcotDB.Reports.winReports)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Reports\winReports.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dtpInicio = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.dtpFin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.btnReporte1 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Reports\winReports.xaml"
            this.btnReporte1.Click += new System.Windows.RoutedEventHandler(this.btnReporte1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReporte2 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Reports\winReports.xaml"
            this.btnReporte2.Click += new System.Windows.RoutedEventHandler(this.btnReporte2_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnReporte3 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Reports\winReports.xaml"
            this.btnReporte3.Click += new System.Windows.RoutedEventHandler(this.btnReporte3_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.viewer = ((SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

