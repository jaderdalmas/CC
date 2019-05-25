using System.Threading.Tasks;
using CC.Models;
using CC.Repositories;

namespace CC.Services
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private IContaCorrenteRepository contaCorrenteRepository { get; set; }

        public ContaCorrenteService(IContaCorrenteRepository contaCorrenteRepository)
        {
            this.contaCorrenteRepository = contaCorrenteRepository;
        }

        private async Task<ContaCorrenteModel> Get(int id)
        {
            return await contaCorrenteRepository.Get(id);
        }

        public async Task<bool> Lanca(LancamentoModel lancamento)
        {
            try
            {
                var origem = await Get(lancamento.ContaOrigem);
                origem.Lancamento(-lancamento.Valor);

                var destino = await Get(lancamento.ContaDestino);
                destino.Lancamento(+lancamento.Valor);

                var doOrigem = await Put(origem);
                var doDestino = await Put(destino);

                return await Task.FromResult(doOrigem && doDestino);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        private async Task<bool> Put(ContaCorrenteModel contaCorrente)
        {
            return await contaCorrenteRepository.Put(contaCorrente);
        }
    }
}