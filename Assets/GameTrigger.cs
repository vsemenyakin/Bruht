using UnityEngine;

public class GameTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        onEnter?.Invoke(collider);
    }

    void OnTriggerExit2D(Collider2D collider) {
        onExit?.Invoke(collider);
    }

    public delegate void OnEnter(Collider2D collider);
    public delegate void OnExit(Collider2D collider);

    public OnEnter onEnter;
    public OnExit onExit;
}
