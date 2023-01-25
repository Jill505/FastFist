using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHold : MonoBehaviour
{
    public botBaseCentrol botCentrol;//人機模式調用

    public string myName;//玩家名稱

    public string characterName;//角色名稱

    public int roundRemain;//回合剩餘
    public int playerNum;//玩家序列(P1/P2)

    public int characterSort;//選擇腳色序列

    [Range(0f, 100f)] public float HPS;//血量
    [Range(0f, 100f)] public float STR;//攻擊力
    public float RAC;//反應力
    [Range(30f, 360f)] public float CUR;//精準度
    [Range(0f, 1f)] public float ABlock;//精準格檔比例

    public float chargeMaxment;//最大充能
    public float chargeEnergy;//擁有中能量

    public float degreeMake;//返回的角度

    public virtual void PassiveAbilities()
    {
        if (characterSort == 0)
        {
            characterPAI_0_Defult();
        }
    }

    public virtual void Ult()
    {
        if (characterSort == 0)
        {
            characterULT_0_Defult();
        }
    }

    void characterPAI_0_Defult()//角色0被動 - 腎上腺素/若距離斬殺線低於10架式 則半永久的提升自己的STR20點以及RAC5點
    {
        if (playerNum == 0)
        {
            if (botCentrol.frame <= -50f)
            {
                STR += 20f;
                RAC += 5f;
            }
        }
        else if (playerNum == 1)
        {

        }
    }

    void characterULT_0_Defult()//角色0招式 - 爆肝之力/立即提升 STR以及CUR 各30 持續2回合
    {

    }
}
