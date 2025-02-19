using System.Windows;

using slachBas_entity_test.Entities;
using slachBas_entity_test.Entities.definition;
using slachBas_entity_test.Services.avatar;
using System;
using slachBas_entity_test.Services.avatar;
using slachBas_entity_test.Services;

namespace slachBas_entity_test;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IAvatarService _avatarService;

    
    public MainWindow()
    {
        _avatarService = new AvatarService(new SlachBasDbContext());
        InitializeComponent();
        Task.Run(CreateAvatar).Wait();
    }
    
    
    private async Task CreateAvatar()
    {
        var avatar = new Avatar
        {
            FullName = "John Doe",
            BirthDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
            Status = AvatarStatus.Active
        };

        await _avatarService.CreateAvatarAsync(avatar);
    }
}