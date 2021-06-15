using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.NutritionProductRepository
{
    public class NutritionProductRepository : GenericRepository<NutritionProduct>, INutritionProductRepository
    {
        public NutritionProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
