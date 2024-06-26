namespace dotnetprojects.ViewModels.Profile;

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using dotnetprojects.Models.Profile;
using dotnetprojects.ViewModels.Profile;


public class ProfileTileViewModel : INotifyPropertyChanged
{
    public ProfileTile ProfileTile { get; }
    public ICommand RemoveCommand { get; }

    public ProfileTileViewModel(ProfileTile profileTile, Action<ProfileTileViewModel> removeAction)
    {
        ProfileTile = profileTile;
        RemoveCommand = new Command(() => removeAction(this));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}