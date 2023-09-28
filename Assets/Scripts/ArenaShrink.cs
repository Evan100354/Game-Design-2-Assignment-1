using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaShrink : MonoBehaviour
{
    public float shrinkSpeed = 0.1f;


    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(-50, -50, -50), Time.deltaTime * shrinkSpeed);
    }
}
