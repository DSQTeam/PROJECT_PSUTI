using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject otherGameObject;
    public int SlotData;
    public int Answer;
    public void OnDrop(PointerEventData eventData)
    {
        

       
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            otherGameObject = GameObject.Find(eventData.pointerDrag.gameObject.name);
            SlotData = otherGameObject.GetComponent<DragNdrop>().id;
            
        }

       
    }
}
