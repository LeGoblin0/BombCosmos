using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Transform Target;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Target.position.x * speed, Target.position.y * speed, transform.position.z);
    }
}
