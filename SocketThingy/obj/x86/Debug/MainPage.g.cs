﻿

#pragma checksum "C:\Users\isamu_000\Documents\AkerProsjekt\Metro\SecondTry\SocketThingy2\SocketThingy\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47664AB77812624097BDDCBB9F9CDA5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocketThingy
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 25 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ExitButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 59 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.RunTest_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 63 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.sendText_TextChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 64 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.collectkake_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 65 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Coonnect3_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 66 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SendData_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

