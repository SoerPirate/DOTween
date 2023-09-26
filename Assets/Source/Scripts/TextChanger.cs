using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Sequence sequence;

    void Start()
    {
        sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("� ������� ���� �����", 3));

        sequence.Append(_text.DOText(" + ��� ���������� � ������", 3).SetRelative());  
        
        sequence.Append(_text.DOText("����� ������", 3, true, ScrambleMode.All));
    }
}
