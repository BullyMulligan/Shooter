using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.useGravity = true;
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
    
}
