﻿#pragma checksum "..\..\Graphic.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13A6E240D8A5F6788B87C446292D780685DF208C0F59237942C3775142CE1A87"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GraphicTool;
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


namespace GraphicTool {
    
    
    /// <summary>
    /// Graphic
    /// </summary>
    public partial class Graphic : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem undo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem redo;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid root;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas ic;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbEditingMode;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\Graphic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbDrawingAttributes;
        
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
            System.Uri resourceLocater = new System.Uri("/GraphicTool;component/graphic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Graphic.xaml"
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
            
            #line 10 "..\..\Graphic.xaml"
            ((GraphicTool.Graphic)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\Graphic.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveintoFile);
            
            #line default
            #line hidden
            return;
            case 3:
            this.undo = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\Graphic.xaml"
            this.undo.Click += new System.Windows.RoutedEventHandler(this.Undo);
            
            #line default
            #line hidden
            return;
            case 4:
            this.redo = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\Graphic.xaml"
            this.redo.Click += new System.Windows.RoutedEventHandler(this.Redo);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 48 "..\..\Graphic.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Undo);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 50 "..\..\Graphic.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Redo);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\Graphic.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Clear);
            
            #line default
            #line hidden
            return;
            case 8:
            this.root = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.ic = ((System.Windows.Controls.InkCanvas)(target));
            
            #line 106 "..\..\Graphic.xaml"
            this.ic.StrokeCollected += new System.Windows.Controls.InkCanvasStrokeCollectedEventHandler(this.ic_StrokeCollected);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lbEditingMode = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.lbDrawingAttributes = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
