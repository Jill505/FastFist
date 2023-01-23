using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryGame : MonoBehaviour
{
    public GameObject Deliver;
    public void startGameBot()
    {
        Instantiate(Deliver,transform.position,transform.rotation);
        playerDataSenter dataSenter = GameObject.Find("Deliver(Clone)").GetComponent<playerDataSenter>();
        dataSenter.myName = localDataBase.PlayerData.Name;
        dataSenter.moodSort = localDataBase.PlayerData.moodsort;
        dataSenter.characterSort = localDataBase.PlayerData.selectionCharacter;
        DontDestroyOnLoad(GameObject.Find("Deliver(Clone)"));
        SceneManager.LoadScene("BotNormalFight");
    }
}
