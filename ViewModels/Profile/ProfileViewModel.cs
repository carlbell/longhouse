namespace dotnetprojects.ViewModels.Profile;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;

using Microsoft.Maui.Controls;

using dotnetprojects.Models.Profile;
using dotnetprojects.ViewModels.Profile;
using dotnetprojects.Enums.Profile;

public class ProfileViewModel : INotifyPropertyChanged
{
    // private readonly IProfileService _profileService;
    // private readonly IMediaService _mediaService;

    public ObservableCollection<ProfileTileViewModel> ProfileTiles { get; } = new ObservableCollection<ProfileTileViewModel>();

    public ICommand AddTileCommand { get; }
    public ICommand SaveProfileCommand { get; }

    // public ProfileViewModel(IProfileService profileService, IMediaService mediaService)
    public ProfileViewModel()
    {
        // _profileService = profileService;
        // _mediaService = mediaService;

        AddTileCommand = new Command<ProfileTileType>(AddProfileTile);
        SaveProfileCommand = new Command(SaveProfile);

        LoadProfile();
    }

    private async void LoadProfile()
    {
        // var profile = await _profileService.GetProfileAsync();
        var profile = new Profile();
        foreach (var tile in profile.Tiles)
        {
            ProfileTiles.Add(new ProfileTileViewModel(tile, RemoveProfileTile));
        }
    }

    private async void AddProfileTile(ProfileTileType tileType)
    {
        // string content = await _mediaService.GetContentForTileTypeAsync(tileType);
        // var newTile = new ProfileTile { Type = tileType, Content = content };
        var newTile = new ProfileTile();
        ProfileTiles.Add(new ProfileTileViewModel(newTile, RemoveProfileTile));
    }

    private void RemoveProfileTile(ProfileTileViewModel tileVM)
    {
        ProfileTiles.Remove(tileVM);
    }

    private async void SaveProfile()
    {
        // var profile = new Profile
        // {
        //     UserId = "current_user_id", // You'd get this from authentication service
        //     Tiles = Tiles.Select(tvm => tvm.Tile).ToList()
        // };
        // await _profileService.SaveProfileAsync(profile);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}