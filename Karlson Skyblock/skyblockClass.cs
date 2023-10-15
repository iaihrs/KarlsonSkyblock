using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using HarmonyLib;
using System.Reflection;
using UnityEngine.SceneManagement;

namespace Karlson_Skyblock
{
    public class skyblockClass : MelonMod
    {
        int[] tutorialFloor = { 13, 23, 25, 57 };
        int[] sb0Floor = { 8 };
        int[] sb1Floor = { 43, 47, 62, 75 };
        int[] sb2Floor = { 84, 20, 0, 22, 33, 7 };
        int[] esc0Floor = { 5, 55, 24, 7 };
        int[] esc1Floor = { 46, 21, 52, 41, 23, 22 };
        int[] esc2Floor = { 8, 27, 28, 39, 23, 43, 33, 49 };
        int[] esc3Floor = { 49, 65, 34, 13 };
        int[] esc3MainFloor = { 58 };
        int[] sky0Floor = { 8, 18, 9, 17, 5, 14, 10, 12, 6, 13, 11, 7, 15 };
        int[] sky1Floor = { 32, 52, 20, 10, 30, 8, 37, 25, 35 };
        int[] sky2Floor = { 18, 37, 10, 8, 27, 5 , 38 };
        public override void OnSceneWasInitialized(int buildindex, string sceneName)
        {
            Collider[] colliders = Object.FindObjectsOfType<Collider>();
            List<GameObject> list = new List<GameObject>();
            switch (buildindex)
            {
                case 2:
                    for(int i = 0; i < tutorialFloor.Length; i++)
                    {
                        colliders[tutorialFloor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 3:
                    for(int i = 0; i < sb0Floor.Length; i++)
                    {
                        colliders[sb0Floor[i]].gameObject.SetActive(false);  
                    }
                    break;
                case 4:
                    for (int i = 0; i < sb1Floor.Length; i++)
                    {
                        colliders[sb1Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 5:
                    for (int i = 0; i < sb2Floor.Length; i++)
                    {
                        colliders[sb2Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 6:
                    for (int i = 0; i < esc0Floor.Length; i++)
                    {
                        colliders[esc0Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 7:
                    for (int i = 0; i < esc1Floor.Length; i++)
                    {
                        colliders[esc1Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 8:
                    for (int i = 0; i < esc2Floor.Length; i++)
                    {
                        colliders[esc2Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 9:
                    for (int i = 0; i < esc3Floor.Length; i++)
                    {
                        colliders[esc3Floor[i]].gameObject.SetActive(false);
                        colliders[esc3MainFloor[i]].gameObject.transform.localScale = new Vector3(5, 2, 5);
                        colliders[esc3MainFloor[i]].gameObject.transform.localPosition = new Vector3(21.7199f, -2.24f, -0.1218f);
                    }
                    break;
                case 10:
                    for (int i = 0; i < sky0Floor.Length; i++)
                    {
                        colliders[sky0Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 11:
                    for (int i = 0; i < sky1Floor.Length; i++)
                    {
                        colliders[sky1Floor[i]].gameObject.SetActive(false);
                    }
                    break;
                case 12:
                    for (int i = 0; i < sky2Floor.Length; i++)
                    {
                        colliders[sky2Floor[i]].gameObject.SetActive(false);
                    }
                    break;
            }
        }
    }
}
