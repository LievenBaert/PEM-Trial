﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace ADF.UCM.Demo.HIC.Tests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// VerifyVersionNumber - Use 'VerifyVersionNumberExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyVersionNumber()
        {
            #region Variable Declarations
            WinEdit uITextBoxVersionEdit = this.UIFormTestWindow.UIItem1001746Window.UITextBoxVersionEdit;
            #endregion

            // Verify that 'textBoxVersion' text box's property 'Text' starts with '1.0.0.'
            StringAssert.StartsWith(uITextBoxVersionEdit.Text, this.VerifyVersionNumberExpectedValues.UITextBoxVersionEditText);
        }
        
        /// <summary>
        /// SayHelloClick
        /// </summary>
        public void SayHelloClick()
        {
            #region Variable Declarations
            WinButton uISayHelloButton = this.UIFormTestWindow.UISayHelloWindow.UISayHelloButton;
            #endregion

            // Click 'Say Hello' button
            Mouse.Click(uISayHelloButton, new Point(52, 12));
        }
        
        /// <summary>
        /// ValidateHelloMessage - Use 'ValidateHelloMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ValidateHelloMessage()
        {
            #region Variable Declarations
            WinText uIHellousersofAUTYouraText = this.UIHellousersofAUTYouraWindow.UIHellousersofAUTYouraText;
            #endregion

            // Verify that 'Hello users of AUT; Your are working with version ...' label's property 'DisplayText' contains 'AUT'
            StringAssert.Contains(uIHellousersofAUTYouraText.DisplayText, this.ValidateHelloMessageExpectedValues.UIHellousersofAUTYouraTextDisplayText);

            // Verify that 'Hello users of AUT; Your are working with version ...' label's property 'DisplayText' starts with 'Hello users of AUT;'
            StringAssert.StartsWith(uIHellousersofAUTYouraText.DisplayText, this.ValidateHelloMessageExpectedValues.UIHellousersofAUTYouraTextDisplayText1);
        }
        
        /// <summary>
        /// CloseApplication
        /// </summary>
        public void CloseApplication()
        {
            #region Variable Declarations
            WinButton uISluitenButton = this.UIApplicationsWindow.UIApplicationsTitleBar.UISluitenButton;
            WinButton uISluitenButton1 = this.UIRADManagementConsoleWindow.UIRADManagementConsoleTitleBar.UISluitenButton;
            WinButton uIOKButton = this.UIOKWindow.UIOKButton;
            WinButton uISluitenButton2 = this.UIFormTestWindow.UIFormTestTitleBar.UISluitenButton;
            #endregion

            // Click 'Sluiten' button
            Mouse.Click(uISluitenButton, new Point(11, 6));

            // Click 'Sluiten' button
            Mouse.Click(uISluitenButton1, new Point(8, 4));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(37, 16));

            // Click 'Sluiten' button
            Mouse.Click(uISluitenButton2, new Point(12, 6));
        }
        
        /// <summary>
        /// OpenIEBrowser - Use 'OpenIEBrowserParams' to pass parameters into this method.
        /// </summary>
        public void OpenIEBrowser()
        {

            // Go to web page 'http://intranet.sidmar.be/sitesidmar/nieuw/home.htm' using new browser instance
            BrowserWindow intranetsidmarbeBrowser = BrowserWindow.Launch(new System.Uri(this.OpenIEBrowserParams.Url));
        }
        
        /// <summary>
        /// StartClickOnceClient - Use 'StartClickOnceClientParams' to pass parameters into this method.
        /// </summary>
        public void StartClickOnceClient()
        {
            #region Variable Declarations
            BrowserWindow uIArcelorMittalGentintWindow = this.UIArcelorMittalGentintWindow;
            #endregion

            // Go to web page 'http://svsim00l.sidmar.be/AUTClient.CSDemo/ADF.UCM.Demo.HIC.application'
            uIArcelorMittalGentintWindow.NavigateToUrl(new System.Uri(this.StartClickOnceClientParams.UIArcelorMittalGentintWindowUrl));
        }
        
        #region Properties
      public virtual VerifyVersionNumberExpectedValues VerifyVersionNumberExpectedValues
        {
            get
            {
                if ((this.mVerifyVersionNumberExpectedValues == null))
                {
                    this.mVerifyVersionNumberExpectedValues = new VerifyVersionNumberExpectedValues();
                }
                return this.mVerifyVersionNumberExpectedValues;
            }
        }
        
        public virtual ValidateHelloMessageExpectedValues ValidateHelloMessageExpectedValues
        {
            get
            {
                if ((this.mValidateHelloMessageExpectedValues == null))
                {
                    this.mValidateHelloMessageExpectedValues = new ValidateHelloMessageExpectedValues();
                }
                return this.mValidateHelloMessageExpectedValues;
            }
        }
        
        public virtual OpenIEBrowserParams OpenIEBrowserParams
        {
            get
            {
                if ((this.mOpenIEBrowserParams == null))
                {
                    this.mOpenIEBrowserParams = new OpenIEBrowserParams();
                }
                return this.mOpenIEBrowserParams;
            }
        }
        
        public virtual StartClickOnceClientParams StartClickOnceClientParams
        {
            get
            {
                if ((this.mStartClickOnceClientParams == null))
                {
                    this.mStartClickOnceClientParams = new StartClickOnceClientParams();
                }
                return this.mStartClickOnceClientParams;
            }
        }
        
        public UIArcelorMittalGentintWindow UIArcelorMittalGentintWindow
        {
            get
            {
                if ((this.mUIArcelorMittalGentintWindow == null))
                {
                    this.mUIArcelorMittalGentintWindow = new UIArcelorMittalGentintWindow();
                }
                return this.mUIArcelorMittalGentintWindow;
            }
        }
        
        public UIFormTestWindow UIFormTestWindow
        {
            get
            {
                if ((this.mUIFormTestWindow == null))
                {
                    this.mUIFormTestWindow = new UIFormTestWindow();
                }
                return this.mUIFormTestWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow();
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIHellousersofAUTYouraWindow UIHellousersofAUTYouraWindow
        {
            get
            {
                if ((this.mUIHellousersofAUTYouraWindow == null))
                {
                    this.mUIHellousersofAUTYouraWindow = new UIHellousersofAUTYouraWindow();
                }
                return this.mUIHellousersofAUTYouraWindow;
            }
        }
        
        public UIApplicationsWindow UIApplicationsWindow
        {
            get
            {
                if ((this.mUIApplicationsWindow == null))
                {
                    this.mUIApplicationsWindow = new UIApplicationsWindow();
                }
                return this.mUIApplicationsWindow;
            }
        }
        
        public UIRADManagementConsoleWindow UIRADManagementConsoleWindow
        {
            get
            {
                if ((this.mUIRADManagementConsoleWindow == null))
                {
                    this.mUIRADManagementConsoleWindow = new UIRADManagementConsoleWindow();
                }
                return this.mUIRADManagementConsoleWindow;
            }
        }
        #endregion
        
        #region Fields
        
        private VerifyVersionNumberExpectedValues mVerifyVersionNumberExpectedValues;
        
        private ValidateHelloMessageExpectedValues mValidateHelloMessageExpectedValues;
        
        private OpenIEBrowserParams mOpenIEBrowserParams;
        
        private StartClickOnceClientParams mStartClickOnceClientParams;
        
        private UIArcelorMittalGentintWindow mUIArcelorMittalGentintWindow;
        
        private UIFormTestWindow mUIFormTestWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIItemWindow1 mUIItemWindow;
        
        private UIHellousersofAUTYouraWindow mUIHellousersofAUTYouraWindow;
        
        private UIApplicationsWindow mUIApplicationsWindow;
        
        private UIRADManagementConsoleWindow mUIRADManagementConsoleWindow;
        #endregion
    }
       
    /// <summary>
    /// Parameters to be passed into 'VerifyVersionNumber'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class VerifyVersionNumberExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'textBoxVersion' text box's property 'Text' starts with '1.0.0.'
        /// </summary>
        public string UITextBoxVersionEditText = "1.0.0.";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'ValidateHelloMessage'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class ValidateHelloMessageExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that 'Hello users of AUT; Your are working with version ...' label's property 'DisplayText' contains 'AUT'
        /// </summary>
        public string UIHellousersofAUTYouraTextDisplayText = "AUT";
        
        /// <summary>
        /// Verify that 'Hello users of AUT; Your are working with version ...' label's property 'DisplayText' starts with 'Hello users of AUT;'
        /// </summary>
        public string UIHellousersofAUTYouraTextDisplayText1 = "Hello users of AUT;";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenIEBrowser'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class OpenIEBrowserParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://intranet.sidmar.be/sitesidmar/nieuw/home.htm' using new browser instance
        /// </summary>
        public string Url = "http://intranet.sidmar.be/sitesidmar/nieuw/home.htm";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'StartClickOnceClient'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class StartClickOnceClientParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://svsim00l.sidmar.be/AUTClient.CSDemo/ADF.UCM.Demo.HIC.application'
        /// </summary>
        public string UIArcelorMittalGentintWindowUrl = "http://svsim00l.sidmar.be/AUTClient.CSDemo/ADF.UCM.Demo.HIC.application";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIArcelorMittalGentintWindow : BrowserWindow
    {
        
        public UIArcelorMittalGentintWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "ArcelorMittal Gent intranet";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("ArcelorMittal Gent intranet");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIArcelorMittalGentintTitleBar UIArcelorMittalGentintTitleBar
        {
            get
            {
                if ((this.mUIArcelorMittalGentintTitleBar == null))
                {
                    this.mUIArcelorMittalGentintTitleBar = new UIArcelorMittalGentintTitleBar(this);
                }
                return this.mUIArcelorMittalGentintTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIArcelorMittalGentintTitleBar mUIArcelorMittalGentintTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "41477";
            this.WindowTitles.Add("ArcelorMittal Gent intranet");
            #endregion
        }
        
        #region Properties
        public WinEdit UIAddressandsearchusinEdit
        {
            get
            {
                if ((this.mUIAddressandsearchusinEdit == null))
                {
                    this.mUIAddressandsearchusinEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIAddressandsearchusinEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Address and search using Google";
                    this.mUIAddressandsearchusinEdit.WindowTitles.Add("ArcelorMittal Gent intranet");
                    #endregion
                }
                return this.mUIAddressandsearchusinEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIAddressandsearchusinEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIArcelorMittalGentintTitleBar : WinTitleBar
    {
        
        public UIArcelorMittalGentintTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("ArcelorMittal Gent intranet");
            #endregion
        }
        
        #region Properties
        public WinButton UISluitenButton
        {
            get
            {
                if ((this.mUISluitenButton == null))
                {
                    this.mUISluitenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISluitenButton.SearchProperties[WinButton.PropertyNames.Name] = "Sluiten";
                    this.mUISluitenButton.WindowTitles.Add("ArcelorMittal Gent intranet");
                    #endregion
                }
                return this.mUISluitenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISluitenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIFormTestWindow : WinWindow
    {
        
        public UIFormTestWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "FormTest";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public UISayHelloWindow UISayHelloWindow
        {
            get
            {
                if ((this.mUISayHelloWindow == null))
                {
                    this.mUISayHelloWindow = new UISayHelloWindow(this);
                }
                return this.mUISayHelloWindow;
            }
        }
        
        public UIFormTestTitleBar UIFormTestTitleBar
        {
            get
            {
                if ((this.mUIFormTestTitleBar == null))
                {
                    this.mUIFormTestTitleBar = new UIFormTestTitleBar(this);
                }
                return this.mUIFormTestTitleBar;
            }
        }
        
        public UIAssemblyofADFUCMTraiWindow UIAssemblyofADFUCMTraiWindow
        {
            get
            {
                if ((this.mUIAssemblyofADFUCMTraiWindow == null))
                {
                    this.mUIAssemblyofADFUCMTraiWindow = new UIAssemblyofADFUCMTraiWindow(this);
                }
                return this.mUIAssemblyofADFUCMTraiWindow;
            }
        }
        
        public UIVersionWindow UIVersionWindow
        {
            get
            {
                if ((this.mUIVersionWindow == null))
                {
                    this.mUIVersionWindow = new UIVersionWindow(this);
                }
                return this.mUIVersionWindow;
            }
        }
        
        public UIItem1001746Window UIItem1001746Window
        {
            get
            {
                if ((this.mUIItem1001746Window == null))
                {
                    this.mUIItem1001746Window = new UIItem1001746Window(this);
                }
                return this.mUIItem1001746Window;
            }
        }
        
        public UIAssemblyWindow UIAssemblyWindow
        {
            get
            {
                if ((this.mUIAssemblyWindow == null))
                {
                    this.mUIAssemblyWindow = new UIAssemblyWindow(this);
                }
                return this.mUIAssemblyWindow;
            }
        }
        #endregion
        
        #region Fields
        private UISayHelloWindow mUISayHelloWindow;
        
        private UIFormTestTitleBar mUIFormTestTitleBar;
        
        private UIAssemblyofADFUCMTraiWindow mUIAssemblyofADFUCMTraiWindow;
        
        private UIVersionWindow mUIVersionWindow;
        
        private UIItem1001746Window mUIItem1001746Window;
        
        private UIAssemblyWindow mUIAssemblyWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UISayHelloWindow : WinWindow
    {
        
        public UISayHelloWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "ButtonSayHello";
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinButton UISayHelloButton
        {
            get
            {
                if ((this.mUISayHelloButton == null))
                {
                    this.mUISayHelloButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISayHelloButton.SearchProperties[WinButton.PropertyNames.Name] = "Say Hello";
                    this.mUISayHelloButton.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUISayHelloButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISayHelloButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIFormTestTitleBar : WinTitleBar
    {
        
        public UIFormTestTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinButton UISluitenButton
        {
            get
            {
                if ((this.mUISluitenButton == null))
                {
                    this.mUISluitenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISluitenButton.SearchProperties[WinButton.PropertyNames.Name] = "Sluiten";
                    this.mUISluitenButton.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUISluitenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISluitenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIAssemblyofADFUCMTraiWindow : WinWindow
    {
        
        public UIAssemblyofADFUCMTraiWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBoxDescription";
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBoxDescriptionEdit
        {
            get
            {
                if ((this.mUITextBoxDescriptionEdit == null))
                {
                    this.mUITextBoxDescriptionEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextBoxDescriptionEdit.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUITextBoxDescriptionEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBoxDescriptionEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIVersionWindow : WinWindow
    {
        
        public UIVersionWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "labelVersion";
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinText UIVersionText
        {
            get
            {
                if ((this.mUIVersionText == null))
                {
                    this.mUIVersionText = new WinText(this);
                    #region Search Criteria
                    this.mUIVersionText.SearchProperties[WinText.PropertyNames.Name] = "Version:";
                    this.mUIVersionText.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUIVersionText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIVersionText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIItem1001746Window : WinWindow
    {
        
        public UIItem1001746Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBoxVersion";
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBoxVersionEdit
        {
            get
            {
                if ((this.mUITextBoxVersionEdit == null))
                {
                    this.mUITextBoxVersionEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextBoxVersionEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Description:";
                    this.mUITextBoxVersionEdit.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUITextBoxVersionEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBoxVersionEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIAssemblyWindow : WinWindow
    {
        
        public UIAssemblyWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "groupBox1";
            this.WindowTitles.Add("FormTest");
            #endregion
        }
        
        #region Properties
        public WinGroup UIAssemblyGroup
        {
            get
            {
                if ((this.mUIAssemblyGroup == null))
                {
                    this.mUIAssemblyGroup = new WinGroup(this);
                    #region Search Criteria
                    this.mUIAssemblyGroup.SearchProperties[WinControl.PropertyNames.Name] = "Assembly";
                    this.mUIAssemblyGroup.WindowTitles.Add("FormTest");
                    #endregion
                }
                return this.mUIAssemblyGroup;
            }
        }
        #endregion
        
        #region Fields
        private WinGroup mUIAssemblyGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "OK";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("OK");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("OK");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Context";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32768";
            #endregion
        }
        
        #region Properties
        public UIContextMenu UIContextMenu
        {
            get
            {
                if ((this.mUIContextMenu == null))
                {
                    this.mUIContextMenu = new UIContextMenu(this);
                }
                return this.mUIContextMenu;
            }
        }
        #endregion
        
        #region Fields
        private UIContextMenu mUIContextMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIContextMenu : WinMenu
    {
        
        public UIContextMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "Context";
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIPlakkenMenuItem
        {
            get
            {
                if ((this.mUIPlakkenMenuItem == null))
                {
                    this.mUIPlakkenMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIPlakkenMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Plakken";
                    #endregion
                }
                return this.mUIPlakkenMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIPlakkenMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIHellousersofAUTYouraWindow : WinWindow
    {
        
        public UIHellousersofAUTYouraWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Hello users of AUT; Your are working with version 1.0.0 from DVLP";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Static";
            this.WindowTitles.Add("Hello users of AUT; Your are working with version 1.0.0 from DVLP");
            #endregion
        }
        
        #region Properties
        public WinText UIHellousersofAUTYouraText
        {
            get
            {
                if ((this.mUIHellousersofAUTYouraText == null))
                {
                    this.mUIHellousersofAUTYouraText = new WinText(this);
                    #region Search Criteria
                    this.mUIHellousersofAUTYouraText.SearchProperties[WinText.PropertyNames.Name] = "Hello users of AUT; Your are working with version 1.0.0 from DVLP";
                    this.mUIHellousersofAUTYouraText.WindowTitles.Add("Hello users of AUT; Your are working with version 1.0.0 from DVLP");
                    #endregion
                }
                return this.mUIHellousersofAUTYouraText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHellousersofAUTYouraText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIApplicationsWindow : WinWindow
    {
        
        public UIApplicationsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Applications";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Applications");
            #endregion
        }
        
        #region Properties
        public UIApplicationsTitleBar UIApplicationsTitleBar
        {
            get
            {
                if ((this.mUIApplicationsTitleBar == null))
                {
                    this.mUIApplicationsTitleBar = new UIApplicationsTitleBar(this);
                }
                return this.mUIApplicationsTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIApplicationsTitleBar mUIApplicationsTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIApplicationsTitleBar : WinTitleBar
    {
        
        public UIApplicationsTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Applications");
            #endregion
        }
        
        #region Properties
        public WinButton UISluitenButton
        {
            get
            {
                if ((this.mUISluitenButton == null))
                {
                    this.mUISluitenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISluitenButton.SearchProperties[WinButton.PropertyNames.Name] = "Sluiten";
                    this.mUISluitenButton.WindowTitles.Add("Applications");
                    #endregion
                }
                return this.mUISluitenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISluitenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIRADManagementConsoleWindow : WinWindow
    {
        
        public UIRADManagementConsoleWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "RAD Management Console";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("RAD Management Console");
            #endregion
        }
        
        #region Properties
        public UIRADManagementConsoleTitleBar UIRADManagementConsoleTitleBar
        {
            get
            {
                if ((this.mUIRADManagementConsoleTitleBar == null))
                {
                    this.mUIRADManagementConsoleTitleBar = new UIRADManagementConsoleTitleBar(this);
                }
                return this.mUIRADManagementConsoleTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIRADManagementConsoleTitleBar mUIRADManagementConsoleTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class UIRADManagementConsoleTitleBar : WinTitleBar
    {
        
        public UIRADManagementConsoleTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("RAD Management Console");
            #endregion
        }
        
        #region Properties
        public WinButton UISluitenButton
        {
            get
            {
                if ((this.mUISluitenButton == null))
                {
                    this.mUISluitenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISluitenButton.SearchProperties[WinButton.PropertyNames.Name] = "Sluiten";
                    this.mUISluitenButton.WindowTitles.Add("RAD Management Console");
                    #endregion
                }
                return this.mUISluitenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISluitenButton;
        #endregion
    }
}