using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public GameObject Baldinho;
    public GameObject AguaUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "baldinho") {
            other.gameObject.SetActive(false);
            Baldinho.SetActive(true);
            AguaUI.SetActive(true);
        }

        if (other.tag == "trofeu")
        {
            other.gameObject.SetActive(false);
            
        }
    }
}
