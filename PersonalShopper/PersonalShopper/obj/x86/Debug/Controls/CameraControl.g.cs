﻿#pragma checksum "E:\GIT\SITECORE\XConnectClient\PersonalShopper\PersonalShopper\Controls\CameraControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "888C8360B8F73404D07B3CAA6B9F6F33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalShopper.Controls
{
    partial class CameraControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Style(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.Style value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Style) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Style), targetNullValue);
                }
                obj.Style = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CameraControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICameraControl_Bindings
        {
            private global::PersonalShopper.Controls.CameraControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj4;
            private global::Windows.UI.Xaml.Controls.Button obj5;

            private CameraControl_obj1_BindingsTracking bindingsTracking;

            public CameraControl_obj1_Bindings()
            {
                this.bindingsTracking = new CameraControl_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Controls\CameraControl.xaml line 155
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 5: // Controls\CameraControl.xaml line 160
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // ICameraControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PersonalShopper.Controls.CameraControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PersonalShopper.Controls.CameraControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsInitialized(obj.IsInitialized, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CameraButtonStyle(obj.CameraButtonStyle, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CanSwitch(obj.CanSwitch, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SwitchCameraButtonStyle(obj.SwitchCameraButtonStyle, phase);
                    }
                }
            }
            private void Update_IsInitialized(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\CameraControl.xaml line 155
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_CameraButtonStyle(global::Windows.UI.Xaml.Style obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\CameraControl.xaml line 155
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Style(this.obj4, obj, null);
                }
            }
            private void Update_CanSwitch(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_CanSwitch_Cast_CanSwitch_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_CanSwitch_Cast_CanSwitch_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\CameraControl.xaml line 160
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, obj);
                }
            }
            private void Update_SwitchCameraButtonStyle(global::Windows.UI.Xaml.Style obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\CameraControl.xaml line 160
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Style(this.obj5, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CameraControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<CameraControl_obj1_Bindings> weakRefToBindingObj; 

                public CameraControl_obj1_BindingsTracking(CameraControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CameraControl_obj1_Bindings>(obj);
                }

                public CameraControl_obj1_Bindings TryGetBindingObject()
                {
                    CameraControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_IsInitialized(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CameraControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::PersonalShopper.Controls.CameraControl obj = sender as global::PersonalShopper.Controls.CameraControl;
                        if (obj != null)
                        {
                            bindings.Update_IsInitialized(obj.IsInitialized, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_CanSwitch(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    CameraControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::PersonalShopper.Controls.CameraControl obj = sender as global::PersonalShopper.Controls.CameraControl;
                        if (obj != null)
                        {
                            bindings.Update_CanSwitch(obj.CanSwitch, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_IsInitialized = 0;
                private long tokenDPC_CanSwitch = 0;
                public void UpdateChildListeners_(global::PersonalShopper.Controls.CameraControl obj)
                {
                    CameraControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::PersonalShopper.Controls.CameraControl.IsInitializedProperty, tokenDPC_IsInitialized);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::PersonalShopper.Controls.CameraControl.CanSwitchProperty, tokenDPC_CanSwitch);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_IsInitialized = obj.RegisterPropertyChangedCallback(global::PersonalShopper.Controls.CameraControl.IsInitializedProperty, DependencyPropertyChanged_IsInitialized);
                            tokenDPC_CanSwitch = obj.RegisterPropertyChangedCallback(global::PersonalShopper.Controls.CameraControl.CanSwitchProperty, DependencyPropertyChanged_CanSwitch);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Controls\CameraControl.xaml line 138
                {
                    this.PreviewControl = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 3: // Controls\CameraControl.xaml line 149
                {
                    this.errorMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Controls\CameraControl.xaml line 155
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.CaptureButton_Click;
                }
                break;
            case 5: // Controls\CameraControl.xaml line 160
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.SwitchButton_Click;
                }
                break;
            case 6: // Controls\CameraControl.xaml line 145
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
            switch(connectionId)
            {
            case 1: // Controls\CameraControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    CameraControl_obj1_Bindings bindings = new CameraControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
