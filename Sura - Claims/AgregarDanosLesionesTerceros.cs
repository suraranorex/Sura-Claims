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
    ///The AgregarDanosLesionesTerceros recording.
    /// </summary>
    [TestModule("c46639e2-c589-4fe1-9cd6-5d3cb864425f", ModuleType.Recording, 1)]
    public partial class AgregarDanosLesionesTerceros : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static AgregarDanosLesionesTerceros instance = new AgregarDanosLesionesTerceros();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgregarDanosLesionesTerceros()
        {
            Ambiente = "ssurgwsoadev3.opc.oracleoutsourcing.com";
            ANIO = "2019";
            Marca = "CHEVROLET";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgregarDanosLesionesTerceros Instance
        {
            get { return instance; }
        }

#region Variables

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("65a1ac9a-bbff-46f0-926a-f4e7c892021b")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
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
        /// Gets or sets the value of variable ANIO.
        /// </summary>
        [TestVariable("99a62fc1-d74d-462a-8d7a-b102fd10fec5")]
        public string ANIO
        {
            get { return repo.ANIO; }
            set { repo.ANIO = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_agregarDanoYLesionesTerceros' at 130;3.", repo.SuraClaims.Motor.btn_agregarDanoYLesionesTercerosInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.btn_agregarDanoYLesionesTerceros.Click("130;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_AgregarConductor' at 36;1.", repo.SuraClaims.Motor.btn_AgregarConductorInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.btn_AgregarConductor.Click("36;1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_AGregar' at 23;7.", repo.SuraClaims.Motor.btn_AGregarInfo, new RecordItemIndex(2));
            repo.SuraClaims.Motor.btn_AGregar.Click("23;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_TipoDoc' at 74;12.", repo.SuraClaims.Motor.txt_TipoDocInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.txt_TipoDoc.Click("74;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.txt_TipoDoc'.", repo.SuraClaims.Motor.txt_TipoDocInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.txt_TipoDoc.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D.N.I.' with focus on 'SuraClaims.Motor.txt_TipoDoc'.", repo.SuraClaims.Motor.txt_TipoDocInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.txt_TipoDoc.PressKeys("D.N.I.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.XListPlain.TipoDocumento' at 29;9.", repo.GuidewireClaimCenter.XListPlain.TipoDocumentoInfo, new RecordItemIndex(8));
            //repo.GuidewireClaimCenter.XListPlain.TipoDocumento.Click("29;9");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txt_Numero' at 52;12.", repo.SuraClaims.Motor.txt_NumeroInfo, new RecordItemIndex(9));
            repo.SuraClaims.Motor.txt_Numero.Click("52;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '25667887' with focus on 'SuraClaims.Motor.txt_Numero'.", repo.SuraClaims.Motor.txt_NumeroInfo, new RecordItemIndex(10));
            repo.SuraClaims.Motor.txt_Numero.EnsureVisible();
            Keyboard.Press("25667887");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txtNombre' at 46;13.", repo.SuraClaims.Motor.txtNombreInfo, new RecordItemIndex(12));
            repo.SuraClaims.Motor.txtNombre.Click("46;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'PRUEBA' with focus on 'SuraClaims.Motor.txtNombre'.", repo.SuraClaims.Motor.txtNombreInfo, new RecordItemIndex(13));
            repo.SuraClaims.Motor.txtNombre.PressKeys("PRUEBA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txtApellido' at 35;9.", repo.SuraClaims.Motor.txtApellidoInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.txtApellido.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'DOS' with focus on 'SuraClaims.Motor.txtApellido'.", repo.SuraClaims.Motor.txtApellidoInfo, new RecordItemIndex(15));
            repo.SuraClaims.Motor.txtApellido.PressKeys("DOS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(16));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at 27;11.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(17));
            repo.SuraClaims.Motor.btn_Aceptar.Click("27;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulancia' at 8;7.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulanciaInfo, new RecordItemIndex(18));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulancia.Click("8;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Danios_No' at 6;8.", repo.SuraClaims.Motor.btn_Danios_NoInfo, new RecordItemIndex(19));
            repo.SuraClaims.Motor.btn_Danios_No.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_responsabilidad' at 6;6.", repo.SuraClaims.Motor.op_responsabilidadInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.op_responsabilidad.Click("6;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo' at 7;4.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculoInfo, new RecordItemIndex(21));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo.Click("7;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo'.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculoInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ANIO' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo'.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculoInfo, new RecordItemIndex(23));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnioVehiculo.EnsureVisible();
            Keyboard.Press(ANIO);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtAnioVehiculo'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtAnioVehiculoInfo, new ActionTimeout(30000), new RecordItemIndex(24));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtAnioVehiculoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(25));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca' at 34;9.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(26));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.Click("34;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(27));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(28));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.PressKeys(Marca);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtmarca'", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtmarcaInfo, new ActionTimeout(30000), new RecordItemIndex(29));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtmarcaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(30));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo' at 36;12.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(31));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.Click("36;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(32));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ONIX' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(33));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.PressKeys("ONIX");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtModelo'", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtModeloInfo, new ActionTimeout(30000), new RecordItemIndex(34));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.Copy_of_txtModeloInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(35));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo' at 88;7.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipoInfo, new RecordItemIndex(36));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo.Click("88;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipoInfo, new RecordItemIndex(37));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AUTO' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipoInfo, new RecordItemIndex(38));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtTipo.PressKeys("AUTO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatente' at 29;8.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatenteInfo, new RecordItemIndex(39));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatente.Click("29;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'jio098' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatente'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatenteInfo, new RecordItemIndex(40));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci11.textPatente.PressKeys("jio098");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(41));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtPropietarioVehiculo' at 75;15.", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtPropietarioVehiculoInfo, new RecordItemIndex(42));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtPropietarioVehiculo.Click("75;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor' at 72;12.", repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisorInfo, new RecordItemIndex(43));
            repo.SuraClaims.InformacionPagoSiniestro.OptionSelecBancoEmisor.Click("72;12");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at Center.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(44));
            //repo.SuraClaims.Motor.btn_Aceptar.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.pestana_DescripTipoSiniestro' at 119;6.", repo.SuraClaims.Motor.pestana_DescripTipoSiniestroInfo, new RecordItemIndex(45));
            repo.SuraClaims.Motor.pestana_DescripTipoSiniestro.Click("119;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.lbl_Danos'", repo.SuraClaims.Motor.InformacionSiniestro.lbl_DanosInfo, new ActionTimeout(5000), new RecordItemIndex(46));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_DanosInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
