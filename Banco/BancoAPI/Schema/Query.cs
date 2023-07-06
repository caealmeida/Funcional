namespace BancoAPI.Schema
{
    public class Query
    {
        Banco banco = new Banco();

        public IEnumerable<Conta>? getContas() => banco.Contas;

        public Conta? Saldo(int id) => banco.Contas.Find(c => c.Id == id);
    }
}
