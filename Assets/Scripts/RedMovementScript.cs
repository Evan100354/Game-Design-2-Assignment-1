using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMovementScript : MonoBehaviour
{
	public PlayerParts playerParts;
    public float playerSpeed = 10; //speed player moves
	public float turnSpeed = 100; // speed player turns

	void Update () 
	{
		if (!playerParts.isCharging && !playerParts.isStunned)
		{
			if(Input.GetKey(KeyCode.W))//Press up arrow key to move forward on the Y AXIS
			{
				transform.Translate(0,playerSpeed * Time.deltaTime,0);
			}
			if(Input.GetKey(KeyCode.S))//Press up arrow key to move forward on the Y AXIS
			{
				transform.Translate(0, -playerSpeed * Time.deltaTime,0);
			}
			if(Input.GetKey(KeyCode.A)) //Right arrow key to turn right
			{
				transform.Rotate(Vector3.forward *turnSpeed* Time.deltaTime);
			}

			if(Input.GetKey(KeyCode.D))//Left arrow key to turn left
			{
				transform.Rotate(-Vector3.forward *turnSpeed* Time.deltaTime);
			}
		}
	}

}