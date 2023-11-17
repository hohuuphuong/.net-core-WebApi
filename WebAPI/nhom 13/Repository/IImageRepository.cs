using MyWebApi.Models;

namespace MyWebApi.Repository
{
    public interface IImageRepository
    {
        bool Add(ImageModel model);
    }
}
