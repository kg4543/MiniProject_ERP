﻿#pragma checksum "..\..\..\..\View\OPS\OperationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "160D75D5B657368F59D267D171D6F3BEC4615812EA13DC406C80985AF404527A"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using ERPAPP.View.OPS;
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


namespace ERPAPP.View.OPS {
    
    
    /// <summary>
    /// OperationView
    /// </summary>
    public partial class OperationView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearchCode;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearchName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSearch;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GrdData;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GrdOp;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\View\OPS\OperationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime;
        
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
            System.Uri resourceLocater = new System.Uri("/ERPAPP;component/view/ops/operationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\OPS\OperationView.xaml"
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
            
            #line 10 "..\..\..\..\View\OPS\OperationView.xaml"
            ((ERPAPP.View.OPS.OperationView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtSearchCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\View\OPS\OperationView.xaml"
            this.TxtSearchCode.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtSearchCode_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\View\OPS\OperationView.xaml"
            this.TxtSearchName.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtSearchName_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\View\OPS\OperationView.xaml"
            this.BtnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GrdData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 60 "..\..\..\..\View\OPS\OperationView.xaml"
            this.GrdData.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.GrdData_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GrdOp = ((System.Windows.Controls.DataGrid)(target));
            
            #line 87 "..\..\..\..\View\OPS\OperationView.xaml"
            this.GrdOp.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.GrdData_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblTime = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

