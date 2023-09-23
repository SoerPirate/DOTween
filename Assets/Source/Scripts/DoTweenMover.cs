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
        //transform.DOMove(_target.position, _duration);                                        // ���� � ����

        //transform.DOMove(_target.position, _duration).SetDelay(2);                            // ������� ��������

        //transform.DOMove(_target.position, _duration).SetLoops(5,LoopType.Restart);           // ��������� - �� ����� ����� // -1 ����������� ���������� 

        //transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Yoyo);             // ��������� - ���� ���� 

        //transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Incremental);      // ��������� - ������ ����������� 

        //transform.DOMove(_target.position, _duration).From();                                 // ���� �� ����

        transform.DOMove(_target.position, _duration).SetLoops(5, LoopType.Yoyo).From();      // ����������� �������
    }
}
