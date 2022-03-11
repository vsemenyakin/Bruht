using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignsSpawner : MonoBehaviour
{
    void Start()
    {
        for (float xOffset = 0.0f; xOffset < _distanceToFill; xOffset += _distanceBetween) {
            GameObject instance = Instantiate(_prefab);

            Vector3 resultPosition = _ground.transform.position + _groundOffset;
            resultPosition.x += xOffset;

            instance.transform.position = resultPosition;
        }
    }

    [SerializeField]
    private GameObject _prefab = null;

    [SerializeField]
    private Transform _ground = null;

    [SerializeField]
    private Vector3 _groundOffset = Vector3.zero;

    [SerializeField]
    private float _distanceBetween = 10.0f;

    [SerializeField]
    private float _distanceToFill = 100.0f;

}
