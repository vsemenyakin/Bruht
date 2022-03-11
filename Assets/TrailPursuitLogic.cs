using UnityEngine;

public class TrailPursuitLogic : MonoBehaviour
{
    void FixedUpdate() {
        Vector3 newPosition = transform.position;
        newPosition.x += _speed * Time.fixedDeltaTime;
        transform.position = newPosition;
    }

    [SerializeField]
    private float _speed = 1.0f;
}
