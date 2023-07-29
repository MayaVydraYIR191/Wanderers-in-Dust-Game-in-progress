using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMissionProgress : MonoBehaviour
{
    Text countAddText;
    public static int addstores;

    void Start()
    {
        countAddText = GetComponent<Text>();
    }

    void Update()
    {
        countAddText.text = addstores.ToString();
    }
}
