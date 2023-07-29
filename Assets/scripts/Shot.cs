using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject shot;
    public Transform shotPoint;
    public AudioClip shotSound;
    private AudioSource thesource;

    void Awake()
    {
        thesource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0,180,0);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            thesource.PlayOneShot(shotSound, 1F);
            Instantiate(shot, shotPoint.position, shotPoint.rotation);
        }

    }

}