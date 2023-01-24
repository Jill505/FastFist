using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localDataBase : MonoBehaviour
{
    //public int isFirstTimeLoginLocal;//�����a�O�_�O�Ĥ@���i�J�C�ȵn�J 0/�O 1/�_
    //static public float gold;

    static public playerData PlayerData = new playerData();

    public void getSleepingFile()
    {
        if (PlayerPrefs.GetInt("isFirstTimeLoginLocal") == 0)//�Ĥ@���n�J���a
        {
            //�إߥ��a�ɮ�+��l��
            backToPast();

            //playerData Swaper;
        }
        else
        {
            //���J���a�ɮ�
            dataJsonDepack();
        }
    }

    public void firstTime_QuestionMark()//�T�{�b�����A
    {
        //if()
    }

    public void backToPast()//��l��
    {
        PlayerPrefs.SetInt("isFirstTimeLoginLocal", 1);

        PlayerPrefs.SetFloat("gold", 0f);
        PlayerPrefs.SetFloat("Float", 0f);
    }

    static public void dataJsonPack()//�x�s
    {
        PlayerPrefs.SetString("PlayerDataLocal",JsonUtility.ToJson(PlayerData));
        PlayerPrefs.Save();
    }
    static public void dataJsonDepack()//�ѥ]
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
