using MyWebApi.data;

namespace MyWebApi.Models
{
    public class ImageModel
    {
        public int ArticleId { get; set; }
        public IFormFile File { get; set; }
    }


    public class ImageVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ArticleId { get; set; }
      
    }

}
