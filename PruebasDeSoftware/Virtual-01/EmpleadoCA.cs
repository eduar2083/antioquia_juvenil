namespace Virtual_01
{
    public class EmpleadoCA
    {
        #region Constantes
        public static readonly float SALARIO_BASE_VENDEDOR = 1000;
        public static readonly float SALARIO_BASE_ENCARGADO = 1500;
        public static readonly float PAGO_HORA_EXTRA = 20;
        #endregion

        #region Propiedades
        public string TipoEmpleado { get; set; }

        public float VentasMes { get; set; }

        public float HorasExtras { get; set; }
        #endregion

        #region Métodos privados
        private float CalcularSalarioBase()
        {
            return TipoEmpleado == "vendedor" ?
                    SALARIO_BASE_VENDEDOR :
                    SALARIO_BASE_ENCARGADO;
        }

        private float CalcularPrima()
        {
            float resultado;

            if (VentasMes >= 1500)
                resultado = 200;
            else if (VentasMes >= 1000)
                resultado = 100;
            else
                resultado = 0;

            return resultado;
        }

        private float CalcularRetencion(float salarioBruto)
        {
            float factorRetencion;

            if (salarioBruto >= 1500)
                factorRetencion = 0.18f;
            else if (salarioBruto >= 1000)
                factorRetencion = 0.16f;
            else
                factorRetencion = 0;

            return factorRetencion;
        }
        #endregion

        #region Métodos públicos
        public float CalcularSalarioBruto(string TipoEmpleado, float VentasMes, float HorasExtras)
        {
            if (string.IsNullOrEmpty(TipoEmpleado) || VentasMes < 0 || HorasExtras < 0)
                throw new CAExcepcion("Datos de entrada incorrectos");

            // Seter
            this.TipoEmpleado = TipoEmpleado;
            this.VentasMes = VentasMes;
            this.HorasExtras = HorasExtras;

            float salarioBase = CalcularSalarioBase();
            float prima = CalcularPrima();
            float pagoExtra = HorasExtras * PAGO_HORA_EXTRA;
            float resultado;

            resultado = salarioBase + prima + pagoExtra;

            return resultado;
        }

        public float CalcularSalarioNeto(float salarioBruto)
        {
            float retencion = CalcularRetencion(salarioBruto);
            float resultado;

            resultado = salarioBruto * (1 - retencion);

            if (resultado < 0)
                throw new CAExcepcion("El salario neto no puede ser negativo");

            return resultado;
        }
        #endregion
    }
}
