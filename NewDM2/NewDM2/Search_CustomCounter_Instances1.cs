﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace NewDM2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Search_CustomCounter_Instances1 recording.
    /// </summary>
    [TestModule("6bf120a2-fa3b-48d9-8d73-c4c48c41bfb5", ModuleType.Recording, 1)]
    public partial class Search_CustomCounter_Instances1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewDM2Repository repository.
        /// </summary>
        public static NewDM2Repository repo = NewDM2Repository.Instance;

        static Search_CustomCounter_Instances1 instance = new Search_CustomCounter_Instances1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Search_CustomCounter_Instances1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Search_CustomCounter_Instances1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.Administration' at 54;10.", repo.IDERASQLDiagnosticManagerSQLdmRepos.AdministrationInfo, new RecordItemIndex(0));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.Administration.Click("54;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.FeatureHeaderLabel' at 47;6.", repo.IDERASQLDiagnosticManagerSQLdmRepos.FeatureHeaderLabelInfo, new RecordItemIndex(1));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.FeatureHeaderLabel.Click("47;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.ButtonGroupCustomCountersToolsToo' at 16;21.", repo.IDERASQLDiagnosticManagerSQLdmRepos.ButtonGroupCustomCountersToolsTooInfo, new RecordItemIndex(2));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.ButtonGroupCustomCountersToolsToo.Click("16;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomCounterWizard.NextButton' at 40;7.", repo.CustomCounterWizard.NextButtonInfo, new RecordItemIndex(3));
            repo.CustomCounterWizard.NextButton.Click("40;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomCounterWizard.NextButton' at 40;7.", repo.CustomCounterWizard.NextButtonInfo, new RecordItemIndex(4));
            repo.CustomCounterWizard.NextButton.Click("40;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CustomCounterWizard.InstanceName' at 417;10.", repo.CustomCounterWizard.InstanceNameInfo, new RecordItemIndex(5));
            repo.CustomCounterWizard.InstanceName.DoubleClick("417;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CustomSearchDialogBox.SplitContainer1.Text' at 107;6.", repo.CustomSearchDialogBox.SplitContainer1.TextInfo, new RecordItemIndex(6));
            repo.CustomSearchDialogBox.SplitContainer1.Text.DoubleClick("107;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '17' with focus on 'CustomSearchDialogBox.SplitContainer1.Text'.", repo.CustomSearchDialogBox.SplitContainer1.TextInfo, new RecordItemIndex(7));
            repo.CustomSearchDialogBox.SplitContainer1.Text.PressKeys("17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomSearchDialogBox.SplitContainer1.CELSYSBLR000241CELSYSWTC17' at 126;3.", repo.CustomSearchDialogBox.SplitContainer1.CELSYSBLR000241CELSYSWTC17Info, new RecordItemIndex(8));
            repo.CustomSearchDialogBox.SplitContainer1.CELSYSBLR000241CELSYSWTC17.Click("126;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomSearchDialogBox.SplitContainer1.BtnOk' at 40;14.", repo.CustomSearchDialogBox.SplitContainer1.BtnOkInfo, new RecordItemIndex(9));
            repo.CustomSearchDialogBox.SplitContainer1.BtnOk.Click("40;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CustomCounterWizard.CancelButton' at 40;14.", repo.CustomCounterWizard.CancelButtonInfo, new RecordItemIndex(10));
            repo.CustomCounterWizard.CancelButton.Click("40;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}