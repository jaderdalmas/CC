namespace CC.Models
{
    public class ContaCorrenteModel
    {
        public ContaCorrenteModel() { }
        public ContaCorrenteModel(int id, decimal valor) { 
            this.Id = id;
            this.Valor = valor;
        }

        public int Id { get; private set; }
        public decimal Valor { get; private set; }

        public decimal Lancamento(decimal valor)
        {
            return Valor += valor;
        }
    }
}
