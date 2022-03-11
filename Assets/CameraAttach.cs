using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAttach : MonoBehaviour
{
    void Update()
    {
        Vector3 position = transform.position;
        position.x = _objectToAttach.position.x;
        position.y = _objectToAttach.position.y;
        transform.position = position;
    }

    [SerializeField]
    private Transform _objectToAttach;
}
