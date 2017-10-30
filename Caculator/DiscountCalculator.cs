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

        public SalarioDesc GetDiscounts(double salari)
        {
            double ArsM = (salari * (def.DescSalud / 100));

            double AfpM = (salari * (def.DescPension / 100));

            double SalarioNeto = ((salari - ArsM) - AfpM);

            double SalarioAnual = (SalarioNeto * 12);

            double ImpuestoAnual = ((SalarioAnual > 0 && SalarioAnual <= def.PrimerTopLimit) ? 0
                                  : (SalarioAnual >= def.PrimerTopLimit && SalarioAnual <= def.SeguTopLimit) ? (0 + ((SalarioAnual - def.PrimerTopLimit) * def.TasaUno))
                                  : (SalarioAnual >= def.SeguTopLimit && SalarioAnual <= def.TercTopLimit) ? (def.ImpFijoUno + ((SalarioAnual - def.SeguTopLimit) * def.TasaDos))
                                  : (def.ImpFijoDos + ((SalarioAnual - def.TercTopLimit) * def.TasaTres)));

            double ImpuestoMensual = (ImpuestoAnual / 12);

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
