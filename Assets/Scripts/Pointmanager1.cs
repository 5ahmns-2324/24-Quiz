using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pointmanager : MonoBehaviour
{
    public float points = 0;
    public TMP_Text pointsText;
    public void AddWholepoint()
    {
        points += 1;
    }
    public void AddHalfpoint()
    {
        points += 0.5f;
    }
    public void Update()
    {
     pointsText.SetText ("Du hast " + points.ToString() + "/5 Fragen richtig");
    }

}
