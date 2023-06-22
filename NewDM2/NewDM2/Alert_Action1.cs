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
    ///The Alert_Action1 recording.
    /// </summary>
    [TestModule("07108150-4ff1-42e3-b696-9bf2c6c04043", ModuleType.Recording, 1)]
    public partial class Alert_Action1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewDM2Repository repository.
        /// </summary>
        public static NewDM2Repository repo = NewDM2Repository.Instance;

        static Alert_Action1 instance = new Alert_Action1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Alert_Action1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Alert_Action1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.Alerts' at 21;4.", repo.IDERASQLDiagnosticManagerSQLdmRepos.AlertsInfo, new RecordItemIndex(0));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.Alerts.Click("21;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.AlertActionsAndResponses' at 50;9.", repo.IDERASQLDiagnosticManagerSQLdmRepos.AlertActionsAndResponsesInfo, new RecordItemIndex(1));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.AlertActionsAndResponses.Click("50;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotificationRulesDialog.AddButton' at 34;16.", repo.NotificationRulesDialog.AddButtonInfo, new RecordItemIndex(2));
            repo.NotificationRulesDialog.AddButton.Click("34;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotificationRuleDialog.Text' at 38;6.", repo.NotificationRuleDialog.TextInfo, new RecordItemIndex(3));
            repo.NotificationRuleDialog.Text.Click("38;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'demo1' with focus on 'NotificationRuleDialog.Text'.", repo.NotificationRuleDialog.TextInfo, new RecordItemIndex(4));
            repo.NotificationRuleDialog.Text.PressKeys("demo1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotificationRuleDialog.WhereTheSQLServerInstanceIsInAHr' at 8;7.", repo.NotificationRuleDialog.WhereTheSQLServerInstanceIsInAHrInfo, new RecordItemIndex(5));
            repo.NotificationRuleDialog.WhereTheSQLServerInstanceIsInAHr.Click("8;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Blank.SpecifiedList' at 33;7.", repo.Blank.SpecifiedListInfo, new RecordItemIndex(6));
            repo.Blank.SpecifiedList.Click("33;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ServerSelectionDialog.Text' at 75;6.", repo.ServerSelectionDialog.TextInfo, new RecordItemIndex(7));
            repo.ServerSelectionDialog.Text.Click("75;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '17' with focus on 'ServerSelectionDialog.Text'.", repo.ServerSelectionDialog.TextInfo, new RecordItemIndex(8));
            repo.ServerSelectionDialog.Text.PressKeys("17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ServerSelectionDialog.CELSYSBLR000241CELSYSWTC17' at 7;9.", repo.ServerSelectionDialog.CELSYSBLR000241CELSYSWTC17Info, new RecordItemIndex(9));
            repo.ServerSelectionDialog.CELSYSBLR000241CELSYSWTC17.Click("7;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ServerSelectionDialog.BtnOK' at 34;14.", repo.ServerSelectionDialog.BtnOKInfo, new RecordItemIndex(10));
            repo.ServerSelectionDialog.BtnOK.Click("34;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotificationRuleDialog.CancelButton' at 34;16.", repo.NotificationRuleDialog.CancelButtonInfo, new RecordItemIndex(11));
            repo.NotificationRuleDialog.CancelButton.Click("34;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NotificationRulesDialog.CancelButton' at 27;12.", repo.NotificationRulesDialog.CancelButtonInfo, new RecordItemIndex(12));
            repo.NotificationRulesDialog.CancelButton.Click("27;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}