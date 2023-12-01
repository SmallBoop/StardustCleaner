using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public bool amITrashed;
    [SerializeField] private string Trashccan;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == Trashccan)
        {
            amITrashed = true;
            this.GetComponent<LightHint>().LightOff();
        }
    }
}
