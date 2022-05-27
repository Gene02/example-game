using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController: MonoBehaviour
{
    public int currentHealt = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageEnemy(int damageAmount)
    {
        currentHealt-= damageAmount;

        if(currentHealt <= 0)
        {
            Destroy(gameObject);
        }
    }
}
