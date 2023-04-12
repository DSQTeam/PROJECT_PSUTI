using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AnswerCheeck : MonoBehaviour
{
    public LevelRandom levelRandom;
    public GameObject TrueAns;
    public GameObject FalseAns;


    [SerializeField] private GameObject otherGameObject;
    [SerializeField] private GameObject otherGameObject1;
    [SerializeField] private GameObject otherGameObject2;
    [SerializeField] private GameObject otherGameObject3;

    private int SlotData1;
    private int Answer1;
    private int SlotData2;
    private int Answer2;
    private int SlotData3;
    private int Answer3;
    private int SlotData4;
    private int Answer4;

    public void OnClick()
    {
        SlotData1 = otherGameObject.GetComponent<ItemSlot>().SlotData;
        Answer1 = otherGameObject.GetComponent<ItemSlot>().Answer;
        SlotData2 = otherGameObject1.GetComponent<ItemSlot>().SlotData;
        Answer2 = otherGameObject1.GetComponent<ItemSlot>().Answer;
        SlotData3 = otherGameObject2.GetComponent<ItemSlot>().SlotData;
        Answer3 = otherGameObject2.GetComponent<ItemSlot>().Answer;
        SlotData4 = otherGameObject3.GetComponent<ItemSlot>().SlotData;
        Answer4 = otherGameObject3.GetComponent<ItemSlot>().Answer;

        if (SlotData1 == Answer1 && SlotData2 == Answer2 && SlotData3 == Answer3 && SlotData4 == Answer4)
        {
            Debug.Log("Верно");
            TrueAns.SetActive(true); 

            levelRandom.Invoke("LoadRandLevel",5);
        }
        else
        {
            Debug.Log("Не Верно");
            FalseAns.SetActive(true);

            levelRandom.Invoke("LoadRandLevel", 5);
        }
       
        
    }

    
}
