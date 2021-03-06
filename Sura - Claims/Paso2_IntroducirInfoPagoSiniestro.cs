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
    ///The Paso2_IntroducirInfoPagoSiniestro recording.
    /// </summary>
    [TestModule("eff42eb8-e2ed-421a-8ebf-274464b2758a", ModuleType.Recording, 1)]
    public partial class Paso2_IntroducirInfoPagoSiniestro : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Sura___ClaimsRepository repository.
        /// </summary>
        public static Sura___ClaimsRepository repo = Sura___ClaimsRepository.Instance;

        static Paso2_IntroducirInfoPagoSiniestro instance = new Paso2_IntroducirInfoPagoSiniestro();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Paso2_IntroducirInfoPagoSiniestro()
        {
            Importe = "100";
            CausaPago = "1-INDEMNIZACION";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Paso2_IntroducirInfoPagoSiniestro Instance
        {
            get { return instance; }
        }

#region Variables

        string _Importe;

        /// <summary>
        /// Gets or sets the value of variable Importe.
        /// </summary>
        [TestVariable("58b73c03-1cb1-42e6-888a-8b4733eeb397")]
        public string Importe
        {
            get { return _Importe; }
            set { _Importe = value; }
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
        /// Gets or sets the value of variable CausaPago.
        /// </summary>
        [TestVariable("7f1828b5-24cf-4275-b482-0b65e43d8d92")]
        public string CausaPago
        {
            get { return repo.CausaPago; }
            set { repo.CausaPago = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.Txt_Validaciones.txt_Paso2'", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new ActionTimeout(40000), new RecordItemIndex(0));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2Info.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.ArrowSelectLineaReserva' at CenterRight.", repo.SuraClaims.InformacionPagoSiniestro.ArrowSelectLineaReservaInfo, new RecordItemIndex(1));
            repo.SuraClaims.InformacionPagoSiniestro.ArrowSelectLineaReserva.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.LineaReserva_Asegurado' at Center.", repo.SuraClaims.InformacionPagoSiniestro.LineaReserva_AseguradoInfo, new RecordItemIndex(2));
            repo.SuraClaims.InformacionPagoSiniestro.LineaReserva_Asegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.lbl_CoberturaSiniestro'", repo.SuraClaims.InformacionPagoSiniestro.lbl_CoberturaSiniestroInfo, new ActionTimeout(40000), new RecordItemIndex(3));
            repo.SuraClaims.InformacionPagoSiniestro.lbl_CoberturaSiniestroInfo.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txtTipoPagoPaso2' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txtTipoPagoPaso2Info, new RecordItemIndex(4));
            repo.SuraClaims.InformacionPagoSiniestro.txtTipoPagoPaso2.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2' at Center.", repo.SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2Info, new RecordItemIndex(5));
            //repo.SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2.MoveTo();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2' at Center.", repo.SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2Info, new RecordItemIndex(6));
            repo.SuraClaims.InformacionPagoSiniestro.TipoPagoPaso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_TipoPagoPaso2'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_TipoPagoPaso2Info, new ActionTimeout(60000), new RecordItemIndex(7));
            repo.SuraClaims.InformacionPagoSiniestro.Copy_of_TipoPagoPaso2Info.WaitForNotExists(60000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(9));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txt_CausaDePagoPaso2' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txt_CausaDePagoPaso2Info, new RecordItemIndex(11));
            repo.SuraClaims.InformacionPagoSiniestro.txt_CausaDePagoPaso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.CausaPago_Indemnizacion' at Center.", repo.SuraClaims.InformacionPagoSiniestro.CausaPago_IndemnizacionInfo, new RecordItemIndex(12));
            repo.SuraClaims.InformacionPagoSiniestro.CausaPago_Indemnizacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_CausaPago_Indemnizacion'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_CausaPago_IndemnizacionInfo, new ActionTimeout(50000), new RecordItemIndex(13));
            repo.SuraClaims.InformacionPagoSiniestro.Copy_of_CausaPago_IndemnizacionInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(14));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SuraClaims.InformacionPagoSiniestro.Valor_ImporteAPagar' and assigning the part of its value captured by '[0-9.,]+' to variable 'Importe'.", repo.SuraClaims.InformacionPagoSiniestro.Valor_ImporteAPagarInfo, new RecordItemIndex(16));
            //Importe = repo.SuraClaims.InformacionPagoSiniestro.Valor_ImporteAPagar.Element.GetAttributeValueText("InnerText", new Regex("[0-9.,]+"));
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprReg' at Center.", repo.SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprRegInfo, new RecordItemIndex(17));
            repo.SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprReg.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Importe' with focus on 'SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprReg'.", repo.SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprRegInfo, new RecordItemIndex(18));
            repo.SuraClaims.InformacionPagoSiniestro.txt_ImporteAPagarConExprReg.PressKeys(Importe);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'SuraClaims.InformacionPagoSiniestro.Copy_of_txt_ImporteAPagarConExprReg'", repo.SuraClaims.InformacionPagoSiniestro.Copy_of_txt_ImporteAPagarConExprRegInfo, new ActionTimeout(50000), new RecordItemIndex(19));
            repo.SuraClaims.InformacionPagoSiniestro.Copy_of_txt_ImporteAPagarConExprRegInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Txt_Validaciones.txt_Paso2' at Center.", repo.SuraClaims.Txt_Validaciones.txt_Paso2Info, new RecordItemIndex(20));
            repo.SuraClaims.Txt_Validaciones.txt_Paso2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(21));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SuraClaims.Motor.InformacionSiniestro.bttn_Finalizar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_FinalizarInfo, new RecordItemIndex(22));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Finalizar.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuraClaims.Motor.InformacionSiniestro.bttn_Finalizar' at Center.", repo.SuraClaims.Motor.InformacionSiniestro.bttn_FinalizarInfo, new RecordItemIndex(23));
            repo.SuraClaims.Motor.InformacionSiniestro.bttn_Finalizar.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
