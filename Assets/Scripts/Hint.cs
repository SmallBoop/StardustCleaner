using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    [SerializeField] private GameObject text;
    bool e = true;
    [SerializeField] private AudioSource soundint;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && e == true)
        {
            text.SetActive(true);
            if (this.gameObject.CompareTag("Text"))
            {
                soundint.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }

    public void EOff ()
    {
        e = false;
        text.SetActive(false);
    }
}
