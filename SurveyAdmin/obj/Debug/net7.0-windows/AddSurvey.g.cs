﻿#pragma checksum "..\..\..\AddSurvey.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15C83325444AE035C12261C0563D11C92F25A602"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using SurveyAdmin;
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


namespace SurveyAdmin {
    
    
    /// <summary>
    /// AddSurvey
    /// </summary>
    public partial class AddSurvey : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Data_ankiety;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_survey;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Add_survey_name;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Add_Question_Type;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_question;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\AddSurvey.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_question_end;
        
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
            System.Uri resourceLocater = new System.Uri("/SurveyAdmin;component/addsurvey.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddSurvey.xaml"
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
            this.Data_ankiety = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Add_survey = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\AddSurvey.xaml"
            this.Add_survey.Click += new System.Windows.RoutedEventHandler(this.Add_survey_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Add_survey_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Add_Question_Type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Add_question = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\AddSurvey.xaml"
            this.Add_question.Click += new System.Windows.RoutedEventHandler(this.Add_question_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add_question_end = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\AddSurvey.xaml"
            this.Add_question_end.Click += new System.Windows.RoutedEventHandler(this.Add_question_end_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

