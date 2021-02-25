using Harmony;

namespace CustomOverlayMod
{
    public class Patches
    {
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Db_Initialize_Patch
        {
            public static void Postfix()
            {
                Debug.Log("Adding overlay options...");


                Debug.Log("...Overlay options added!");
            }
        }
    }
}
