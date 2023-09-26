using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Vector3 _target;

    private void Start()
    {
        _target = transform.localScale + new Vector3(1, 1, 1);

        transform.DOScale(_target, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
