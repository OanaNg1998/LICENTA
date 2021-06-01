using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.EquipmentRepository
{
    public class EquipmentRepository: GenericRepository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}
