﻿#pragma checksum "..\..\..\VigenerAndCaesar - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBB8523B169E66BF8EA187F64299E1C906D15B44"
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
    /// VigenerAndCaesar
    /// </summary>
    public partial class VigenerAndCaesar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxEncrypt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxDecrypt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxWord;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCaesarKeyNum;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxResult;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCaesarKeyWord;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxVigenerKeyWord;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\VigenerAndCaesar - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxVigenerСryptosystem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZKI;V1.0.0.0;component/vigenerandcaesar%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VigenerAndCaesar - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\VigenerAndCaesar - Copy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkBoxEncrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\VigenerAndCaesar - Copy.xaml"
            this.checkBoxEncrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxEncrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkBoxDecrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\VigenerAndCaesar - Copy.xaml"
            this.checkBoxDecrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxDecrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxWord = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxCaesarKeyNum = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\VigenerAndCaesar - Copy.xaml"
            this.textBoxCaesarKeyNum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\VigenerAndCaesar - Copy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonFileSelect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxResult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 18 "..\..\..\VigenerAndCaesar - Copy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textBoxCaesarKeyWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\VigenerAndCaesar - Copy.xaml"
            this.textBoxCaesarKeyWord.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBoxVigenerKeyWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\VigenerAndCaesar - Copy.xaml"
            this.textBoxVigenerKeyWord.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBoxVigenerСryptosystem = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

