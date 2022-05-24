using SiteCarAsp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiteCarAsp.ViewModels
{
    /// <summary>
   
    /// </summary>
    public class CarInformationViewModel
    {
        public CarInformationViewModel(IEnumerable<CarInformation> carInformation)
        {
            this.Cars = carInformation;
        }

        /// <summary>
        /// Фильтры
        /// </summary>
        //type
        //body
        public Dictionary<Filter, IEnumerable<string>> Filters
            => new Dictionary<Filter, IEnumerable<string>>
            {
                {new Filter{ Caption="Марка", Field="type" }, Cars.Select(x=>x.Type).Distinct() },
                { new Filter{ Caption="Кузов", Field="body" }, Cars.Select(x=>x.Body).Distinct() }
            };

        /// <summary>
        /// Машины
        /// </summary>
        public IEnumerable<CarInformation> Cars { get; }

        /// <summary>
        /// Активные фильтры
        /// </summary>
        public FilterViewModel[] ActiveFilters { get; set; }
    }
}
