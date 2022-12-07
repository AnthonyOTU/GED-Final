using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Vector2 move;
    public Rigidbody rb;
    

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(move.x, move.y);

        if(rb.position.y > 9f)
        {
            this.gameObject.SetActive(false);

        }
    }

    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
