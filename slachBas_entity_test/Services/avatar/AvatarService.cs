namespace slachBas_entity_test.Services.avatar;

using MongoDB.Driver;
using slachBas_entity_test.Entities;

public class AvatarService : IAvatarService
{
    private readonly IMongoCollection<Avatar> _avatars;

    public AvatarService(SlachBasDbContext dbContext)
    {
        _avatars = dbContext.Avatars;
    }

    public async Task<Avatar> CreateAvatarAsync(Avatar avatar)
    {
        await _avatars.InsertOneAsync(avatar);
        return avatar;
    }


    public Task<Avatar> FindByIdsAsync(string id)
    {
        throw new NotImplementedException();
    }
}