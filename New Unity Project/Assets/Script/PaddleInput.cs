using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerController
{
    Player1,
    Player2
}
//Stop looking at my code u nerd

public class PaddleInput : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed;
    public float clampValue;
    public string axisName;

    void Start()
    {
        if(playerSetting == PlayerController.Player1)
        {
            axisName = "Player_1";
        }
        if(playerSetting == PlayerController.Player2)
        {
            axisName = "Player_2";
        }
    }

    void Update()
    {
        MovePaddle(Input.GetAxis(axisName));
    }

    public void MovePaddle(float ammountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3((ammountToMove * speed),0,0);
        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -clampValue, clampValue);
        gameObject.transform.position = clampedGameObjectPosition;
    }


}
