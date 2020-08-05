using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public float HitEffectTime = 5;
    private SpriteRenderer effectSprite;
    private float finishedAnimation;
    
    // Start is called before the first frame update
    void Start()
    {
        effectSprite = this.GetComponent<SpriteRenderer>();
        finishedAnimation = this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + 0.2f;
        
        StartCoroutine(ChangeLayer());
        StartCoroutine(RemoveBlood());
    }

    
    IEnumerator ChangeLayer()
    {
        yield return new WaitForSeconds(finishedAnimation);
        effectSprite.sortingLayerName = "Default";
    }
    
    IEnumerator RemoveBlood()
    {
        yield return new WaitForSeconds(HitEffectTime);
        Object.Destroy(this.gameObject);
    }
    void Update()
    {
        
    }
}
