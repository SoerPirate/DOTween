using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoTweenText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    void Start()
    {
        _text1.DOText("� ������� ���� �����", 3);                               // �������� �����

        _text2.DOText(" + ��� ���������� � ������", 3).SetRelative();           // ��������� �����

        _text3.DOText("����� ����������", 3, true, ScrambleMode.All);           // ������� �������� ��� �����, ����������
        _text3.DOColor(Color.red, 3);            
    }
}