using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setScore(int score)
    {
        textMesh.text = $"Score: {score}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
