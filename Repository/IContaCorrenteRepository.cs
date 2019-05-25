using System.Threading.Tasks;
using CC.Models;

namespace CC.Repositories
{
    public interface IContaCorrenteRepository
    {
        Task<ContaCorrenteModel> Get(int id);

        Task<bool> Put(ContaCorrenteModel entity);
    }
}