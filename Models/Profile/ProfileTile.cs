namespace dotnetprojects.Models.Profile;

using dotnetprojects.Enums.Profile;
using System;

public class ProfileTile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public ProfileTileType Type { get; set; }
    public string Content { get; set; } // URL for image/video, actual text for text tile

    public ProfileTile()
    {
        Random random = new Random();
        char randomChar = (char)random.Next('a', 'z' + 1); // Generate a random lowercase letter
        Content = randomChar.ToString();
    }
}