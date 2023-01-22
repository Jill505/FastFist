using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameContorler : MonoBehaviour
{

    public GameObject arrow;
    public Text theText;

    public float dir;
    public float allowRange;
    public float returnValue;

    public AudioClip soundEffect0;
    public AudioClip soundEffect1;

    AudioSource audioSoruce;
    float reactCountdown;
    bool roundReturnPlayerOne;

    [SerializeField] [Range(0.1f, 10f)] public float ReactTime;

    public characterBase player1;
    public characterBase player2;

    // Start is called before the first frame update
    void Start()
    {
        audioSoruce = gameObject.GetComponent<AudioSource>();

        allowRange = 50f;
        Invoke("makeDis",0f);
    }

    Vector2 lastPos;//鼠标上次位置
    Vector2 currPos;//鼠标当前位置
    Vector2 offset;//两次位置的偏移值

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            currPos = Input.mousePosition;
            offset = currPos - lastPos;
            returnValue = angle(lastPos, currPos);
            DoMatch(offset);
        }
    }

    void HealthBalence()
    {
        if (roundReturnPlayerOne)//玩家1回合
        {

        }
        else//玩家2回合
        {

        }
    }

    void makeDamage(float index)
    {
        if (roundReturnPlayerOne)
        {

        }
        else
        {

        }
    }

    void DoMatch(Vector2 _offset)
    {
        //水平判斷
        if (Mathf.Abs(offset.x) > Mathf.Abs(offset.y))
        {
            if (offset.x > 0)
            {
                Debug.Log("右");
            }
            else
            {
                Debug.Log("左");
            }
        }
        else//垂直判斷
        {
            if (offset.y > 0)
            {
                Debug.Log("上");
            }
            else
            {
                Debug.Log("下");
            }
        }
        makeSure();
    }

    float angle(Vector2 from,Vector2 to)
    {
        Vector3 swapVector = (to - from).normalized;
        float swap = Mathf.Atan2(swapVector.y, swapVector.x)* Mathf.Rad2Deg;
        if (swap < 0)
        {
            swap += 360f;
        }
        return swap;
    }


    void makeDis()
    {
        dir = Random.Range(0f, 360f);

        arrow.transform.rotation = Quaternion.Euler(0f,0f,dir);
        Invoke("makeDis", ReactTime);
        reactCountdown = ReactTime;
    }

    void FixedUpdate()
    {
        reactCountdown -= Time.fixedDeltaTime;
        theText.text = "剩餘時間：\n" + (int)reactCountdown;
    }
    
    void makeSure()
    {
        float rangeMax = dir + allowRange;
        float rangeMin = dir - allowRange;

        Debug.Log(rangeMin + "rf" + rangeMax);

        if (returnValue <= rangeMax && returnValue >= rangeMin)
        {
            Debug.Log("ya");
            audioSoruce.clip = soundEffect0;
            audioSoruce.Play();
        }
        else if (rangeMax > 360 && rangeMax - 360f > returnValue)
        {
            Debug.Log("ya2");
            audioSoruce.clip = soundEffect0;
            audioSoruce.Play();
        }
        else if (rangeMin < 0 && rangeMin + 360f < returnValue)
        {
            Debug.Log("ya3");
            audioSoruce.clip = soundEffect0;
            audioSoruce.Play();
        }
        else
        {
            Debug.Log("NO");
            audioSoruce.clip = soundEffect1;
            audioSoruce.Play();
        }
    }

    void sortingHat(characterBase character)
    {
        if (character.characterSort == 0)
        {
            character.chargeMaxment = 300f;
            character.HPS = 60f;
            character.STR = 40f;
            character.RAC = 50f;
            character.CUR = 40f;
            character.ABlock = 0.4f;
        }
        else if (character.characterSort == 0)
        {

        }
        else
        {
            Debug.Log("此角色沒有對應的characterSort");
        }
    }
}
