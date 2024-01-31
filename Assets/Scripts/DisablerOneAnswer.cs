using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisablerOneAnswer : MonoBehaviour
{
    public GameObject RightAnswer;
    public GameObject WrongAnswer1;
    public GameObject WrongAnswer2;
    public GameObject Next;
    public AudioSource ButtonPress;
    public AudioClip Buttonsounds;


    void Start()
    {
        Next.GetComponent<Button>().interactable = false;
    }


    public void ClickAnswer()
    {
        RightAnswer.GetComponent<Button>().interactable = false;
        RightAnswer.GetComponent<Image>().color = Color.green;
        WrongAnswer1.GetComponent<Button>().interactable = false;
        WrongAnswer1.GetComponent<Image>().color = Color.red;
        WrongAnswer2.GetComponent<Button>().interactable = false;
        WrongAnswer2.GetComponent<Image>().color = Color.red;
        Next.GetComponent<Button>().interactable = true;
        ButtonPress.PlayOneShot(Buttonsounds, 0.6f);
    }

}
