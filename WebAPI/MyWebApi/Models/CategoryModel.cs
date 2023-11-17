using MyWebApi.data;

namespace MyWebApi.Models
{
    public class CategoryModel
    {
        public string Name { get; set; }
    }

    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
