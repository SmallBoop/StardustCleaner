using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHint : MonoBehaviour
{
    [SerializeField] private GameObject lighthint;
    [SerializeField] private Material glow;
    [SerializeField] private Material defolt;
    Renderer obj;

    bool lightoff = true;

    void Start()
    {
        obj = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && lightoff == true)
        {
            lighthint.SetActive(true);
            obj.sharedMaterial = glow;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            lighthint.SetActive(false);
            obj.sharedMaterial = defolt;
        }
    }

    public void LightOff()
    {
        lightoff = false;
        lighthint.SetActive(false);
    }
}
