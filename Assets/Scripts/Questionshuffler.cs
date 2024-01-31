using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Questionshuffler : MonoBehaviour
{
    public GameObject Fragencanvis;
    public GameObject VorbeiCanvis;
    public GameObject[] Questions;
    public GameObject Questionbody;
    public int Questionnumber = 1;
    public float Timer = 15;
    public TMP_Text TimeText;
    public AudioSource TimeAlmostUp;
    public AudioClip TimeSound;
    public AudioSource ButtonPress;
    public AudioClip Buttonsounds;

    public int Winnerpl;

    void Start()
    {
        Shuffle(Questions);
        Questionnumber = 1;
        Fragencanvis.SetActive(true);
        VorbeiCanvis.SetActive(false);
    }

    public void addWinner()
    {
        Winnerpl++;
    }

    public void Shuffle(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            int destIndex = Random.Range(0, gameObjects.Length);
            GameObject source = gameObjects[i];
            GameObject dest = gameObjects[destIndex];
            if (source != dest)
            {
                Vector3 tmp = source.transform.position;
                source.transform.position = dest.transform.position;
                dest.transform.position = tmp;
            }
        }
    }

    public void NextQuestion()
    {
        Questionnumber++ ;
        Timer = 15;
        TimeText.color = Color.white;
    }
    public void NextSound()
    {
        ButtonPress.PlayOneShot(Buttonsounds, 0.6f);
    }
    public void Update()
    {
        if (Questionnumber == 1)
        {
            Questionbody.transform.localPosition = new Vector3(50f, -750f, 0f);
        }
        if (Questionnumber == 2)
        {
            Questionbody.transform.localPosition = new Vector3(50f, -20f, 0f);
        }
        if (Questionnumber == 3)
        {
            Questionbody.transform.localPosition = new Vector3(50f, 650f, 0f);
        }
        if (Questionnumber == 4)
        {
            Questionbody.transform.localPosition = new Vector3(50f, 1350f, 0f);
        }
        if (Questionnumber == 5)
        {
            Questionbody.transform.localPosition = new Vector3(50f, 2050f, 0f);
        }

        Timer -= Time.deltaTime;

        TimeText.text = Timer.ToString("F0")+"s";
        
        if (Timer <= 0)
        {
            Timer = 15;
            NextQuestion();
            Winnerpl++;
        }

        if (Timer <= 5)
        {
            TimeText.color = Color.red;
            TimeAlmostUp.PlayOneShot(TimeSound, 0.2f);
        }

        if (Winnerpl == 5)
        {
            Fragencanvis.SetActive(false);
            VorbeiCanvis.SetActive(true);
        }
    }
}
