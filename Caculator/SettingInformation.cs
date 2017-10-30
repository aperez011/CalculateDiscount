using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caculator
{
    public partial class SettingInformation
    {
        #region [ Default Values ]

        //Porcentaje de decuento de salud
        public double DescSalud { get { return 3.04; } }

        //Porcentaje de descuento de fondo de pensiones
        public double DescPension { get { return 2.87; } }

        //Limite de primer renglon salarial que va desde 0 a 409,281.
        public int PrimerTopLimit { get { return 409281; } }

        //Limite de segundo reglon salarial que va desde 409,281 a 613,921
        public int SeguTopLimit { get { return 613921; } }

        //Limite de tercer reglon salarial que va desde 613,921 a 852,667
        public int TercTopLimit { get { return 852667; } }

        //Limite de Cuarto y ultimo reglon salarial que va desde 852,667 a +999,999,999
        public int CuarTopLimit { get { return 999999999; } }

        //Este es el impesto fijo ue se aplica tercer reglon salarial
        public int ImpFijoUno { get { return 30696; } }

        //Este es el impesto fijo ue se aplica cuarto reglon salarial
        public int ImpFijoDos { get { return 78446; } }

        //Este es el porcentaje que se descuenta de segundo reglon salarial
        public double TasaUno { get { return 0.15; } }

        //Este es el porcentaje que se descuenta de tercer reglon salarial
        public double TasaDos { get { return 0.20; } }

        //Este es el porcentaje que se descuenta de cuarto reglon salarial
        public double TasaTres { get { return 0.25; } }

        #endregion
    }
}
