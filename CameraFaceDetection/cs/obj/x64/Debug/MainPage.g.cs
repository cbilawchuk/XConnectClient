﻿#pragma checksum "E:\GIT\SITECORE\XConnectClient\CameraFaceDetection\shared\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6AF608ABAAA8EDD87A63697A8A57BE5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceDetection
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 59
                {
                    this.PreviewControl = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 3: // MainPage.xaml line 201
                {
                    this.BadgeText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 209
                {
                    this.EmailBock = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // MainPage.xaml line 210
                {
                    this.InstructionMsg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // MainPage.xaml line 211
                {
                    this.EmailAddressLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 212
                {
                    this.EmailAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.EmailAddress).TextChanged += this.textChangedEventHandler;
                }
                break;
            case 8: // MainPage.xaml line 215
                {
                    this.OCRDetectionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OCRDetectionButton).Click += this.OCRDetectionButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 216
                {
                    this.ResetButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ResetButton).Click += this.ResetButton_Click;
                }
                break;
            case 10: // MainPage.xaml line 185
                {
                    this.BadgePreviewLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainPage.xaml line 190
                {
                    this.BadgePreview = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12: // MainPage.xaml line 166
                {
                    this.FacePreviewLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // MainPage.xaml line 171
                {
                    this.FacePreview = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14: // MainPage.xaml line 125
                {
                    this.PhotoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PhotoButton).Click += this.PhotoButton_Click;
                }
                break;
            case 15: // MainPage.xaml line 110
                {
                    this.FaceDetectionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FaceDetectionButton).Click += this.FaceDetectionButton_Click;
                }
                break;
            case 16: // MainPage.xaml line 117
                {
                    this.FaceDetectionDisabledIcon = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 17: // MainPage.xaml line 118
                {
                    this.FaceDetectionEnabledIcon = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                }
                break;
            case 18: // MainPage.xaml line 83
                {
                    this.CropZone = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 19: // MainPage.xaml line 72
                {
                    this.FacesCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

