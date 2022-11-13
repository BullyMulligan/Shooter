using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    
    [SerializeField] private GameObject _enemy;
    
    
    
    [SerializeField] private int countEnemys=5;
    void Start()
    {
        for (int i=0;i<=countEnemys;i++)
        {
                
            var enemy = Instantiate(_enemy);//спавним нового врага
            enemy.transform.position = new Vector3( Random.Range(-20,20),1,Random.Range(-20,20));
        }
    }
}