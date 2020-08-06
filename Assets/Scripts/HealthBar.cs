using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public TextMeshProUGUI textMesh;
    

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
        
        textMesh.text = health.ToString();
        
        textMesh.color = gradient.Evaluate(1f);
        textMesh.faceColor = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        
        fill.color = gradient.Evaluate(slider.normalizedValue);
        
        textMesh.text = health.ToString();

        textMesh.color = gradient.Evaluate(slider.normalizedValue);
        textMesh.faceColor = gradient.Evaluate(slider.normalizedValue);
    }
}
