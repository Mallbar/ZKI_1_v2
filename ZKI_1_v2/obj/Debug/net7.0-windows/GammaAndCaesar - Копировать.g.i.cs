﻿#pragma checksum "..\..\..\GammaAndCaesar - Копировать.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46FB332789C0113DD107032057C97985EFE612BA"
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
    /// GammaAndCaesar
    /// </summary>
    public partial class GammaAndCaesar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxEncrypt;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxDecrypt;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textWord;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keyNumCaesar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textResult;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keyWordCaesar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textGamma;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\GammaAndCaesar - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textGammaGanerate;
        
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
            System.Uri resourceLocater = new System.Uri("/ZKI;V1.0.0.0;component/gammaandcaesar%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be" +
                    "%d0%b2%d0%b0%d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GammaAndCaesar - Копировать.xaml"
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
            
            #line 10 "..\..\..\GammaAndCaesar - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkBoxEncrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.checkBoxEncrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxEncrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkBoxDecrypt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.checkBoxDecrypt.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxDecrypt_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textWord = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.keyNumCaesar = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.keyNumCaesar.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\GammaAndCaesar - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonFileSelect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textResult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 18 "..\..\..\GammaAndCaesar - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.keyWordCaesar = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.keyWordCaesar.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textGamma = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.textGamma.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textGammaGanerate = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\GammaAndCaesar - Копировать.xaml"
            this.textGammaGanerate.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

