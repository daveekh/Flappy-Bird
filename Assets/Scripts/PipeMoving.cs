using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoving : MonoBehaviour
{
    public static float movingSpeed = 0.6f;

    void Update()
    {
        transform.position += Vector3.left * movingSpeed * Time.deltaTime;
    }
}
