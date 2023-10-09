using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SawController : MonoBehaviour
{
    public float movementSpeed;
    private bool moveUp;
    private float startPosY;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        moveUp = false;
        startPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        moveSaw();
    }

    public void moveSaw()
    {
        if (moveUp)
        {
            //Move the saw up
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
        else
        {
            //Move saw down
            //Must multiply by Time.deltaTime so that the speed of the saw isn't based on framerate
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
        }

        //Determine if the saw needs to move up or move down
        if (transform.position.y >= startPosY)
        {
            moveUp = false;
        }

        if (transform.position.y <= startPosY - offset)
        {
            moveUp = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Dead");
        }
    }
}
