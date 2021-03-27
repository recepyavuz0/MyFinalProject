using Core.DataAccess;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}

//Code Refactoring => Kodun iyileştirilmesi
