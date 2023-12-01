using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashup : MonoBehaviour
{
    [SerializeField] private GameObject dirt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            dirt.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            dirt.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
