using slachBas_entity_test.Entities.services;

namespace slachBas_entity_test.Services.avatar;

using slachBas_entity_test.Entities;


public interface IAvatarService : IBaseDocumentService<Avatar>
{
    Task<Avatar> CreateAvatarAsync(Avatar avatar);
}