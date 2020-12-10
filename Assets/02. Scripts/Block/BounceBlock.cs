using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBlock : MonoBehaviour
{
    public bool YMove = false;
    public float YPower = 7;
    public bool XMove = false;
    public float XPower = 7;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.tag);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.GetComponent<Rigidbody2D>().velocity = (collision.transform.position - new Vector3(transform.position.x, transform.position.y, collision.transform.position.z)).normalized * BounceSpeed;
            if (YMove)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, YPower, 0);
            }
            if (XMove)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(XPower, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y, 0);
            }
        }
    }
}
