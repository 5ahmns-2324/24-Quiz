using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisablerTwoAnswers : MonoBehaviour
{
    public GameObject RightAnswer1;
    public GameObject RightAnswer2;
    public GameObject WrongAnswer;
    public GameObject Next;
    private int RightAnswerint = 0;
    private bool WronAnswerbool = false;
    public AudioSource ButtonPress;
    public AudioClip Buttonsounds;

    void Start()
    {
        Next.GetComponent<Button>().interactable = false;
    }

    void Update()
    {
        if (RightAnswerint == 2)
        {
                RightAnswer1.GetComponent<Button>().interactable = false;
                RightAnswer1.GetComponent<Image>().color = Color.green;
                RightAnswer2.GetComponent<Button>().interactable = false;
                RightAnswer2.GetComponent<Image>().color = Color.green;
                WrongAnswer.GetComponent<Button>().interactable = false;
                WrongAnswer.GetComponent<Image>().color = Color.red;
                Next.GetComponent<Button>().interactable = true;
        }

        if (WronAnswerbool == true)
        {
            RightAnswer1.GetComponent<Button>().interactable = false;
            RightAnswer1.GetComponent<Image>().color = Color.green;
            RightAnswer2.GetComponent<Button>().interactable = false;
            RightAnswer2.GetComponent<Image>().color = Color.green;
            WrongAnswer.GetComponent<Button>().interactable = false;
            WrongAnswer.GetComponent<Image>().color = Color.red;
            Next.GetComponent<Button>().interactable = true;
        }

    }
    public void ClickRightAnswer1()
    {
        RightAnswerint++;
        RightAnswer1.GetComponent<Button>().interactable = false;
        RightAnswer1.GetComponent<Image>().color = Color.grey;
        ButtonPress.PlayOneShot(Buttonsounds, 0.6f);
    }
    public void ClickRightAnswer2()
    {
        RightAnswerint++;
        RightAnswer2.GetComponent<Button>().interactable = false;
        RightAnswer2.GetComponent<Image>().color = Color.grey;
        ButtonPress.PlayOneShot(Buttonsounds, 0.6f);
    }
    public void ClickWrongAnswer()
    {
        WronAnswerbool = true;
        ButtonPress.PlayOneShot(Buttonsounds, 0.6f);
    }

}
