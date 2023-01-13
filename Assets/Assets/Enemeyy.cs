using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemeyy : MonoBehaviour
{
    [SerializeField] float _maxHealth = 10;
    private float _currentHealth;
    [SerializeField] private HealthBarEnemy _healthBar;
    [SerializeField] private GameObject DeathEffect;
    public GameObject END;



    private void Awake()
    {

    }
    void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.UpdateHealthBar(_maxHealth, _currentHealth);



    }

    // Update is called once per frame
    void Update()
    {
        if (_currentHealth < 0)
        {
            Instantiate(DeathEffect, transform.position, Quaternion.Euler(-90, 0, 0));
            Destroy(gameObject);
            END.SetActive(true);
        }
    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            _currentHealth -= 1;

        }
    }
}
