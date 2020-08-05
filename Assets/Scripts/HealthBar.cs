﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text text;

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);

        text.text = health.ToString();
        text.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        
        fill.color = gradient.Evaluate(slider.normalizedValue);
        
        text.text = health.ToString();
        text.color = gradient.Evaluate(slider.normalizedValue);
    }
}
