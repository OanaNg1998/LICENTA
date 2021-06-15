using JUSTMOVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.NutritionProfuctService
{
    public interface INutritionProductService
    {
        public ICollection<NutritionProduct> GetNutritionProducts();
    }
}
