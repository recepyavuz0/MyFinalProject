using Core.Entities;

namespace Entities.Concreate
{
    //Çıplak class kalmasın
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
