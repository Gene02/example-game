using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed, lifeTime;

    public Rigidbody rig;

    public GameObject impactEffect;

    public int damage;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        rig.velocity = transform.forward * moveSpeed;
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemigo")
        {
            other.gameObject.GetComponent<EnemyController>().DamageEnemy(damage);
        }


        Destroy(gameObject);
        Instantiate(impactEffect, transform.position, transform.rotation);
    }
}
