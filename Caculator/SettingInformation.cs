using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caculator
{
    public partial class SettingInformation
    {
        #region [ Default Values ]

        public double DescSalud { get { return 3.04; } }

        public double DescPension { get { return 2.87; } }

        public int PrimerTopLimit { get { return 409281; } }

        public int SeguTopLimit { get { return 613921; } }

        public int TercTopLimit { get { return 852667; } }

        public int CuarTopLimit { get { return 999999999; } }

        public int ImpFijoUno { get { return 30696; } }

        public int ImpFijoDos { get { return 78446; } }

        public double TasaUno { get { return 0.15; } }

        public double TasaDos { get { return 0.20; } }

        public double TasaTres { get { return 0.25; } }

        #endregion
    }
}
