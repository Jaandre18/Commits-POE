﻿#pragma checksum "..\..\..\Views\HomePg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7FD643283B147EE1F4A85BF5DACDAC23874E29984FDE6755C6BCC6F2579D4B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Recipes_Menu.Views;
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


namespace Recipes_Menu.Views {
    
    
    /// <summary>
    /// HomePg
    /// </summary>
    public partial class HomePg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\HomePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRecipeName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\HomePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIngredients;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\HomePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSteps;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\HomePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Groups;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\HomePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCalories;
        
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
            System.Uri resourceLocater = new System.Uri("/Recipes_Menu;component/views/homepg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\HomePg.xaml"
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
            this.txtRecipeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtIngredients = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSteps = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Groups = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\Views\HomePg.xaml"
            this.Groups.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_FoodGroup);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtCalories = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 32 "..\..\..\Views\HomePg.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 33 "..\..\..\Views\HomePg.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
