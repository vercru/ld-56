using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCubeBehaviourScript : MonoBehaviour
{
    public float rotateSpeed = 100f;
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
