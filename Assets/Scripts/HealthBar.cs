using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    [SerializeField] private Slider slider;
    [SerializeField] private Gradient gradient;

    [SerializeField] private Image fill;

    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void IncreaseHealth(float inc)
    {
        slider.value += inc;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    
    public void DecreaseHealth(float dec)
    {
        slider.value -= dec;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        fill.color = gradient.Evaluate(1f);
    }
}
