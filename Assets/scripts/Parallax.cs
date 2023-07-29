using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    public float despoint;
    public float backpoint;

    void Update()
    {
        
        var modificator = Input.GetAxis("Horizontal")*-1;
        if (modificator != 0)
        {
            var speed1 = modificator * speed;
            var despoint1 = modificator * despoint;
            var backpoint1 = modificator * backpoint;


            var pos = transform.position;
            pos.x += speed1 * Time.deltaTime;
            transform.position = pos;
            if (modificator == 1 && pos.x >= despoint1 || modificator == -1 && pos.x <= despoint1)
            {
                pos.x = backpoint1;
                transform.position = pos;
            }
        }
    }
}
