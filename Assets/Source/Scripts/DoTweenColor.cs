using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(Color.red, 4).SetLoops(-1, LoopType.Yoyo);      // меняем цвет

        _spriteRenderer.DOFade(0, 1).SetLoops(-1,LoopType.Yoyo);                // прозрачность // -1 зацикливает бесконечно 

    }
}
