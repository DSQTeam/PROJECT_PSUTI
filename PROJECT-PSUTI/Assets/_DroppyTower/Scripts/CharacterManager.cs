using UnityEngine;
using System.Collections;

namespace _DroppyTower
{
    public class CharacterManager : MonoBehaviour
    {
       

        private int Id;
        public static CharacterManager Instance;

        public static readonly string CURRENT_CHARACTER_KEY = "SGLIB_CURRENT_CHARACTER";

        public int CurrentCharacterIndex
        {
            get
            {
                return PlayerPrefs.GetInt(CURRENT_CHARACTER_KEY, Id);
                Debug.Log("GetId");
            }
            set
            {
                PlayerPrefs.SetInt(CURRENT_CHARACTER_KEY, value);
                PlayerPrefs.Save();
                Debug.Log("SetId");
            }
        }

        public GameObject[] characters;

        void Awake()
        {
           

                  if (Instance)
            {
                DestroyImmediate(gameObject);
           }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
        private void Update()
        {
            System.Random rnd = new System.Random();

            Id = rnd.Next(0, 6);
        }

    }
    
}