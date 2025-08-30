using System.Collections.Generic;
using System.Threading.Tasks;
using VideoUpload.Domain;

namespace VideoUpload.Infra
{
    public interface IVideosRepository
    {
        Task<IEnumerable<VideoDTO>> GetAllVideosAsync();
        Task<int> AddVideoAsync(VideoDTO video);
    }
}

