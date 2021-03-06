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
    ///The DatosProveedor recording.
    /// </summary>
    [TestModule("0c68c95a-7fde-429f-9262-49cbee29fa7d", ModuleType.Recording, 1)]
    public partial class DatosProveedor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static DatosProveedor instance = new DatosProveedor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DatosProveedor()
        {
            CodProveedor = "23766";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DatosProveedor Instance
        {
            get { return instance; }
        }

#region Variables

        string _CodProveedor;

        /// <summary>
        /// Gets or sets the value of variable CodProveedor.
        /// </summary>
        [TestVariable("6638c3eb-5f36-43b8-b7ee-2434155a8a22")]
        public string CodProveedor
        {
            get { return _CodProveedor; }
            set { _CodProveedor = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedor' at 8;6.", repo.SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedorInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionSiniestro.Arrow_BuscaProveedor.Click("8;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Buscar' at 23;10.", repo.SuraClaims.BuscarInfo, new RecordItemIndex(1));
            repo.SuraClaims.Buscar.Click("23;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SelectProvinciaNinguna' at 11;12.", repo.SuraClaims.SelectProvinciaNingunaInfo, new RecordItemIndex(2));
            repo.SuraClaims.SelectProvinciaNinguna.Click("11;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.SelectProvinciaNinguna' at 103;7.", repo.SuraClaims.Motor.InformacionBasica.SelectProvinciaNingunaInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionBasica.SelectProvinciaNinguna.Click("103;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.txt_CodigoProveedor' at 44;7.", repo.SuraClaims.txt_CodigoProveedorInfo, new RecordItemIndex(4));
            repo.SuraClaims.txt_CodigoProveedor.Click("44;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodProveedor' with focus on 'SuraClaims.txt_CodigoProveedor'.", repo.SuraClaims.txt_CodigoProveedorInfo, new RecordItemIndex(5));
            repo.SuraClaims.txt_CodigoProveedor.PressKeys(CodProveedor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Btn_BuscarProveedor' at 32;8.", repo.SuraClaims.Btn_BuscarProveedorInfo, new RecordItemIndex(6));
            repo.SuraClaims.Btn_BuscarProveedor.Click("32;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Seleccionar' at 26;6.", repo.SuraClaims.SeleccionarInfo, new RecordItemIndex(7));
            repo.SuraClaims.Seleccionar.Click("26;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAsegurado'", repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_DetalleDelVehiculoAseguradoInfo.WaitForExists(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
