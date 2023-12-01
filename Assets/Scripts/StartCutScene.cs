using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutScene : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CutSceneCam;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject On;
    [SerializeField] private GameObject Off;
    [SerializeField] private GameObject Scoretext;
    [SerializeField] private GameObject Momson;
    [SerializeField] private GameObject Titr;
    [SerializeField] private string Scene_Name;

    [Header("Sounds")]
    [SerializeField] private AudioSource child;
    [SerializeField] private AudioSource door;
    [SerializeField] private AudioSource opendoor;
    [SerializeField] private AudioSource mom;
    [SerializeField] private AudioSource momwow;
    [SerializeField] private AudioSource ded;

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
        On.SetActive(false);
        Off.SetActive(true);
        Scoretext.SetActive(false);
        StartCoroutine(Cutscene());
    }

    IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(1);
        Off.SetActive(false);
        anim.Play("StartCutScene");
        yield return new WaitForSeconds(1);
        mom.Play();
        yield return new WaitForSeconds(5);
        child.Play();
        yield return new WaitForSeconds(3);
        door.Play();
        yield return new WaitForSeconds(5);
        ded.Play();
        yield return new WaitForSeconds(17);
        On.SetActive(true);
        yield return new WaitForSeconds(1);
        CutSceneCam.SetActive(false);
        Player.SetActive(true);
        Off.SetActive(true);
        On.SetActive(false);
        Scoretext.SetActive(true);
    }

    public void FinalCutScene()
    {
        StartCoroutine(Cutscenetwo());
    }

    IEnumerator Cutscenetwo()
    {
        Scoretext.SetActive(false);
        On.SetActive(true);
        yield return new WaitForSeconds(1);
        Player.SetActive(false);
        CutSceneCam.SetActive(true);
        Off.SetActive(true);
        On.SetActive(false);
        anim.Play("FinalCutScene");
        yield return new WaitForSeconds(1);
        opendoor.Play();
        yield return new WaitForSeconds(5);
        Momson.SetActive(true);
        yield return new WaitForSeconds(7);
        Titr.SetActive(true);
        yield return new WaitForSeconds(9);
        SceneManager.LoadScene(Scene_Name);
    }
}
