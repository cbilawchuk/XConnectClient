﻿#pragma checksum "C:\GIT\SITECORE\XConnectClient\PersonalShopper\PersonalShopper\Views\ShellPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0746077653C80CCBA66BB5AD4EC2110E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalShopper.Views
{
    partial class ShellPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_NavigationView_SelectedItem(global::Windows.UI.Xaml.Controls.NavigationView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_NavigationView_Header(global::Windows.UI.Xaml.Controls.NavigationView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ShellPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IShellPage_Bindings
        {
            private global::PersonalShopper.Views.ShellPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.NavigationView obj2;

            private ShellPage_obj1_BindingsTracking bindingsTracking;

            public ShellPage_obj1_Bindings()
            {
                this.bindingsTracking = new ShellPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ShellPage.xaml line 11
                        this.obj2 = (global::Windows.UI.Xaml.Controls.NavigationView)target;
                        break;
                    default:
                        break;
                }
            }

            // IShellPage_Bindings

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
                    this.dataRoot = (global::PersonalShopper.Views.ShellPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PersonalShopper.Views.ShellPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Selected(obj.Selected, phase);
                    }
                }
            }
            private void Update_Selected(global::Windows.UI.Xaml.Controls.NavigationViewItem obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Selected(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Selected_Content(obj.Content, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ShellPage.xaml line 11
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_NavigationView_SelectedItem(this.obj2, obj, null);
                }
            }
            private void Update_Selected_Content(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ShellPage.xaml line 11
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_NavigationView_Header(this.obj2, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ShellPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ShellPage_obj1_Bindings> weakRefToBindingObj; 

                public ShellPage_obj1_BindingsTracking(ShellPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ShellPage_obj1_Bindings>(obj);
                }

                public ShellPage_obj1_Bindings TryGetBindingObject()
                {
                    ShellPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_Selected(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ShellPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::PersonalShopper.Views.ShellPage obj = sender as global::PersonalShopper.Views.ShellPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Selected(obj.Selected, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Selected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Selected(obj.Selected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::PersonalShopper.Views.ShellPage obj)
                {
                    ShellPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void DependencyPropertyChanged_Selected_Content(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ShellPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.NavigationViewItem obj = sender as global::Windows.UI.Xaml.Controls.NavigationViewItem;
                        if (obj != null)
                        {
                            bindings.Update_Selected_Content(obj.Content, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.NavigationViewItem cache_Selected = null;
                private long tokenDPC_Selected_Content = 0;
                public void UpdateChildListeners_Selected(global::Windows.UI.Xaml.Controls.NavigationViewItem obj)
                {
                    if (obj != cache_Selected)
                    {
                        if (cache_Selected != null)
                        {
                            cache_Selected.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, tokenDPC_Selected_Content);
                            cache_Selected = null;
                        }
                        if (obj != null)
                        {
                            cache_Selected = obj;
                            tokenDPC_Selected_Content = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty, DependencyPropertyChanged_Selected_Content);
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
            case 2: // Views\ShellPage.xaml line 11
                {
                    this.navigationView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.navigationView).ItemInvoked += this.OnItemInvoked;
                }
                break;
            case 4: // Views\ShellPage.xaml line 39
                {
                    this.shellFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
            case 1: // Views\ShellPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ShellPage_obj1_Bindings bindings = new ShellPage_obj1_Bindings();
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

