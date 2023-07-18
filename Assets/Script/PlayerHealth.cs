using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public AudioSource backgroundMusic;
    public float health = 10;

    public float maxHealth = 10;
    public AudioClip soundFX;
    public AudioClip gameoverSoundFX;
    public AudioClip beingHitFx;

    private SFX sfx;

    [SerializeField] FloatingHealthBar healthBar;

    public GameObject deathEffect;
    public PanelWinDie PanelWinDie;
    private void Awake()
    {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
        sfx = FindObjectOfType<SFX>();
    }

    // Update is called once per frame
    void Update()
    { }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            health = health - 1;
            healthBar.UpdateHealthBar(health, maxHealth);
            sfx.PlayOneShot(beingHitFx);
            Debug.Log(health);
            if (health <= 0)
            {
                backgroundMusic.Stop();
                Instantiate(deathEffect, transform.position, Quaternion.identity);
                sfx.PlayOneShot(soundFX);
                sfx.PlayOneShot(gameoverSoundFX);
                Destroy(gameObject);
                // PanelWinDie.showDiePanel();
                SceneManager.LoadScene("YouDieScene");
            }
        }
    }
}