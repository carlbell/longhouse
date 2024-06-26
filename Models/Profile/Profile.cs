namespace dotnetprojects.Models.Profile;

using dotnetprojects.Enums.Profile;

public class Profile {
    public string UserId { get; set; }
    public List<ProfileTile> Tiles { get; set; } = new List<ProfileTile>();

    // constructor for testing with test data in tiles
    public Profile() { 
        Tiles = new List<ProfileTile>();
        for (int i = 0; i < 10; i++) {
            Tiles.Add(new ProfileTile());
        }
    }
}