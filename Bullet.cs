using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case "Wall":
            Destroy(gameObject);
            break;
            case "Enemy":
            Destroy (gameObject);
            break;
                
        }
    }
}
*/
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        if (collision.gameObject.TryGetComponent<enemyBoss>(out enemyBoss enemyBossComponent))
        {
            enemyBossComponent.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}