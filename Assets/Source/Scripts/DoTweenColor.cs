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

        _spriteRenderer.DOColor(Color.red, 4).SetLoops(-1, LoopType.Yoyo);      // ������ ����

        _spriteRenderer.DOFade(0, 1).SetLoops(-1,LoopType.Yoyo);                // ������������ // -1 ����������� ���������� 

    }
}
