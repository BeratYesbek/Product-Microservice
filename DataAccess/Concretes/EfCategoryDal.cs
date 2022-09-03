using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstracts;
using Entities.Modals;

namespace DataAccess.Concretes
{
    public class EfCategoryDal : EntityRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
    }
}
