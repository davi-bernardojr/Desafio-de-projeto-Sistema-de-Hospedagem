namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO*
                throw new Exception("A quantidade de hospedes excede a capacidade da suite. \nNão foi possivel reservar.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            int quantidadeHospedes = Hospedes.Count;

            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {    
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTADO*
            if (DiasReservados >= 10 )
            {
                valor -= valor * Convert.ToDecimal(0.1);
            }

            return valor;
        }
    }
}