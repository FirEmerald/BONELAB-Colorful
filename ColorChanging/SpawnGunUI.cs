﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
namespace Melon_Loader_Mod5
{
    public class SpawnGunUI
    {
        Colors Colors = new Colors();
        public void SpawnGun(Transform parent, bool isFourthChild)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);



                UnityEngine.UI.Image imageComponent = child.GetComponent<UnityEngine.UI.Image>();
                TextMeshProUGUI textComponent = child.GetComponent<TextMeshProUGUI>();
                TextMeshPro spawnGuntextComponent = child.GetComponent<TextMeshPro>(); // for some reason spawn gun uses this idk why dont care

                if (child.name == "Background")
                {
                    continue;
                }
                else if (child.name == "image_backline" && child.parent.gameObject.name == "group_selectedInfo")
                {
                    continue;
                }
                else if (isFourthChild && i == 3)
                {
                    continue;
                }

                if (imageComponent != null)
                {
                    imageComponent.color = Colors.West;
                }
                else if (textComponent != null)
                {
                    textComponent.color = Colors.West;
                }
                else if (spawnGuntextComponent != null)
                {
                    spawnGuntextComponent.color = Colors.West;
                }

                SpawnGun(child, isFourthChild: false);
            }
        }
    }

}
