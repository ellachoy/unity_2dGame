using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpPower;
    public float moveDistance;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rigid2D.velocity = Vector2.up * jumpPower;
        }

        //move to right, left
      
        if (Input.GetMouseButtonUp(1)){
            rigid2D.velocity = Vector2.right * moveDistance;
        }
        if (Input.GetMouseButtonUp(2)){
            rigid2D.velocity = Vector2.left* moveDistance;
        }
    }
}
