using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingUpDown : MonoBehaviour
{
    public AnimationCurve myCurve;
    public static float upDownSpeed = 0.0f;
    
    private float _elapsedTime;
    private float _initialPositionY;
    
    private void Start()
    {
        myCurve.postWrapMode = WrapMode.PingPong;
        _initialPositionY = transform.position.y;
    }
    
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
    
        Vector3 newPosition = transform.position;
        newPosition.y = _initialPositionY + myCurve.Evaluate(_elapsedTime * upDownSpeed);
        transform.position = newPosition;
    }
}
