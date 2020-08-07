using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    
    public void setMaxAmmo(int ammo)
    {
        textMesh.text = $"Ammo: {ammo}";
    }
    
    public void setAmmo(int ammo)
    {
        textMesh.text = $"Ammo: {ammo}";
    }
}
