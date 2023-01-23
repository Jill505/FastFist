using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botBaseCentrol : MonoBehaviour
{
    GameObject Player;
    GameObject PlayerBot;

    void Awake()//載入配置並判斷自己是不是host 
    {
        if (GameObject.Find("Deliver(Clone)") == null)
        {
            Debug.Log("nonono");
            
        }
        else
        {

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
