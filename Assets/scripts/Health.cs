using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int playerHealth;
    public GameObject RestartButton;
    public Image baaar;
    public float fill;

    void Start()
    {
        fill = 1f;
        playerHealth = 3;
        RestartButton.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DangerThree" || other.gameObject.tag == "Boss")
        {
            fill -= fill*1f;
            baaar.fillAmount = fill;
            playerHealth = (playerHealth - 3);

        }
        else if(other.gameObject.tag == "Enemy")
        {
            fill = fill - 0.33f;
            baaar.fillAmount = fill;
            playerHealth = (playerHealth - 1);
        }
    }

    void Update()
    {
        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);
            RestartButton.SetActive(true);
        }
    }
}

