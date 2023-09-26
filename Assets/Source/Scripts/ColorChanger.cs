using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    [SerializeField] private Color _color;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
