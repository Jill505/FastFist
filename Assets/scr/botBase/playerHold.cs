using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHold : MonoBehaviour
{
    public botBaseCentrol botCentrol;//�H���Ҧ��ե�

    public string myName;//���a�W��

    public string characterName;//����W��

    public int roundRemain;//�^�X�Ѿl
    public int playerNum;//���a�ǦC(P1/P2)

    public int characterSort;//��ܸ}��ǦC

    [Range(0f, 100f)] public float HPS;//��q
    [Range(0f, 100f)] public float STR;//�����O
    public float RAC;//�����O
    [Range(30f, 360f)] public float CUR;//��ǫ�
    [Range(0f, 1f)] public float ABlock;//��Ǯ��ɤ��

    public float chargeMaxment;//�̤j�R��
    public float chargeEnergy;//�֦�����q

    public float degreeMake;//��^������

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

    void characterPAI_0_Defult()//����0�Q�� - �ǤW����/�Y�Z���ٱ��u�C��10�[�� �h�b�ä[�����ɦۤv��STR20�I�H��RAC5�I
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

    void characterULT_0_Defult()//����0�ۦ� - �z�x���O/�ߧY���� STR�H��CUR �U30 ����2�^�X
    {

    }
}
