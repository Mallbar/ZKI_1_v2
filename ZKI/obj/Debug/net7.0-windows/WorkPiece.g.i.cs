﻿#pragma checksum "..\..\..\WorkPiece.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61CA9369ED90A05AAA40E71125B0CF5F46E7BDA0"
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
using ZKI_1_v2;


namespace ZKI_1_v2 {
    
    
    /// <summary>
    /// Window
    /// </summary>
    public partial class Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WorkPiece.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxEncrypt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WorkPiece.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxDecrypt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WorkPiece.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxWord;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WorkPiece.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxKey;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WorkPiece.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxResult;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZKI_1_v2;V1.0.0.0;component/workpiece.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WorkPiece.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\WorkPiece.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkBoxEncrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\WorkPiece.xaml"
            this.checkBoxEncrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxEncrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkBoxDecrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\WorkPiece.xaml"
            this.checkBoxDecrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxDecrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxWord = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\WorkPiece.xaml"
            this.textBoxKey.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\WorkPiece.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonFileSelect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxResult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 18 "..\..\..\WorkPiece.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

