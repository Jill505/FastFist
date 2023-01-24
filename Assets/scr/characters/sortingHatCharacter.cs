using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sortingHatCharacter : MonoBehaviour
{
    public void sorting(int sort, playerHold characterYa)
    {
        if (sort == 0)
        {
            characterYa.characterName = "´¶³q¤H";

            characterYa.HPS = 60f;
            characterYa.STR = 30f;
            characterYa.RAC = 60f;
            characterYa.CUR = 50f;
            characterYa.ABlock = 0.5f;

            characterYa.chargeMaxment = 200f;
        }
    }
}

