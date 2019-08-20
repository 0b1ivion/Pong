using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Pink;
    public int Blue;

    public void Team1Scored()
    {
        Blue++;
    }

    public void Team2Scored()
    {
        Pink++;
    }

}
