using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class ModInfo
{
    public const string Name = "OneFPS";
    public const string Author = "BlaBlaName";
    public const string Company = null;
    public const string Version = "1.0.0";
    public const string DownloadLink = "Discord: BlaBlaName#3854";
}
namespace OneFPS
{
    
    public class Main : MelonMod
    {
        public static Main Instance;
        public bool Strated = false;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (Strated)
                return;
            Instance = this;
            GameObject obj = new GameObject();
            GameObject.DontDestroyOnLoad(obj);
            obj.AddComponent<OneFPS>();
            this.LoggerInstance.Msg("OneFPS is started!");
            GameObject.Instantiate(obj);
            Strated = true;
        }
    }
}
