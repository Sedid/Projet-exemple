using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DegatsRecus : MonoBehaviour
{

    public Slider barrePdv;
    Animator animations;
    public string ennemi;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag != ennemi)
        {
            return;
        }
        barrePdv.value -= 30;
        if (barrePdv.value <= 0)
        {
            animations.SetBool("anim_mort", true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
