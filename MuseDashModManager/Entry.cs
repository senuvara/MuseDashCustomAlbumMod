using ModHelper;
namespace MuseDashCustomAlbumMod
{
    class Entry : IMod
    {
        public string Name => "CustomAlbum";

        public string Description => "Muse Dash Custom Album";

        public string Author => "Lyt99";

        public string HomePage => "https://github.com/mo10/MuseDashCustomAlbumMod";

        public void DoPatching()
        {
            CustomAlbum.DoPatching();
        }
    }
}
