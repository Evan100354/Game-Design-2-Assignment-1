using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Callbacks;
using UnityEngine;
public class ChargeAttackRed : MonoBehaviour
{
    public PlayerParts playerParts;
    public float builtCharge = 0f;
    private bool canCharge = true;
    public float chargeBuildRate = 1f;
    public float maxCharge = 100f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true)
        {
            if(!playerParts.isCharging && !playerParts.isStunned)
                {playerParts.isCharging = true;}
        }

        if(playerParts.isCharging)
        {
            if(builtCharge <= maxCharge)
            {
                builtCharge += chargeBuildRate * Time.deltaTime;
            }
        }

        if(Input.GetKeyUp(KeyCode.E) == true)
        {
            if(canCharge)
                {
                    StartCoroutine(Dash());
                    canCharge = false;
                }
        }
    }

    private IEnumerator Dash()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * builtCharge);

        yield return new WaitForSeconds(1);

        builtCharge = 0;
        canCharge = true;
        playerParts.isCharging = false;
    }
}
