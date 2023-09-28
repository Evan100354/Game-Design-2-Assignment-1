using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParts : MonoBehaviour
{
    public bool isCharging = false;
    public bool isStunned = false;

    void Update()
    {
        if (isStunned)
            StartCoroutine(recover());
    }

    private  IEnumerator recover()
    {
        yield return new WaitForSeconds(2);
        isStunned = false;
    }
}
