using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _target;

    private void Start()
    {
        _target = transform.rotation.eulerAngles + new Vector3(0, 1, 0);

        transform.DORotate(_target, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);  
    }
}
