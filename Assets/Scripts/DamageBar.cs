using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBar : MonoBehaviour
{
        
    [SerializeField] private UnityEngine.UI.Slider slider;
    [SerializeField] private Gradient gradient;

    public void SetDamage(float damage)
    {
        slider.value = damage;
    }

    public void IncreaseDamage(float inc)
    {
        slider.value += inc;
    }
    
    public void DecreaseDamage(float dec)
    {
        slider.value -= dec;
    }

    public void SetMaxDamage(float damage)
    {
        slider.maxValue = damage;
    }
}
