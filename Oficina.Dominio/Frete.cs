namespace Oficina.Dominio
{
    public class Frete
    {
        /// <summary>
        /// Construtor da classe Frete
        /// </summary>
        /// <param name="valor">Valor do Frete</param>
        /// <param name="uf">UF de destino</param>
        public Frete(decimal valor, UF uf)
        {
            this.Valor = valor;
            this.UF = uf;
            Calcular();
        }

        public Cliente Cliente { get; set; }
        public decimal Valor { get; private set; }
        public UF UF { get; private set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; private set; }

        private void Calcular()
        {
            switch (UF)
            {
                case UF.SP:
                    Percentual = 0.2M;
                    break;
                case UF.RJ:
                    Percentual = 0.3m;
                    break;
                case UF.MG:
                    break;
                case UF.AM:
                    break;
                default:
                    Percentual = 0.7m;
                    break;
            }

            Total = (1 + Percentual) * Valor;
        }
    }
}