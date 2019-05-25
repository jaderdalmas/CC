using System.Threading.Tasks;
using CC.Models;

namespace CC.Services
{
    public interface IContaCorrenteService
    {
        Task<bool> Lanca(LancamentoModel lancamento);
    }
}