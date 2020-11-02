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

namespace Sura___Claims
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NuevoSiniestroGuardadoTercero recording.
    /// </summary>
    [TestModule("0e139cf1-b396-4a51-b397-f074aa166e6b", ModuleType.Recording, 1)]
    public partial class NuevoSiniestroGuardadoTercero : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static NuevoSiniestroGuardadoTercero instance = new NuevoSiniestroGuardadoTercero();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NuevoSiniestroGuardadoTercero()
        {
            NumSiniestro = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NuevoSiniestroGuardadoTercero Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumSiniestro;

        /// <summary>
        /// Gets or sets the value of variable NumSiniestro.
        /// </summary>
        [TestVariable("2a296cd8-5066-45a6-b80b-b3ccd6648a63")]
        public string NumSiniestro
        {
            get { return _NumSiniestro; }
            set { _NumSiniestro = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("eacdab1b-b5fd-412e-9818-70d755718f78")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to exist. Associated repository item: 'SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestro'", repo.SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestroInfo, new ActionTimeout(50000), new RecordItemIndex(0));
            repo.SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestroInfo.WaitForExists(50000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestro' and assigning the part of its value captured by '[0-9]+' to variable 'NumSiniestro'.", repo.SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestroInfo, new RecordItemIndex(2));
            NumSiniestro = repo.SuraClaims.Generales.SiniestroGenerado.txt_NumeroSiniestro.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NumSiniestro, new RecordItemIndex(3));
            
            guardarNumSiniestro();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}