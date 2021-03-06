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
    ///The Paso1_MetodoDePago_Transferencia recording.
    /// </summary>
    [TestModule("6525b5eb-d8eb-4a28-b2e5-034c66820fa9", ModuleType.Recording, 1)]
    public partial class Paso1_MetodoDePago_Transferencia : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static Paso1_MetodoDePago_Transferencia instance = new Paso1_MetodoDePago_Transferencia();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Paso1_MetodoDePago_Transferencia()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Paso1_MetodoDePago_Transferencia Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("eacdab1b-b5fd-412e-9818-70d755718f78")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MetodoPagoSiniestro.
        /// </summary>
        [TestVariable("a4a9d2b9-3e38-4e7c-85a9-3ac382e0bc6c")]
        public string MetodoPagoSiniestro
        {
            get { return repo.MetodoPagoSiniestro; }
            set { repo.MetodoPagoSiniestro = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro' at Center.", repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestroInfo, new RecordItemIndex(0));
            repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro' at Center.", repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestroInfo, new RecordItemIndex(1));
            repo.SuraClaims.InformacionPagoSiniestro.OptionMetodoPagoSiniestro.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
