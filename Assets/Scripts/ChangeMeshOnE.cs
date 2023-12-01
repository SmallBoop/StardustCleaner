using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMeshOnE : MonoBehaviour
{
    bool canChange;
    public GameObject newObj;
    public GameObject oldObj;
    public Score score;
    private bool scoreplus = true;
    public Collider col;
    [SerializeField] private AudioSource soundinteract;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canChange && Input.GetKeyDown(KeyCode.E) && scoreplus == true)
        {
            soundinteract.Play();
            newObj.SetActive(true);
            oldObj.SetActive(false);
            ScorePlus();
            col.enabled = false;
            canChange = false;
        }

    }


    void ScorePlus()
    {
        score.AddScore();
        scoreplus = false;
        this.GetComponent<Hint>().EOff();
        this.GetComponent<LightHint>().LightOff();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            canChange = true;
            Debug.Log("clicked");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canChange = false;
        }
    }
}
