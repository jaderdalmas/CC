using System.Threading.Tasks;
using CC.Models;

namespace CC.Repositories
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        public async Task<ContaCorrenteModel> Get(int id)
        {
            return await Task.FromResult(new ContaCorrenteModel(id, 0));
        }

        public async Task<bool> Put(ContaCorrenteModel entity)
        {
            return await Task.FromResult(true);
        }
    }
}