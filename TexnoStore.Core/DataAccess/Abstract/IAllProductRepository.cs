using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnoStore.Core.Domain.Entities;

namespace TexnoStore.Core.DataAccess.Abstract
{
    public interface IAllProductRepository
    {
        List<BaseEntity> AllProducts(string name);
    }
}
