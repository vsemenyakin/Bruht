using UnityEngine;

public class GameObjectsLineRender : MonoBehaviour
{
    void FixedUpdate()
    {
        for (int index = 0; index < _transforms.Length; ++index)
            _lineRender.SetPosition(index, _transforms[index].position);
    }

    [SerializeField]
    private LineRenderer _lineRender = null;

    [SerializeField]
    private Transform[] _transforms = new Transform[2];        
}
