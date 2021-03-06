using SiteCarAsp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCarAsp.Services
{
    /// <summary>
    /// Репозиторий для машин
    /// </summary>
    public interface ICarsRepository : IDataProvider<CarInformation>
    {
        Task<IEnumerable<CarInformation>> GetUsedCarInformationAsync();
        Task<IEnumerable<CarInformation>> GetNewCarInformationAsync();
    }

    public class CarsRepository : FileDataProvider<CarInformation>, ICarsRepository
    {
        public CarsRepository(string filePath) : base(filePath)
        {
        }

        public async Task<IEnumerable<CarInformation>> GetNewCarInformationAsync() => (await GetAllAsync()).Where(x => !x.Used);

        public async Task<IEnumerable<CarInformation>> GetUsedCarInformationAsync() => (await GetAllAsync()).Where(x => x.Used);
    }
}
