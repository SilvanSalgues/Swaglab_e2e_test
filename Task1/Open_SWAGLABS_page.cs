/*
 * Created by Ranorex
 * User: silvan.salgues
 * Date: 11/8/2021
 * Time: 10:28 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Task1
{
    /// <summary>
    /// Description of Open_SWAGLABS_page.
    /// </summary>
    [TestModule("319DE677-A09A-40B9-AD76-200F0952B7FF", ModuleType.UserCode, 1)]
    public class Open_SWAGLABS_page : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Open_SWAGLABS_page()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	Task1Repository repo = Task1Repository.Instance;
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.saucedemo.com/' with browser 'Firefox' in maximized mode.");
            Host.Current.OpenBrowser("https://www.saucedemo.com/", "Firefox", "", false, true, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SwagLabsMozillaFirefox'", repo.SwagLabsMozillaFirefox.SelfInfo, new ActionTimeout(5000));
            repo.SwagLabsMozillaFirefox.SelfInfo.WaitForExists(5000);
        }
    }
}
