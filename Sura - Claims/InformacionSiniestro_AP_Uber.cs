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
    ///The InformacionSiniestro_AP_Uber recording.
    /// </summary>
    [TestModule("0e396338-1a6a-4d9c-91b3-24473002d3d1", ModuleType.Recording, 1)]
    public partial class InformacionSiniestro_AP_Uber : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static InformacionSiniestro_AP_Uber instance = new InformacionSiniestro_AP_Uber();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionSiniestro_AP_Uber()
        {
            CausaSiniestro = "Accidente In Itinere (AT)";
            Provincia = "BUENOS AIRES";
            Localidad = "LANUS ESTE";
            Calle = "Colón";
            Numero = "1828";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionSiniestro_AP_Uber Instance
        {
            get { return instance; }
        }

#region Variables

        string _CausaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable CausaSiniestro.
        /// </summary>
        [TestVariable("35b79a5f-154c-4864-abf9-b2813f024192")]
        public string CausaSiniestro
        {
            get { return _CausaSiniestro; }
            set { _CausaSiniestro = value; }
        }

        string _Provincia;

        /// <summary>
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("65ff6a47-8d78-488b-af42-d0d684e711ac")]
        public string Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
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
        /// Gets or sets the value of variable NombreAsegurado.
        /// </summary>
        [TestVariable("7f0acaae-d72e-41cb-a75b-3fcbd55f328f")]
        public string NombreAsegurado
        {
            get { return repo.NombreAsegurado; }
            set { repo.NombreAsegurado = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("2d91f8db-bff6-48e7-961c-05ce4c02232d")]
        public string Localidad
        {
            get { return repo.Localidad; }
            set { repo.Localidad = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("b3911a08-d4ec-4a55-9678-43a7e794542e")]
        public string Calle
        {
            get { return repo.Calle; }
            set { repo.Calle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Numero.
        /// </summary>
        [TestVariable("c2597d24-d9c2-4a8c-807c-1ffbbd6371bd")]
        public string Numero
        {
            get { return repo.Numero; }
            set { repo.Numero = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail' at Center.", repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFailInfo, new RecordItemIndex(0));
                repo.SuraClaims_ContinueOnFail.bttn_CerrarContinueOnFail.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.SuraClaims.Hogar.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(3));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.Hogar.txtbox_CausaSiniestro'.", repo.SuraClaims.Hogar.txtbox_CausaSiniestroInfo, new RecordItemIndex(4));
            repo.SuraClaims.Hogar.txtbox_CausaSiniestro.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestro'", repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SuraClaims.Hogar.Copy_of_txtbox_CausaSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(8));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Provincia'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(12));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Localidad'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Calle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CalleInfo, new RecordItemIndex(14));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(15));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Calle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Numero' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_NumeroInfo, new RecordItemIndex(17));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Numero.PressKeys(Numero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso4' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso4Info, new RecordItemIndex(18));
            repo.SuraClaims.Txt_Validaciones.txt_Paso4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(19));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion' at 35;9.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccionInfo, new RecordItemIndex(20));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(21));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_VerificaLaDireccion' at 19;5.", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.option_VerificaLaDireccion.Click("19;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Verificada'", repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo, new ActionTimeout(40000), new RecordItemIndex(23));
            repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo.WaitForExists(40000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(24));
            
            // Agrego lesiones - Información Básica
            Report.Log(ReportLevel.Info, "Section", "Agrego lesiones - Información Básica", new RecordItemIndex(25));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.bttn_AgregarLesion' at Center.", repo.SuraClaims.AP_Uber.bttn_AgregarLesionInfo, new RecordItemIndex(26));
            //repo.SuraClaims.AP_Uber.bttn_AgregarLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionadaInfo, new RecordItemIndex(28));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_PersonaLesionada.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_NombreLesionado' at Center.", repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionadoInfo, new RecordItemIndex(29));
            //repo.SuraClaims.Motor.InformacionBasica.option_NombreLesionado.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(30));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentadoInfo, new RecordItemIndex(31));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_ReclamoPresentado.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21/06/2020' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporteInfo, new RecordItemIndex(32));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_FechaReporte.PressKeys("21/06/2020");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(33));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporte'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo, new ActionTimeout(30000), new RecordItemIndex(34));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_FechaReporteInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(35));
            //Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Por mostrador' with focus on 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo'.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamoInfo, new RecordItemIndex(36));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txtbox_ViaIngresoReclamo.PressKeys("Por mostrador");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesionInfo, new RecordItemIndex(37));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.txt_IncidenteLesion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamo'", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo, new ActionTimeout(30000), new RecordItemIndex(38));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.Copy_of_txtbox_ViangresoReclamoInfo.WaitForNotExists(30000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(39));
            
            // Descripción de lesiones
            //Report.Log(ReportLevel.Info, "Section", "Descripción de lesiones", new RecordItemIndex(40));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones' at Center.", repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesionesInfo, new RecordItemIndex(41));
            //repo.SuraClaims.AP_Uber.Lesiones_InfoBasica.bttn_DescripcionLesiones.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesiones'", repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo, new ActionTimeout(30000), new RecordItemIndex(42));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txt_DescripcionLesionesInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(43));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(44));
            //Keyboard.PrepareFocus(repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Peatón' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(45));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("Peatón");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima'.", repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictimaInfo, new RecordItemIndex(46));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.txtbox_CalidadVictima.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictima'", repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo, new ActionTimeout(30000), new RecordItemIndex(47));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.Copy_of_txtbox_CalidadVictimaInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_AmbulanciaInfo, new RecordItemIndex(48));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.bttn_Ambulancia.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(49));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima' at Center.", repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictimaInfo, new RecordItemIndex(50));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.img_LesionVictima.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.AP_Uber.DescripcionLesiones.fila_Lesion'", repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo, new ActionTimeout(30000), new RecordItemIndex(51));
            //repo.SuraClaims.AP_Uber.DescripcionLesiones.fila_LesionInfo.WaitForExists(30000);
            
            // Datos uber
            Report.Log(ReportLevel.Info, "Section", "Datos uber", new RecordItemIndex(52));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtSAFE' at Center.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(53));
            repo.SuraClaims.AP_Uber.txtSAFE.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.AP_Uber.txtSAFE'.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(54));
            repo.SuraClaims.AP_Uber.txtSAFE.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1627373' with focus on 'SuraClaims.AP_Uber.txtSAFE'.", repo.SuraClaims.AP_Uber.txtSAFEInfo, new RecordItemIndex(55));
            repo.SuraClaims.AP_Uber.txtSAFE.PressKeys("1627373");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(56));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtSAFE'", repo.SuraClaims.AP_Uber.Copy_of_txtSAFEInfo, new ActionTimeout(30000), new RecordItemIndex(57));
            repo.SuraClaims.AP_Uber.Copy_of_txtSAFEInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtNivel' at Center.", repo.SuraClaims.AP_Uber.txtNivelInfo, new RecordItemIndex(58));
            repo.SuraClaims.AP_Uber.txtNivel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'L1' with focus on 'SuraClaims.AP_Uber.txtNivel'.", repo.SuraClaims.AP_Uber.txtNivelInfo, new RecordItemIndex(59));
            repo.SuraClaims.AP_Uber.txtNivel.PressKeys("L1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(60));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtNivel'", repo.SuraClaims.AP_Uber.Copy_of_txtNivelInfo, new ActionTimeout(30000), new RecordItemIndex(61));
            repo.SuraClaims.AP_Uber.Copy_of_txtNivelInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtPeriodo' at Center.", repo.SuraClaims.AP_Uber.txtPeriodoInfo, new RecordItemIndex(62));
            repo.SuraClaims.AP_Uber.txtPeriodo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'P0' with focus on 'SuraClaims.AP_Uber.txtPeriodo'.", repo.SuraClaims.AP_Uber.txtPeriodoInfo, new RecordItemIndex(63));
            repo.SuraClaims.AP_Uber.txtPeriodo.PressKeys("P0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUberInfo, new RecordItemIndex(64));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.AP_Uber.Copy_of_txtPeriodo'", repo.SuraClaims.AP_Uber.Copy_of_txtPeriodoInfo, new ActionTimeout(30000), new RecordItemIndex(65));
            repo.SuraClaims.AP_Uber.Copy_of_txtPeriodoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(66));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(67));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_AceptarInfo, new RecordItemIndex(68));
            //repo.SuraClaims.Motor.InformacionSiniestro.bttn_Aceptar.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(69));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso5'", repo.SuraClaims.Txt_Validaciones.txt_Paso5Info, new ActionTimeout(30000), new RecordItemIndex(70));
            repo.SuraClaims.Txt_Validaciones.txt_Paso5Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
