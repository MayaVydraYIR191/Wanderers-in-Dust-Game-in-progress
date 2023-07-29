using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddMission : MonoBehaviour
{
    private int addcount;

    public static bool isDeliveredAdd = false;
    public static bool Addcompleted = false;

    [SerializeField] Text countAddText;

    void Awake()
    {
        isDeliveredAdd = false;
        addcount = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" && other.gameObject.tag == "AddKeyItem")
        {
            AddMissionProgress.addstores++;
            addcount++;
            isDeliveredAdd = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

