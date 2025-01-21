using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Data.Seeder
{
    public interface IDataSeeder
    {
        Task SeedAllAsync();
    }
}
