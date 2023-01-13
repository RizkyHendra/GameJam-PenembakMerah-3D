using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarEnemy : MonoBehaviour
{
    [SerializeField] private Image _healthBarScript;
     public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        _healthBarScript.fillAmount = maxHealth / currentHealth;
        
    }
}
