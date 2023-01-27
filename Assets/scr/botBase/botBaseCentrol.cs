using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botBaseCentrol : MonoBehaviour
{
    static int characterBotIsUsing;

    GameObject Player;
    GameObject PlayerBot;

    playerHold player1;
    playerHold player2;

    AudioSource audioSource;

    public float frame = 0f;

    public bool turnToPlayer1;

    public float diraction;

    /*
    public enum EnumPlayerData
    {
        turnToplayer1Enum,
        turnToplayer2Enum,
    }

    EnumPlayerData enumPlayerData = new EnumPlayerData(); */

    void Awake()//載入配置並判斷自己是不是host 
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        Player = GameObject.Find("MyCharacter");
        PlayerBot = GameObject.Find("BotCharacter");

        if (GameObject.Find("Deliver(Clone)") == null)
        {
            Debug.Log("nonono"); 
        }
        else
        {
            //傳入本地及將上傳至伺服器的資料
            GameObject Deliver = GameObject.Find("Deliver(Clone)");

            //紀錄玩家應該被同步的組件位置
            player1 = Player.GetComponent<playerHold>();
            player2 = PlayerBot.GetComponent<playerHold>();

            //賦予角色數據
            gameObject.GetComponent<sortingHatCharacter>().sorting(Deliver.GetComponent<playerDataSenter>().characterSort, player1);
            gameObject.GetComponent<sortingHatCharacter>().sorting(characterBotIsUsing, player2);

            //告訴組件核心是botCentorl
            player1.botCentrol = this;
            player2.botCentrol = this;

            //分配玩家P1或P2
            player1.playerNum = 0;
            player2.playerNum = 1;
        }
    }
    void Start()
    {
        player1.roundRemain += 1;
        player2.roundRemain += 10000;//測試用
        StartCoroutine(botStartGame());
    }

    void Update()
    {
           
    }

    public void roundSwitch()
    {
        if (turnToPlayer1 == true)
        {
            //等待Player傳送dir
            if (!IsInvoking("TimeOut"))
            {
                Invoke("TimeOut", player1.attackTime);
            }
                //bot做回應
            }
            else
        {
            //等待bot傳送dir
            if (!IsInvoking("TimeOut"))
            {
                Invoke("TimeOut", player2.attackTime);
            }
            //玩家做回應
        }
    }

    IEnumerator botStartGame()
    {
        yield return new WaitForSecondsRealtime(1.2f);
        audioSource.clip = Resources.Load<AudioClip>("soundEffect/startSoundEffect/"+ "Zima_raow");//之後記得改成本地資料中的startSoundEffect
        audioSource.Play();
        Debug.Log("成功播放");
        yield return new WaitForSecondsRealtime(0.3f);
        Debug.Log("開始");
        yield return null;

        roundCirtical();
    }

    /*public void roundSwitch()
    {
        switch (enumPlayerData)
        {
            case EnumPlayerData.turnToplayer1Enum:
            {

                break;
            }
            case EnumPlayerData.turnToplayer2Enum:
            {

                break;
            }
        }
    }*/

    public void roundCirtical()//回合判定
    {
        if (player1.roundRemain > player2.roundRemain)
        {
            turnToPlayer1 = true;
        }
        else
        {
            turnToPlayer1 = false;
        }
    }

    void TimeOut()
    {
        if (turnToPlayer1 == true)
        {
            player1.roundRemain -= 1;
        }
        else
        {
            player2.roundRemain -= 1;
        }
    }

    public void DeliveringDiraction(float diractionDelivering)
    {
        diraction = diractionDelivering;
        CancelInvoke("TimeOut");
        //進入到回合環節
    }
}
