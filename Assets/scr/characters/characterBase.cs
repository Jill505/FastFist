using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterBase : MonoBehaviour
{
    public int characterSort;//0 = ���q�H 1 = ���L
    public float chargeMaxment;
    public float chargeEnergy;

    [Range(0f,100f)]public float HPS;//��q
    [Range(0f, 100f)] public float STR;//�����O
    public float RAC;//�����O
    [Range(30f, 360f)] public float CUR;//��ǫ�
    [Range(0f, 1f)] public float ABlock;//��Ǯ��ɤ��
    
    public virtual void PassiveAbilities()
    {
        
    }

    public virtual void Ult()
    {

    }

    void characterPAI_0_Defult()//����0�Q��
    {

    }

    void characterULT_0_Defult()//����ۦ�
    {

    }
}
