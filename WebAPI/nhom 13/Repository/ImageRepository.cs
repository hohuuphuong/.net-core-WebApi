using MyWebApi.data;
using MyWebApi.Models;

namespace MyWebApi.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly MyDBContext _context;
        public ImageRepository(MyDBContext context)
        {
            _context = context;
        }
        public bool Add(ImageModel model)
        {
            try
            {
                var image = new Image
                {
                    ArticleId = model.ArticleId,
                };
                _context.Add(image);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            } 
        }
    }
}
