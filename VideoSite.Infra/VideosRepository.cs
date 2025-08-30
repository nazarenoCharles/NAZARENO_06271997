using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoUpload.Domain;

namespace VideoUpload.Infra
{
    public class VideosRepository : IVideosRepository
    {
        private readonly IDbConnection _dbCon;

        public VideosRepository(IDbConnection dbCon)
        {
            _dbCon = dbCon;
        }

        public async Task<IEnumerable<VideoDTO>> GetAllVideosAsync()
        {
            var videos = await _dbCon.QueryAsync<VideoDTO>("SELECT * FROM Videos");
            return videos;
        }

        public async Task<int> AddVideoAsync(VideoDTO video)
        {
            var sql = @"INSERT INTO Videos (Title, Description, FileName, FilePath, ThumbnailPath, UploadedAt)
                    VALUES (@Title, @Description, @FileName, @FilePath, @ThumbnailPath, @UploadedAt);
                    SELECT CAST(SCOPE_IDENTITY() as int);";
            return await _dbCon.QuerySingleAsync<int>(sql, video);
        }

    }
}
