// Updated by XamlIntelliSenseFileGenerator 11/20/2022 4:06:21 PM
#pragma checksum "..\..\..\..\..\resources\views\Students\CreateUpdateStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0500DF20402C638AA8F037366AE13CEBC1930676410534F39C3B989E7863803"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SkolaJezika.resources.views.Students;
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


namespace SkolaJezika.resources.views.Students
{


    /// <summary>
    /// CreateUpdateStudent
    /// </summary>
    public partial class CreateUpdateStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SR38-2021-POP2022;component/resources/views/students/createupdatestudent.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\resources\views\Students\CreateUpdateStudent.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtFirstName;
        internal System.Windows.Controls.TextBox txtLastName;
        internal System.Windows.Controls.TextBox txtPersonalIdentityNumber;
        internal System.Windows.Controls.ComboBox comboGender;
        internal System.Windows.Controls.TextBox txtEmail;
        internal System.Windows.Controls.PasswordBox txtPassword;
        internal System.Windows.Controls.TextBox txtStreetAddress;
        internal System.Windows.Controls.TextBox txtStreetNumber;
        internal System.Windows.Controls.TextBox txtCity;
        internal System.Windows.Controls.TextBox txtCountry;
        internal System.Windows.Controls.Button btnRegister;
        internal System.Windows.Controls.Button btnCancel;
    }
}

