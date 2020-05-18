# What Do I Do
This project was done in collaboration with my friend Karl, in anticipation for his new single What Do I Do. This is mostly a prototype with the intention of making an experience focused on the fusion of space and audio. Move around, collect the pieces and discover Karl's song, piece by piece.

## Notes
The code is hosted here for people to see, but many of the assets, such as the audio, are too large to store. If you'd like to play the game in full, it is hosted on my [itch.io](https://tahagabre.itch.io/what-do-i-do).

## Implementation
This game was made in Unity3D. Audio, models, shaders, and audio are not mine(see Credits). My focus was implementing low and high pass filters on the stems, or isolated musical components of the song, based off of player proximity. As you move away from a stem, the volume decreases, and vice versa. A filter is applied to a stem until the stem is collected, where the filter will be removed. Collecting all the stems will result in hearing the song in full.

## Credits
- The water shader, log, and lifesaver and is from [Roy Stan's tutorial](https://roystan.net/articles/toon-water.html)
- [Cloud model](https://www.cgtrader.com/free-3d-models/exterior/landscape/low-poly-clouds-pack-1)
- [Rock model](https://sketchfab.com/3d-models/low-poly-rocks-9823ec262054408dbe26f6ddb9c0406e)
- [Boat model](https://www.cgtrader.com/free-3d-models/watercraft/recreational/low-poly-boat)
- [Tree model](https://sketchfab.com/3d-models/low-poly-tree-7f080d12b5074ffc9d194ef8c2a0bfb9)
