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
    ///The AgregarDatosLesionesTercerosUBER recording.
    /// </summary>
    [TestModule("a5d72a21-2057-4e05-88e0-f9274c9fdf00", ModuleType.Recording, 1)]
    public partial class AgregarDatosLesionesTercerosUBER : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static AgregarDatosLesionesTercerosUBER instance = new AgregarDatosLesionesTercerosUBER();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgregarDatosLesionesTercerosUBER()
        {
            ANIO = "2019";
            Marca = "CHEVROLET";
            Modelo = "ONIX";
            Tipo = "AUTO";
            Patente = "jio098";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgregarDatosLesionesTercerosUBER Instance
        {
            get { return instance; }
        }

#region Variables

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("703da97c-9ed2-45aa-942b-2eb3dac1acaf")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        string _Modelo;

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("cdf19d6d-5a01-4f86-846d-5a31463807fc")]
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        string _Tipo;

        /// <summary>
        /// Gets or sets the value of variable Tipo.
        /// </summary>
        [TestVariable("61c15664-002f-48a5-8477-95208df53a4c")]
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("d8bf2642-f3a5-499c-9085-9ea5444d1a0b")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
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
        [TestVariable("3ee51182-c8a9-4041-9d28-91e3dc4900af")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SuraClaims.Motor.btn_agregarDanoYLesionesTerceros' at Center.", repo.SuraClaims.Motor.btn_agregarDanoYLesionesTercerosInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.btn_agregarDanoYLesionesTerceros.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_agregarDanoYLesionesTerceros' at 130;3.", repo.SuraClaims.Motor.btn_agregarDanoYLesionesTercerosInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.btn_agregarDanoYLesionesTerceros.Click("130;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.DetalleDelVehiculoDeTerceroYRegist'", repo.SuraClaims.Motor.InformacionSiniestro.DetalleDelVehiculoDeTerceroYRegistInfo, new ActionTimeout(10000), new RecordItemIndex(2));
            repo.SuraClaims.Motor.InformacionSiniestro.DetalleDelVehiculoDeTerceroYRegistInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUber' at 36;1.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUberInfo, new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarConductorUber.Click("36;1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(4));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Agregar' at 23;7.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AgregarInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Agregar.Click("23;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(6));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_TipoDocumento_MotorUber' at 74;12.", repo.SuraClaims.Motor.InformacionSiniestro.txt_TipoDocumento_MotorUberInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_TipoDocumento_MotorUber.Click("74;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_DNI' at 29;9.", repo.SuraClaims.Motor.option_DNIInfo, new RecordItemIndex(8));
            repo.SuraClaims.Motor.option_DNI.Click("29;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.Copy_of_option_DNI'", repo.SuraClaims.Motor.Copy_of_option_DNIInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.Motor.Copy_of_option_DNIInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(11));
            //repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(12));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '25667887' with focus on 'SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber'.", repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_UberInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionSiniestro.txt_Nro_Documento_Motor_Uber.EnsureVisible();
            Keyboard.Press("25667887");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txtNombre' at 46;13.", repo.SuraClaims.Motor.txtNombreInfo, new RecordItemIndex(15));
            repo.SuraClaims.Motor.txtNombre.Click("46;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'PRUEBA' with focus on 'SuraClaims.Motor.txtNombre'.", repo.SuraClaims.Motor.txtNombreInfo, new RecordItemIndex(16));
            repo.SuraClaims.Motor.txtNombre.PressKeys("PRUEBA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.txtApellido' at 35;9.", repo.SuraClaims.Motor.txtApellidoInfo, new RecordItemIndex(17));
            repo.SuraClaims.Motor.txtApellido.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'DOS' with focus on 'SuraClaims.Motor.txtApellido'.", repo.SuraClaims.Motor.txtApellidoInfo, new RecordItemIndex(18));
            repo.SuraClaims.Motor.txtApellido.PressKeys("DOS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.DetalleDeLosLesionados' at 154;8.", repo.SuraClaims.Motor.DetalleDeLosLesionadosInfo, new RecordItemIndex(19));
            repo.SuraClaims.Motor.DetalleDeLosLesionados.Click("154;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at 27;11.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.btn_Aceptar.Click("27;11");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulancia' at 8;7.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulanciaInfo, new RecordItemIndex(21));
            //repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.op_ambulancia.Click("8;7");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Danios_No' at 6;8.", repo.SuraClaims.Motor.btn_Danios_NoInfo, new RecordItemIndex(22));
            //repo.SuraClaims.Motor.btn_Danios_No.Click("6;8");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.op_responsabilidad' at 6;6.", repo.SuraClaims.Motor.op_responsabilidadInfo, new RecordItemIndex(23));
            //repo.SuraClaims.Motor.op_responsabilidad.Click("6;6");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtAnio' at 7;4.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioInfo, new RecordItemIndex(24));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnio.Click("7;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtAnio'.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioInfo, new RecordItemIndex(25));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnio.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ANIO' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtAnio'.", repo.SuraClaims.Motor.InformacionSiniestro.txtAnioInfo, new RecordItemIndex(26));
            repo.SuraClaims.Motor.InformacionSiniestro.txtAnio.EnsureVisible();
            Keyboard.Press(ANIO);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(27));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca' at 34;9.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(28));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.Click("34;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(29));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarcaInfo, new RecordItemIndex(30));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtmarca.PressKeys(Marca);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(31));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.XListPlain.textMarca' at 48;10.", repo.GuidewireClaimCenter.XListPlain.textMarcaInfo, new RecordItemIndex(32));
            //repo.GuidewireClaimCenter.XListPlain.textMarca.Click("48;10");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo' at 36;12.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(33));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.Click("36;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(34));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo'.", repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModeloInfo, new RecordItemIndex(35));
            repo.GuidewireClaimCenter.FNOLVehicleIncidentPopupFNOLVehicleInci3.txtModelo.PressKeys(Modelo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(36));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.XListPlain.txtModelo' at 29;5.", repo.GuidewireClaimCenter.XListPlain.txtModeloInfo, new RecordItemIndex(37));
            //repo.GuidewireClaimCenter.XListPlain.txtModelo.Click("29;5");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.txtTipoVehiculo' at 88;7.", repo.SuraClaims.SiniestroTercero.txtTipoVehiculoInfo, new RecordItemIndex(38));
            repo.SuraClaims.SiniestroTercero.txtTipoVehiculo.Click("88;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.SiniestroTercero.txtTipoVehiculo'.", repo.SuraClaims.SiniestroTercero.txtTipoVehiculoInfo, new RecordItemIndex(39));
            repo.SuraClaims.SiniestroTercero.txtTipoVehiculo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tipo' with focus on 'SuraClaims.SiniestroTercero.txtTipoVehiculo'.", repo.SuraClaims.SiniestroTercero.txtTipoVehiculoInfo, new RecordItemIndex(40));
            repo.SuraClaims.SiniestroTercero.txtTipoVehiculo.PressKeys(Tipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculoInfo, new RecordItemIndex(41));
            repo.SuraClaims.Motor.InformacionSiniestro.lbl_ElementosBasicosDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.SiniestroTercero.Copy_of_txtTipoVehiculo'", repo.SuraClaims.SiniestroTercero.Copy_of_txtTipoVehiculoInfo, new ActionTimeout(30000), new RecordItemIndex(42));
            repo.SuraClaims.SiniestroTercero.Copy_of_txtTipoVehiculoInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuidewireClaimCenter.XListPlain.txtTipo' at 27;7.", repo.GuidewireClaimCenter.XListPlain.txtTipoInfo, new RecordItemIndex(43));
            //repo.GuidewireClaimCenter.XListPlain.txtTipo.Click("27;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.SiniestroTercero.textPatente' at 29;8.", repo.SuraClaims.SiniestroTercero.textPatenteInfo, new RecordItemIndex(44));
            repo.SuraClaims.SiniestroTercero.textPatente.Click("29;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.SiniestroTercero.textPatente'.", repo.SuraClaims.SiniestroTercero.textPatenteInfo, new RecordItemIndex(45));
            repo.SuraClaims.SiniestroTercero.textPatente.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SuraClaims.SiniestroTercero.textPatente'.", repo.SuraClaims.SiniestroTercero.textPatenteInfo, new RecordItemIndex(46));
            repo.SuraClaims.SiniestroTercero.textPatente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.btn_Aceptar' at Center.", repo.SuraClaims.Motor.btn_AceptarInfo, new RecordItemIndex(47));
            repo.SuraClaims.Motor.btn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(5000), new RecordItemIndex(48));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
