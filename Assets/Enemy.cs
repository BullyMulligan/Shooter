using System;
using UnityEngine;
using UnityEngine.Serialization;
using System.Collections;
using System.Collections.Generic;


public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _player;//цель, за которой должен двигаться персонаж
     private float _currentTime;
    [SerializeField] private float _speed =1;//скорость следования
    
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.LookAt(_player);
        _currentTime += Time.deltaTime;
        var progress = _currentTime *_speed ;
        transform.position = Vector3.Lerp(transform.position,  _player.transform.position, progress);
    }
}