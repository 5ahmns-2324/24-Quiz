using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Winner : MonoBehaviour
{
    public GameObject Fragencanvis;
    public GameObject VorbeiCanvis;
    

    public int Winnerpl = 0;
    public void AddWinner()
    {
       Winnerpl++;
    }

    void Start()
    {
        Fragencanvis.SetActive(true);
        VorbeiCanvis.SetActive(false);
        
    }
    
    void Update()
    {
        if (Winnerpl == 5)
        {
            Fragencanvis.SetActive(false);
            VorbeiCanvis.SetActive(true);

        }

    }
}
