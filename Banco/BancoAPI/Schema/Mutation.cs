namespace BancoAPI.Schema
{
    public class Mutation
    {
        Banco banco = new Banco();

        public IEnumerable<Conta>? GetContas() => banco.Contas;

        public Conta? Sacar(int id, double valor)
        {
            Conta? update = banco.Contas.Find(c => c.Id == id);
            if (update == null)
                return null;

            banco.Contas.Remove(update);
            if (update.Saldo >= valor)
            {
                update.Saldo -= valor;
                banco.Contas.Add(update);

                return update;
            }
            else
                throw new Exception("Saldo insuficiente.");
        }

        public Conta? Depositar(int id, double valor)
        {
            Conta? update = banco.Contas.Find(c => c.Id == id);
            if (update == null)
                return null;

            banco.Contas.Remove(update);

            update.Saldo += valor;
            banco.Contas.Add(update);

            return update;
        }
    }
}
