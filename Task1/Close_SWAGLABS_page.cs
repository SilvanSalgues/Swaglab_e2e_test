/*
 * Created by Ranorex
 * User: silvan.salgues
 * Date: 11/8/2021
 * Time: 10:38 AM
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
using Ranorex.Core.Testing;

namespace Task1
{
    /// <summary>
    /// Description of Close_SWAGLABS_page.
    /// </summary>
    [TestModule("6DF085D4-A2D5-4DCB-8037-AEEEDEEA93A8", ModuleType.UserCode, 1)]
    public class Close_SWAGLABS_page : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_SWAGLABS_page()
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
        	
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'SwagLabsMozillaFirefox'.", repo.SwagLabsMozillaFirefox.SelfInfo);
            Host.Current.CloseApplication(repo.SwagLabsMozillaFirefox.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to not exist. Associated repository item: 'SwagLabsMozillaFirefox'", repo.SwagLabsMozillaFirefox.SelfInfo, new ActionTimeout(5000));
            repo.SwagLabsMozillaFirefox.SelfInfo.WaitForNotExists(5000);
        }
    }
}
