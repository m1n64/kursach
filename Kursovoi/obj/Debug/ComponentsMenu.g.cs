﻿#pragma checksum "..\..\ComponentsMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51DE767AFCD2025E1604EA1889F2531D5B3D4573"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kursovoi;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Kursovoi {
    
    
    /// <summary>
    /// ComponentsMenu
    /// </summary>
    public partial class ComponentsMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 576 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectComponent;
        
        #line default
        #line hidden
        
        
        #line 577 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedComp;
        
        #line default
        #line hidden
        
        
        #line 578 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox DescComponent;
        
        #line default
        #line hidden
        
        
        #line 585 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PicComponent;
        
        #line default
        #line hidden
        
        
        #line 586 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CompName;
        
        #line default
        #line hidden
        
        
        #line 587 "..\..\ComponentsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PropNames;
        
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
            System.Uri resourceLocater = new System.Uri("/Kursovoi;component/componentsmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ComponentsMenu.xaml"
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
            this.SelectComponent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 576 "..\..\ComponentsMenu.xaml"
            this.SelectComponent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectComponent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectedComp = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.DescComponent = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 4:
            this.PicComponent = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.CompName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PropNames = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

