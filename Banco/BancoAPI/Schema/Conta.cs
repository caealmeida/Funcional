namespace BancoAPI.Schema
{
    public class Conta
    {
        public int Id { get; set; }
        public double Saldo { get; set; }

        public Conta(int id, double saldo)
        {
            Id = id;
            Saldo = saldo;
        }
    }
}
