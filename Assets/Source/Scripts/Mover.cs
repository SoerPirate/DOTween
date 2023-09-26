using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _target;

    private void Start()
    {
        _target = transform.position + transform.forward;   

        transform.DOMove(_target, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
