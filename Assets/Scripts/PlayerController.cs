using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score = 7;
    public float speed = 10.0f;
    public float xRange;
    public float yRange;
    public GameObject Puck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        //Keep Player within xRange (Left and Right sides)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        //Keep Player within yRange (Up and Down sides)
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        Instantiate(Puck, new Vector2(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), Quaternion.identity));


        //Count how many enemies there are in the scene
        int enemyCount = GameObject.FindGameObjectsWithTag("Puck").Length;
        Debug.Log("Puck Count: " + enemyCount);

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log(moveHorizontal);

        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
