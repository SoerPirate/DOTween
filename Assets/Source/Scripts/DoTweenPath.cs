using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTweenPath : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    private Tween _tween;

    void Start()
    {
        _tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true).SetLookAt(0.01f);        // SetOptions - связывает последнюю точку с первой, чтобы сделать петлю

        _tween.SetEase(Ease.Linear).SetLoops(-1);                                                               // кривая воспроизведения анимации - линейная, чтобы не было плавного начала и конца
    }
}
