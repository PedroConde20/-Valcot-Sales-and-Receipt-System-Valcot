﻿#pragma checksum "..\..\..\Stock\winAdmTiposdeVinos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB45AEB8F42CD0A6ABB9E41540DDAD328386D0BE63F727171875DE6ED0315F97"
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
using ValcotDB.Stock;


namespace ValcotDB.Stock {
    
    
    /// <summary>
    /// winAdmTiposdeVinos
    /// </summary>
    public partial class winAdmTiposdeVinos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoryWine;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescriptionWine;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvDatos;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsert;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancerlar;
        
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
            System.Uri resourceLocater = new System.Uri("/ValcotDB;component/stock/winadmtiposdevinos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
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
            
            #line 16 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            ((ValcotDB.Stock.winAdmTiposdeVinos)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCategoryWine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDescriptionWine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dgvDatos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.dgvDatos.Loaded += new System.Windows.RoutedEventHandler(this.dgvDatos_Loaded);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.dgvDatos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvDatos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnInsert = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnInsert.Click += new System.Windows.RoutedEventHandler(this.btnInsert_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCancerlar = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Stock\winAdmTiposdeVinos.xaml"
            this.btnCancerlar.Click += new System.Windows.RoutedEventHandler(this.btnCancerlar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

