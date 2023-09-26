using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovementScript : MonoBehaviour
{
    public float MovementSpeed = 5f; 
    private float x = 1f;
    private float y = 0f;

    public GameObject PlayerSprite;
  
    private void Update()
    {
        x = Input.GetAxis("Horizontal") * MovementSpeed * Time.deltaTime;
        y = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;

        transform.Translate(x, y, 0);

        float angle = Mathf.Atan2(y,x) * Mathf.Rad2Deg;
        PlayerSprite.transform.rotation = Quaternion.Euler(0,0, angle);

    }
}
