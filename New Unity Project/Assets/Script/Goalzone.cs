using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalzone : MonoBehaviour
{
    public ScoreManager sm;
    public string teamName;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        BallRez.instance.instantiateBall();

        if(teamName == "Pink")
        {
            sm.Team1Scored();
        }

        if(teamName == "Blue")
        {
            sm.Team2Scored();
        }

    }
}