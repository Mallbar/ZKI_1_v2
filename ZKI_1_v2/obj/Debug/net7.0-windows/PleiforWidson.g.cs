﻿#pragma checksum "..\..\..\PleiforWidson.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AE3DA5DE3BB8AF6C4BE9C8AFCFCABB22E7C5278"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// PleiforWidson
    /// </summary>
    public partial class PleiforWidson : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxEncrypt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxDecrypt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWord;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textResult;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textPleifor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keyPleifor;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textPСS;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWСS1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\PleiforWidson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWСS2;
        
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
            System.Uri resourceLocater = new System.Uri("/ZKI;component/pleiforwidson.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PleiforWidson.xaml"
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
            
            #line 10 "..\..\..\PleiforWidson.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkBoxEncrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\PleiforWidson.xaml"
            this.checkBoxEncrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxEncrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkBoxDecrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\PleiforWidson.xaml"
            this.checkBoxDecrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxDecrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\PleiforWidson.xaml"
            this.textWord.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\PleiforWidson.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonFileSelect_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textResult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 17 "..\..\..\PleiforWidson.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textPleifor = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\PleiforWidson.xaml"
            this.textPleifor.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 9:
            this.keyPleifor = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\PleiforWidson.xaml"
            this.keyPleifor.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textPСS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.textWСS1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.textWСS2 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

