using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float followSpeed = 2f;
    public float yOffset = 1.5f;
    public float xOffset = 2f;

    public Transform target;



    void Update()
    {

        Vector3 newPos = new Vector3(target.position.x + xOffset, 0, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);

    }
}
