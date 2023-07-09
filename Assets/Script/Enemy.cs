using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variable for take damage
    public int health;
    public int maxHealth;
    public GameObject deathEffect;

    //variable for shooting
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    private float timeBtwShot;
    public float startTimeBtwShots;
    public GameObject projectile;
    public Transform player;
    public Transform shotPoint;

    [SerializeField] FloatingHealthBar healthBar;

    private void Awake()
    {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShot = startTimeBtwShots;
    }

    private void Update()
    {
        //if for moving
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        } else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        //if for shooting
        if (timeBtwShot <= 0)
        {
            Instantiate(projectile, shotPoint.position, Quaternion.identity);
            timeBtwShot = startTimeBtwShots;
        } else
        {
            timeBtwShot -= Time.deltaTime;
        }


        //if for take damage
        if(health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.UpdateHealthBar(health, maxHealth);
    }
}
