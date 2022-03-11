using UnityEngine;

public class RoapRenderScript : MonoBehaviour
{
    void FixedUpdate()
    {
        _lineRender.SetPosition(0, _startTransform.position);
        _lineRender.SetPosition(1, _endTransform.position);
    }

    [SerializeField]
    private LineRenderer _lineRender = null;

    [SerializeField]
    private Transform _startTransform = null;

    [SerializeField]
    private Transform _endTransform = null;
}
