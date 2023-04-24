using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MMButtonsScaler : MonoBehaviour
{

    [SerializeField]  GameObject otherGameObject;
    private bool IsActive;



    void Update()
    {


        IsActive = otherGameObject.GetComponent<Toggle>().isOn;

        if (IsActive == true)
        {
            
            otherGameObject.transform.localScale = Vector2.Lerp(otherGameObject.transform.localScale, new Vector2(0.17f, 0.17f), 0.75f);
        }
        else
        {
            otherGameObject.transform.localScale = Vector2.Lerp(otherGameObject.transform.localScale, new Vector2(0.12f, 0.12f), 0.75f);
        }


    }
}
