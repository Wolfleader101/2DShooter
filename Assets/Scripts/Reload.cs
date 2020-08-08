using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Image reloadImage;
    [Range(0, 1)]
    public float reloadProgress = 0;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reloadImage.fillAmount += 0.00086f;
    }
}
