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
    ///The InformacionBasica_Motor recording.
    /// </summary>
    [TestModule("5ad48d85-57b0-45f7-bcd6-24e52f64b383", ModuleType.Recording, 1)]
    public partial class InformacionBasica_Motor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static InformacionBasica_Motor instance = new InformacionBasica_Motor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionBasica_Motor()
        {
            Correo = "prueba@gmail.com";
            NumTelefono = "32039201";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionBasica_Motor Instance
        {
            get { return instance; }
        }

#region Variables

        string _Correo;

        /// <summary>
        /// Gets or sets the value of variable Correo.
        /// </summary>
        [TestVariable("4fcca55f-b784-4a31-a95d-386dda513391")]
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        string _NumTelefono;

        /// <summary>
        /// Gets or sets the value of variable NumTelefono.
        /// </summary>
        [TestVariable("cf9eeda1-bd4d-4c5d-923c-1f10c607b73a")]
        public string NumTelefono
        {
            get { return _NumTelefono; }
            set { _NumTelefono = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.bttn_SelecNombre' at 9;10.", repo.SuraClaims.Motor.InformacionBasica.bttn_SelecNombreInfo, new RecordItemIndex(0));
            repo.SuraClaims.Motor.InformacionBasica.bttn_SelecNombre.Click("9;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionBasica.option_Nombre' at 64;10.", repo.SuraClaims.Motor.InformacionBasica.option_NombreInfo, new RecordItemIndex(1));
            repo.SuraClaims.Motor.InformacionBasica.option_Nombre.Click("64;10");
            Delay.Milliseconds(0);
            
            // No hace falta. Se completa automáticamente porque no estoy cargando una persona nueva sino que seleccioné al asegurado
            //Report.Log(ReportLevel.Info, "Section", "No hace falta. Se completa automáticamente porque no estoy cargando una persona nueva sino que seleccioné al asegurado", new RecordItemIndex(2));
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Asegurado' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAsegurado'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAseguradoInfo, new RecordItemIndex(3));
            //repo.SuraClaims.Motor.InformacionBasica.txtbox_RelacionConAsegurado.PressKeys("Asegurado");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(4));
            //repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAsegurado'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAseguradoInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            //repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_RelacionConAseguradoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Particular' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipalInfo, new RecordItemIndex(7));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_TelefonoPrincipal.PressKeys("Particular");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(8));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipal'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_TelefonoPrincipalInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '011' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeAreaInfo, new RecordItemIndex(11));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CodigoDeArea.PressKeys("011");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(12));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeArea'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CodigoDeAreaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(14));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumTelefono' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_Numero'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_NumeroInfo, new RecordItemIndex(15));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_Numero.PressKeys(NumTelefono);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(16));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_Numero'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_NumeroInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Correo' with focus on 'SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico'.", repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronicoInfo, new RecordItemIndex(19));
            repo.SuraClaims.Motor.InformacionBasica.txtbox_CorreoElectronico.PressKeys(Correo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(20));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronico'", repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronicoInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.SuraClaims.Motor.InformacionBasica.Copy_of_txtbox_CorreoElectronicoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SuraClaims.Self, false, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Generales.bttn_Siguiente' at Center.", repo.SuraClaims.Generales.bttn_SiguienteInfo, new RecordItemIndex(23));
            repo.SuraClaims.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso3'", repo.SuraClaims.Txt_Validaciones.txt_Paso3Info, new ActionTimeout(30000), new RecordItemIndex(24));
            repo.SuraClaims.Txt_Validaciones.txt_Paso3Info.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
