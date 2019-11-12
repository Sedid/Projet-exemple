using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttaquesDuJoueur : MonoBehaviour
{
    static Animator joueurAnimator;
    // Start is called before the first frame update
    void Start()
    {
        joueurAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            joueurAnimator.SetBool("anim_attaquer", true);
        }
        else
        {
            joueurAnimator.SetBool("anim_attaquer", false);
        }

    }
}
