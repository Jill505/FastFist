using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class discardUI : MonoBehaviour
{
    public GameObject nameUI;
    // Start is called before the first frame update
    void Start()
    {
        localDataBase.dataJsonDepack();
        nameUI.GetComponent < Text >().text = "ª±®a¦WºÙ¡G"+localDataBase.PlayerData.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
