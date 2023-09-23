using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class DoTweenMover : MonoBehaviour
{
    [SerializeField] private float _duration;               

    [SerializeField] private Transform _target;             

    private void Start()
    {
        //transform.DOMove(_target.position, _duration);                                        // идем к цели

        //transform.DOMove(_target.position, _duration).SetDelay(2);                            // сначала задержка

        //transform.DOMove(_target.position, _duration).SetLoops(5,LoopType.Restart);           // зациклить - из одной точки // -1 зацикливает бесконечно 

        //transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Yoyo);             // зациклить - туда сюда 

        //transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Incremental);      // зациклить - шаблон повторяется 

        //transform.DOMove(_target.position, _duration).From();                                 // идем ОТ цели

        transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Yoyo).From();      // комбинируем функции
    }
}
