using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    public int[] direction = { 0, 1, 2, 3 };
    public int moveDirection;
    public float puckSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = direction[Random.Range(0,4)];
        Debug.Log("moveDirection = " + moveDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDirection == 0)
        {
            transform.Translate(transform.up * puckSpeed * Time.deltaTime);
        }
    }
}

