using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public Transform[] MovePoint = new Transform[2];//이 두곳 이동
    public float MoveSpeed = 1;

    Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    bool GoBack = false;//앞뒤 반복
    // Update is called once per frame
    void Update()
    {
        rig.velocity = (GoBack ? (MovePoint[0].position - MovePoint[1].position) : -(MovePoint[0].position - MovePoint[1].position)).normalized * MoveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform == MovePoint[0] || collision.transform == MovePoint[1])
        {
            GoBack = !GoBack;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform == MovePoint[0] || collision.transform == MovePoint[1])
        {
            GoBack = !GoBack;
        }
    }
}
