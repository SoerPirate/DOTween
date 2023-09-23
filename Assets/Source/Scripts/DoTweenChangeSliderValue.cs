using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoTweenChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {
        _slider.DOValue(1, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
