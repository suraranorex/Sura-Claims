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
    ///The InformacionSiniestro_Motor_UBER recording.
    /// </summary>
    [TestModule("76e499ed-cea5-4526-b393-21729e875303", ModuleType.Recording, 1)]
    public partial class InformacionSiniestro_Motor_UBER : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static InformacionSiniestro_Motor_UBER instance = new InformacionSiniestro_Motor_UBER();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionSiniestro_Motor_UBER()
        {
            DetalleSiniestro = "Ingreso el detalle del siniestro ocurrido";
            CausaSiniestro = "Otros";
            TipoCalle = "Calle";
            Provincia = "BUENOS AIRES";
            Localidad = "LOMAS DE ZAMORA";
            Calle = "Loria";
            Numero = "1828";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionSiniestro_Motor_UBER Instance
        {
            get { return instance; }
        }

#region Variables

        string _DetalleSiniestro;

        /// <summary>
        /// Gets or sets the value of variable DetalleSiniestro.
        /// </summary>
        [TestVariable("ef345ccb-6370-4dd9-ad4b-1d1923343a96")]
        public string DetalleSiniestro
        {
            get { return _DetalleSiniestro; }
            set { _DetalleSiniestro = value; }
        }

        string _CausaSiniestro;

        /// <summary>
        /// Gets or sets the value of variable CausaSiniestro.
        /// </summary>
        [TestVariable("b8b4052f-198f-44e8-b5dd-080b3f55b143")]
        public string CausaSiniestro
        {
            get { return _CausaSiniestro; }
            set { _CausaSiniestro = value; }
        }

        string _TipoCalle;

        /// <summary>
        /// Gets or sets the value of variable TipoCalle.
        /// </summary>
        [TestVariable("41db4cd5-75be-4ee3-91b9-f1322a25268e")]
        public string TipoCalle
        {
            get { return _TipoCalle; }
            set { _TipoCalle = value; }
        }

        string _Provincia;

        /// <summary>
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("a12d6b3c-d203-4c0a-ba06-e3dc4774aabd")]
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
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("b6b55d85-d09a-451c-9122-8c562a4c4b38")]
        public string Localidad
        {
            get { return repo.Localidad; }
            set { repo.Localidad = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("40ca93dc-8cc0-44cc-a800-80f97259c384")]
        public string Calle
        {
            get { return repo.Calle; }
            set { repo.Calle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Numero.
        /// </summary>
        [TestVariable("6228e2aa-47c2-49c4-b634-cfe2a61567d9")]
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DetalleSiniestro' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestroInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_DetalleSiniestro.PressKeys(DetalleSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(2));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_DetalleSiniestroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CausaSiniestro' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestroInfo, new RecordItemIndex(5));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CausaSiniestro.PressKeys(CausaSiniestro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(6));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestro'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestroInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CausaSiniestroInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_SubrogacionInfo, new RecordItemIndex(8));
            //Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'NO' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_SubrogacionInfo, new RecordItemIndex(9));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Subrogacion.PressKeys("NO");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(10));
            //repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Subrogacion'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_SubrogacionInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            //repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_SubrogacionInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalleInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoCalle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalleInfo, new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_TipoCalle.PressKeys(TipoCalle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(14));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalleInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_TipoCalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(16));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_ProvinciaInfo, new RecordItemIndex(17));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Provincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(18));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Provincia'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(19));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_ProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(20));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_LocalidadInfo, new RecordItemIndex(21));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(22));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Localidad'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(23));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_LocalidadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Calle'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_CalleInfo, new RecordItemIndex(24));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(25));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Calle'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo, new ActionTimeout(30000), new RecordItemIndex(26));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_CalleInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Numero' with focus on 'SuraClaims.Motor.InformacionSiniestro.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionSiniestro.txtbox_NumeroInfo, new RecordItemIndex(27));
            repo.SuraClaims.Motor.InformacionSiniestro.txtbox_Numero.PressKeys(Numero);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso3' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new RecordItemIndex(28));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(29));
            repo.SuraClaims.Motor.InformacionSiniestro.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion' at 35;9.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccionInfo, new RecordItemIndex(30));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_ValidarDireccion.Click("35;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(31));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.option_VerificaLaDireccion' at 19;5.", repo.SuraClaims.Motor.option_VerificaLaDireccionInfo, new RecordItemIndex(32));
            repo.SuraClaims.Motor.option_VerificaLaDireccion.Click("19;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Verificada'", repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo, new ActionTimeout(40000), new RecordItemIndex(33));
            repo.SuraClaims.Txt_Validaciones.txt_VerificadaInfo.WaitForExists(40000);
            
            // Datos UBER
            Report.Log(ReportLevel.Info, "Section", "Datos UBER", new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.AP_Uber.txtSAFE_MotorUber' at Center.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(35));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SuraClaims.AP_Uber.txtSAFE_MotorUber'.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(36));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1627373' with focus on 'SuraClaims.AP_Uber.txtSAFE_MotorUber'.", repo.SuraClaims.AP_Uber.txtSAFE_MotorUberInfo, new RecordItemIndex(37));
            repo.SuraClaims.AP_Uber.txtSAFE_MotorUber.PressKeys("1627373");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(38));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(39));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtNivel' at 7;13.", repo.SuraClaims.Motor.InformacionSiniestro.txtNivelInfo, new RecordItemIndex(40));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtNivel.Click("7;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_Nombre' at 17;13.", repo.SuraClaims.Motor.InformacionBasica.option_NombreInfo, new RecordItemIndex(41));
            //repo.SuraClaims.Motor.InformacionBasica.option_Nombre.Click("17;13");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.txtEstado' at 6;10.", repo.SuraClaims.Motor.InformacionSiniestro.txtEstadoInfo, new RecordItemIndex(42));
            //repo.SuraClaims.Motor.InformacionSiniestro.txtEstado.Click("6;10");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_Nombre' at 34;9.", repo.SuraClaims.Motor.InformacionBasica.option_NombreInfo, new RecordItemIndex(43));
            //repo.SuraClaims.Motor.InformacionBasica.option_Nombre.Click("34;9");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.DatosUber1' at 34;8.", repo.SuraClaims.Motor.InformacionSiniestro.DatosUber1Info, new RecordItemIndex(44));
            repo.SuraClaims.Motor.InformacionSiniestro.DatosUber1.Click("34;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
