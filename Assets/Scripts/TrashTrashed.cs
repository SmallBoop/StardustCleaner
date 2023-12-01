using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashTrashed : MonoBehaviour
{
    public bool allCleared;
    public GameObject[] trashes;
    public Score score;
    private bool scoreplus = true;
    [SerializeField] private string Trashname;

    // Start is called before the first frame update
    void Start()
    {
       trashes = GameObject.FindGameObjectsWithTag(Trashname);
        StartCoroutine(CheckIfTrashCleared());
    }

    // Update is called once per frame
    void Update()
    {
        if (allCleared && scoreplus == true)
        {
            ScorePlus();
        }
    }
    void ScorePlus()
    {
        score.AddScore();
        scoreplus = false;
    }

    IEnumerator CheckIfTrashCleared()
    {     
        while (true)
        {
            allCleared = true;
            foreach (GameObject trash in trashes)
            {             
                if(trash.GetComponent<Trash>().amITrashed == false)
                {
                    allCleared = false;
                    break;
                }
            }
            yield return null;
        }
    }
}
