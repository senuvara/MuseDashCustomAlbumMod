using Newtonsoft.Json.Linq;

namespace MuseDashCustomAlbumMod
{
    public class CustomInfo
    {
        public static JToken UID()
        {
            return "custom";
        }

        public static JToken Title()
        {
            return "自定义谱面";
        }

        public static JToken PrefabsName()
        {
            return "AlbumCustom";
        }

        public static JToken Price()
        {
            return "Free";
        }

        public static JToken JsonName()
        {
            return "custom";
        }

        public static JToken NeedPurchase()
        {
            return "false";
        }
    }
}
