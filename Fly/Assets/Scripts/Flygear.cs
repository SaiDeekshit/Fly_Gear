using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flygear : MonoBehaviour
{
    public float velocity = 1;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetMouseButtonDown(0))
        {
            //Jump
            rigidBody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
