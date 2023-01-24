using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterBase : MonoBehaviour
{
    public int characterSort;//0 = 普通人 1 = 蝦兵
    public float chargeMaxment;
    public float chargeEnergy;

    [Range(0f,100f)]public float HPS;//血量
    [Range(0f, 100f)] public float STR;//攻擊力
    public float RAC;//反應力
    [Range(30f, 360f)] public float CUR;//精準度
    [Range(0f, 1f)] public float ABlock;//精準格檔比例
    
    public virtual void PassiveAbilities()
    {
        
    }

    public virtual void Ult()
    {

    }

    void characterPAI_0_Defult()//角色0被動
    {

    }

    void characterULT_0_Defult()//角色招式
    {

    }
}
