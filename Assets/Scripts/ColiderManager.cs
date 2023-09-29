using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColiderManager : MonoBehaviour
{
    public PlayerParts playerParts;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.GetComponent<PlayerParts>().isCharging == true)
        {
            Debug.Log("SHOVE!");
            other.gameObject.GetComponent<Rigidbody2D>().velocity = (-other.gameObject.GetComponent<Rigidbody2D>().velocity) / 2;
            other.gameObject.GetComponent<PlayerParts>().isCharging = false;
            this.GetComponent<PlayerParts>().isStunned = true;
        }
    }
}
