﻿#pragma checksum "..\..\..\SubjectsUI\SubjectsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6D7188CBBBC3115441F0DEA2F4FEFA13338069E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SuccessJournal.SubjectsUI;
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


namespace SuccessJournal.SubjectsUI {
    
    
    /// <summary>
    /// SubjectsPage
    /// </summary>
    public partial class SubjectsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\SubjectsUI\SubjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnCreateSubject;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\SubjectsUI\SubjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnRemoveSubject;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\SubjectsUI\SubjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdSubjects;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\SubjectsUI\SubjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItem_EditSubject;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\SubjectsUI\SubjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItem_RemoveSubject;
        
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
            System.Uri resourceLocater = new System.Uri("/SuccessJournal;component/subjectsui/subjectspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubjectsUI\SubjectsPage.xaml"
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
            
            #line 17 "..\..\..\SubjectsUI\SubjectsPage.xaml"
            ((SuccessJournal.SubjectsUI.SubjectsPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCreateSubject = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\..\SubjectsUI\SubjectsPage.xaml"
            this.btnCreateSubject.Click += new System.Windows.RoutedEventHandler(this.btnCreateSubject_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRemoveSubject = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\SubjectsUI\SubjectsPage.xaml"
            this.btnRemoveSubject.Click += new System.Windows.RoutedEventHandler(this.btnRemoveSubject_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grdSubjects = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.MenuItem_EditSubject = ((System.Windows.Controls.MenuItem)(target));
            
            #line 49 "..\..\..\SubjectsUI\SubjectsPage.xaml"
            this.MenuItem_EditSubject.Click += new System.Windows.RoutedEventHandler(this.MenuItem_EditSubject_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MenuItem_RemoveSubject = ((System.Windows.Controls.MenuItem)(target));
            
            #line 50 "..\..\..\SubjectsUI\SubjectsPage.xaml"
            this.MenuItem_RemoveSubject.Click += new System.Windows.RoutedEventHandler(this.btnRemoveSubject_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
