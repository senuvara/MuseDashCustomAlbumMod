using Assets.Scripts.GameCore;
using Assets.Scripts.GameCore.Managers;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Datas;
using Assets.Scripts.PeroTools.Nice.Interface;
using UnityEngine;

namespace MuseDashCustomAlbumMod
{
    public class CustomMap
    {
        public string Name;
        public string Artist;
        public string Music;
        public string MusicDemo;
        public string BPM;
        public string Scene;
        public string UID;
        public AudioClip MusicClip = null;
        public AudioClip MusicDemoClip = null;
        public Sprite CoverSprite = null;
        public string[] Difficulty = new string[3];
        public StageInfo[] stages = new StageInfo[] { null, null, null };
        public string Cover
        {
            get => UID + "_cover";
        }

        public string Map
        {
            get => UID + "_map";
        }

    }
}
