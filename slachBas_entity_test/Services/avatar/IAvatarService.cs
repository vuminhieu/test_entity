namespace slachBas_entity_test.Services.avatar;

using slachBas_entity_test.Entities;


public interface IAvatarService
{
    Task<Avatar> CreateAvatarAsync(Avatar avatar);
}