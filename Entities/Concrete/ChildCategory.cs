using Core.Entities;

namespace Entities.Concrete
{
    public class ChildCategory : IEntity
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}