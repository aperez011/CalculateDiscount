using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caculator.Entities;

namespace Caculator
{
    public partial class DiscountCalculator
    {
        #region [ Public Properties ]
        public static DiscountCalculator Current { get { return new DiscountCalculator(); } }

        internal SettingInformation def;

        public DiscountCalculator()
        {
            def = new SettingInformation();
        }

        #endregion

        #region [ Private Properties ]

        /// <summary>
        /// este metodo calcula los descuentos a ser aplicados al salario mensual de una persona ARS, AFP y IRS
        /// </summary>
        /// <param name="salari">double: salario mensual</param>
        /// <returns>SalarioDesc: esta entidad contiene las propidades con el resultado de los calculos</returns>
        public SalarioDesc GetDiscounts(double salari)
        {
            //Calculo de ARS mensual
            double ArsM = (salari * (def.DescSalud / 100));

            //calculo de AFP mensual
            double AfpM = (salari * (def.DescPension / 100));

            //Calculo de salario neto para calcula el IRS
            double SalarioNeto = ((salari - ArsM) - AfpM);

            //Salario neto anual
            double SalarioAnual = (SalarioNeto * 12);

            //Total de impuestos a descontar anualmente
            double ImpuestoAnual = ((SalarioAnual > 0 && SalarioAnual <= def.PrimerTopLimit) ? 0
                                  : (SalarioAnual >= def.PrimerTopLimit && SalarioAnual <= def.SeguTopLimit) ? (0 + ((SalarioAnual - def.PrimerTopLimit) * def.TasaUno))
                                  : (SalarioAnual >= def.SeguTopLimit && SalarioAnual <= def.TercTopLimit) ? (def.ImpFijoUno + ((SalarioAnual - def.SeguTopLimit) * def.TasaDos))
                                  : (def.ImpFijoDos + ((SalarioAnual - def.TercTopLimit) * def.TasaTres)));

            //Total de impuestos a descontar mensualmente
            double ImpuestoMensual = (ImpuestoAnual / 12);

            //Total de impuestos a descontar quincenalmente
            double ImpuestoQuincenal = (ImpuestoMensual / 2);

            return new SalarioDesc()
            {
                SalarioBruto = salari,
                ArsMensual = ArsM,
                AfpMensual = AfpM,
                SalarioMensual = SalarioNeto,
                IrsMensual = ImpuestoMensual,
                ArsQuincenal = (ArsM / 2),
                AfpQuincenal = (AfpM / 2),
                SalarioQuicenal = (salari / 2),
                IrsQuincenal = ImpuestoQuincenal
            };
        }
        #endregion
    }
}
