using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyBoss : MonoBehaviour
{

    [SerializeField] float health, maxHealth = 3f;

    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    ScoreCount killCounterScript;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        health = maxHealth;
        target = GameObject.Find("GloverDaniels").transform;
        killCounterScript = GameObject.Find("Score").GetComponent<ScoreCount>();
    }

    
    private void FixedUpdate()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        moveDirection = direction;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
            killCounterScript.AddKill();
            SceneManager.LoadScene("Winner");

        }
    }
}



