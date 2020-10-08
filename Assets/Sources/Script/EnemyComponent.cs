using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyComponent : MonoBehaviour, IPoolable
{
    public ObjectPoolComponent AssociatedPool { get; set; }
    private ProjectileShooterComponent PSC;
    private ScoreManagerComponent scoreManager;
    private HealthComponent health;

    private void Awake()
    {
        PSC = GetComponent<ProjectileShooterComponent>();
        scoreManager = FindObjectOfType<ScoreManagerComponent>();
    }
    void Update()
    {
        if(transform.position.y < -8)
        {
            gameObject.SetActive(false);
            AssociatedPool.PutObject(gameObject);
            
        }
        PSC.Shoot();

    }
    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.gameObject.name == "EnnemiCapsule")
        {
            gameObject.SetActive(false);
            AssociatedPool.PutObject(gameObject);
            
        }
        else if(collision.collider.gameObject.name == "PlayerCapsule")
        {
            gameObject.SetActive(false);
            AssociatedPool.PutObject(gameObject);
            scoreManager.AddPoints(5);
        }
        else if (collision.collider.gameObject.name == "PlayerShip" )
        {
            HealthComponent.hp--;
            if (HealthComponent.hp < 1)
            {
                scoreManager.GameOverView();
            }
        }

    }
    
}
