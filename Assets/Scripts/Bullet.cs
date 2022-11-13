using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform _dulo;

    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _powerShoot=500;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet, _dulo.transform.position,_dulo.localRotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward*_powerShoot,ForceMode.Impulse);

        }
        
        
    }
}
