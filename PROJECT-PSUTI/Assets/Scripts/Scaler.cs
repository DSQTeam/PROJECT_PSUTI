using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var wHeight = Camera.main.orthographicSize * 2;
        var wWidth = wHeight * (Screen.width / Screen.height);
        transform.localScale = new Vector3(wWidth, wHeight, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
