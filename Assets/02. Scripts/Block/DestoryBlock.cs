using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log(collision.tag);
        if (collision.tag == "BoomDie")
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
    }
}
