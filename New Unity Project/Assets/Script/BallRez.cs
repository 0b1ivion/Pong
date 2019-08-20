using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRez : MonoBehaviour
{
    public static BallRez instance;
    public GameObject ball;
    private List<int> potentialAngles = new List<int> { 45, 135, 225, 315 };

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        instantiateBall();
    }

    public void instantiateBall()
    {
        int angleIndex = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(0,potentialAngles[angleIndex],0));
    }
}
