using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionProgress : MonoBehaviour
{
    Text countText;
    public static int stores;
  
    void Start()
    {
        countText = GetComponent<Text>();
    }

    void Update()
    {
        countText.text = stores.ToString();
    }
}
