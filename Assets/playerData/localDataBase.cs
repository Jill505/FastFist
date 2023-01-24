using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localDataBase : MonoBehaviour
{
    //public int isFirstTimeLoginLocal;//此玩家是否是第一次進入遊客登入 0/是 1/否
    //static public float gold;

    static public playerData PlayerData = new playerData();

    public void getSleepingFile()
    {
        if (PlayerPrefs.GetInt("isFirstTimeLoginLocal") == 0)//第一次登入本地
        {
            //建立本地檔案+初始化
            backToPast();

            //playerData Swaper;
        }
        else
        {
            //載入本地檔案
            dataJsonDepack();
        }
    }

    public void firstTime_QuestionMark()//確認帳號狀態
    {
        //if()
    }

    public void backToPast()//初始化
    {
        PlayerPrefs.SetInt("isFirstTimeLoginLocal", 1);

        PlayerPrefs.SetFloat("gold", 0f);
        PlayerPrefs.SetFloat("Float", 0f);
    }

    static public void dataJsonPack()//儲存
    {
        PlayerPrefs.SetString("PlayerDataLocal",JsonUtility.ToJson(PlayerData));
        PlayerPrefs.Save();
    }
    static public void dataJsonDepack()//解包
    {
        var Swaper = JsonUtility.FromJson<playerData>(PlayerPrefs.GetString("PlayerDataLocal"));

        PlayerData.diamond = Swaper.diamond;
        PlayerData.gold = Swaper.gold;

        PlayerData.selectionCharacter = Swaper.selectionCharacter;
        PlayerData.moodsort = Swaper.moodsort;

        PlayerData.Name = Swaper.Name;

        PlayerData.loginTimes = Swaper.loginTimes;

        PlayerData.startSoundEffect = Swaper.startSoundEffect;
        PlayerData.fireTimeSong = Swaper.fireTimeSong;
    }
}
