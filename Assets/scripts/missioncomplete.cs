using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class missioncomplete : MonoBehaviour
{
    private int count; 

    public static bool isDelivered = false;
    public static bool completed = false;

    [SerializeField] Text countText;

    void Awake()
    {
        isDelivered = false;
        count = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" && other.gameObject.tag == "KeyItem")
        {
            MissionProgress.stores++;
            count++;
            isDelivered = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
