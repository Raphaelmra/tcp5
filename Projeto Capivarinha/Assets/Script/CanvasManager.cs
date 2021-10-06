using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
   

    public Image fogos1, fogos2, fogos3;

    private int _num;

    // Start is called before the first frame update
    void Start()
    {
        
        _num = 2;

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ApagouFogo()
    {
        fogos1.enabled = false;
        _num--;

    }
}
