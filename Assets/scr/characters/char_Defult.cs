using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_Defult : characterBase
{
    void Start()
    {
        HPS = 1f;
        STR = 1f;
        RAC = 1f;
        CUR = 1f;
        ABlock = 0.5f;

        PassiveAbilities();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PassiveAbilities()
    {
        base.PassiveAbilities();
        Debug.Log("Defult使用了被動");
    }

    public override void Ult()
    {
        base.Ult();
        Debug.Log("Defult使用了招式");
    }
}
