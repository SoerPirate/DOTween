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
        _text1.DOText("Я заменил этот текст", 3);                               // заменить текст

        _text2.DOText(" + Это дополнение к тексту", 3).SetRelative();           // дополнить текст

        _text3.DOText("Взлом компуктера", 3, true, ScrambleMode.All);           // перебор символов как взлом, спецэффект
        _text3.DOColor(Color.red, 3);            
    }
}
