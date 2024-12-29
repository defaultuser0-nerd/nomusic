using System;
using System.Runtime;
using Photon;
using MelonLoader;
using CapuchinTemplate;
using UnityEngine;

[assembly: MelonInfo(typeof(ModCodeThingieYea), ModInfo.Name, ModInfo.Description, ModInfo.Version, ModInfo.Author)]
[assembly: MelonGame("Duttbust", "Capuchin")]

namespace CapuchinTemplate
{
    public class ModCodeThingieYea : MelonMod
    {
        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            if (sceneName == "CapuchinCopy")
            {
                GameObject.Find("Global/Levels/Forest/Props/Speaker/").SetActive(false);
                GameObject.Find("Global/Levels/Forest/Props/Chill Cabin/BluetoothSpeakerParent/BluetoothSpeaker/").SetActive(false);
                GameObject.Find("Global/Levels/Capuchin_Pier/Speaker (1)/ForestMusic").SetActive(false);
            }
        }
    }
}
