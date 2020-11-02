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
    ///The DescripTipoSiniestro_Tercero recording.
    /// </summary>
    [TestModule("c383d4cf-bbb7-4c6d-a0e4-1a7d4a3b26ce", ModuleType.Recording, 1)]
    public partial class DescripTipoSiniestro_Tercero : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static DescripTipoSiniestro_Tercero instance = new DescripTipoSiniestro_Tercero();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DescripTipoSiniestro_Tercero()
        {
            TipoAccidente = "Colisión";
            TipoColision = "Vehículo";
            DanioTercero = "Frontal";
            DescripcionDanios = "Choque Frontal";
            CantPasaj = "1";
            Dolencia = "No";
            CantAsegu = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DescripTipoSiniestro_Tercero Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescripcionDanios;

        /// <summary>
        /// Gets or sets the value of variable DescripcionDanios.
        /// </summary>
        [TestVariable("801578a9-0bf9-4265-802a-96dd43b4a642")]
        public string DescripcionDanios
        {
            get { return _DescripcionDanios; }
            set { _DescripcionDanios = value; }
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

        /// <summary>
        /// Gets or sets the value of variable TipoAccidente.
        /// </summary>
        [TestVariable("8b263119-217d-4a29-91a1-faf74ae1c34f")]
        public string TipoAccidente
        {
            get { return repo.TipoAccidente; }
            set { repo.TipoAccidente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoColision.
        /// </summary>
        [TestVariable("c9bf6f98-2823-48a8-93b8-0986440bfbe0")]
        public string TipoColision
        {
            get { return repo.TipoColision; }
            set { repo.TipoColision = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DanioTercero.
        /// </summary>
        [TestVariable("580e2ee6-618d-4474-b1ab-bca78b36d24b")]
        public string DanioTercero
        {
            get { return repo.DanioTercero; }
            set { repo.DanioTercero = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dolencia.
        /// </summary>
        [TestVariable("48589a19-5f5e-4e8f-a1e5-6093d4db6e88")]
        public string Dolencia
        {
            get { return repo.Dolencia; }
            set { repo.Dolencia = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CantPasaj.
        /// </summary>
        [TestVariable("4a6d5080-5653-4d8a-810d-c665e0f2115c")]
        public string CantPasaj
        {
            get { return repo.CantPasaj; }
            set { repo.CantPasaj = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CantAsegu.
        /// </summary>
        [TestVariable("e9c4cfa7-f6eb-4551-ae1a-e69ecefc92ae")]
        public string CantAsegu
        {
            get { return repo.CantAsegu; }
            set { repo.CantAsegu = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.pestana_DescripTipoSiniestro' at 119;6.", repo.SuraClaims.Motor.pestana_DescripTipoSiniestroInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.pestana_DescripTipoSiniestro.Click("119;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente' at 66;6.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidenteInfo, new RecordItemIndex(1));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente.DoubleClick("66;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoAccidente' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidenteInfo, new RecordItemIndex(2));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txt_TipoAccidente.PressKeys(TipoAccidente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidente' at 33;8.", repo.SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidenteInfo, new RecordItemIndex(3));
            repo.SuraClaims.SiniestroTercero.Copy_of_SelectTipoAccidente.Click("33;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_ColisionCon' at 31;12.", repo.SuraClaims.SiniestroTercero.txt_ColisionConInfo, new RecordItemIndex(5));
            repo.SuraClaims.SiniestroTercero.txt_ColisionCon.DoubleClick("31;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoColision' with focus on 'SuraClaims.SiniestroTercero.txt_ColisionCon'.", repo.SuraClaims.SiniestroTercero.txt_ColisionConInfo, new RecordItemIndex(6));
            repo.SuraClaims.SiniestroTercero.txt_ColisionCon.PressKeys(TipoColision);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectTipoColision' at 29;5.", repo.SuraClaims.SiniestroTercero.SelectTipoColisionInfo, new RecordItemIndex(7));
            repo.SuraClaims.SiniestroTercero.SelectTipoColision.Click("29;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_DanioATercero' at 56;11.", repo.SuraClaims.SiniestroTercero.txt_DanioATerceroInfo, new RecordItemIndex(8));
            repo.SuraClaims.SiniestroTercero.txt_DanioATercero.DoubleClick("56;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DanioTercero' with focus on 'SuraClaims.SiniestroTercero.txt_DanioATercero'.", repo.SuraClaims.SiniestroTercero.txt_DanioATerceroInfo, new RecordItemIndex(9));
            repo.SuraClaims.SiniestroTercero.txt_DanioATercero.PressKeys(DanioTercero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectDanioTerceroFrontal' at 34;12.", repo.SuraClaims.SiniestroTercero.SelectDanioTerceroFrontalInfo, new RecordItemIndex(10));
            repo.SuraClaims.SiniestroTercero.SelectDanioTerceroFrontal.Click("34;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_Dolencias' at 93;12.", repo.SuraClaims.SiniestroTercero.txt_DolenciasInfo, new RecordItemIndex(11));
            repo.SuraClaims.SiniestroTercero.txt_Dolencias.DoubleClick("93;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dolencia' with focus on 'SuraClaims.SiniestroTercero.txt_Dolencias'.", repo.SuraClaims.SiniestroTercero.txt_DolenciasInfo, new RecordItemIndex(12));
            repo.SuraClaims.SiniestroTercero.txt_Dolencias.PressKeys(Dolencia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectDolencia' at 26;11.", repo.SuraClaims.SiniestroTercero.SelectDolenciaInfo, new RecordItemIndex(13));
            repo.SuraClaims.SiniestroTercero.SelectDolencia.Click("26;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_CantPasaj' at 55;9.", repo.SuraClaims.SiniestroTercero.txt_CantPasajInfo, new RecordItemIndex(14));
            repo.SuraClaims.SiniestroTercero.txt_CantPasaj.DoubleClick("55;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantPasaj' with focus on 'SuraClaims.SiniestroTercero.txt_CantPasaj'.", repo.SuraClaims.SiniestroTercero.txt_CantPasajInfo, new RecordItemIndex(15));
            repo.SuraClaims.SiniestroTercero.txt_CantPasaj.PressKeys(CantPasaj);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectCantPasaj' at 16;6.", repo.SuraClaims.SiniestroTercero.SelectCantPasajInfo, new RecordItemIndex(16));
            repo.SuraClaims.SiniestroTercero.SelectCantPasaj.Click("16;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SuraClaims.SiniestroTercero.txt_CantAseg' at 46;2.", repo.SuraClaims.SiniestroTercero.txt_CantAsegInfo, new RecordItemIndex(17));
            repo.SuraClaims.SiniestroTercero.txt_CantAseg.DoubleClick("46;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantAsegu' with focus on 'SuraClaims.SiniestroTercero.txt_CantAseg'.", repo.SuraClaims.SiniestroTercero.txt_CantAsegInfo, new RecordItemIndex(18));
            repo.SuraClaims.SiniestroTercero.txt_CantAseg.PressKeys(CantAsegu);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.SelectCantAseg' at 25;12.", repo.SuraClaims.SiniestroTercero.SelectCantAsegInfo, new RecordItemIndex(19));
            repo.SuraClaims.SiniestroTercero.SelectCantAseg.Click("25;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.txt_DescripDaniosTercero' at Center.", repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTerceroInfo, new RecordItemIndex(20));
            repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTercero.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescripcionDanios' with focus on 'SuraClaims.SiniestroTercero.txt_DescripDaniosTercero'.", repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTerceroInfo, new RecordItemIndex(21));
            repo.SuraClaims.SiniestroTercero.txt_DescripDaniosTercero.PressKeys(DescripcionDanios);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at 25;5.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.btn_Aceptar.Click("25;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(23));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
