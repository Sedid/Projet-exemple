﻿using System.Collections;
using UnityEngine;

// Ce code est crée en dehors du cours

public class EnnemiPoursuite : MonoBehaviour
{
    static Animator animationsEnnemi;

    public Transform joueur;

    // Start is called before the first frame update
    void Start()
    {
        animationsEnnemi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // orientation du joueur vers l'ennemi, ligne directe entre l'ennemi et le joueur
        Vector3 orientation = joueur.position - this.transform.position;

        float champVision = Vector3.Angle(orientation, this.transform.forward);

        if (Vector3.Distance(joueur.position, this.transform.position) < 6 && champVision < 80)
        {

            // On désactive l'animation de repos de l'ennemi lorsqu'il est assez proche du joueur pour le poursuivre
            animationsEnnemi.SetBool("anim_repos", false);

            


            // Si la longueur du vecteur est supérieur à 1, on dirige l'ennemi vers le joueur uniquement via l'axe Z, de 0.04 de distance à chaque "pas" de l'ennemi 
            if (orientation.magnitude > 1)
            {
                this.transform.Translate(0, 0, .04f);
                animationsEnnemi.SetBool("anim_marcher", true);
                animationsEnnemi.SetBool("anim_attaquer", false);
            }
            else
            {
                animationsEnnemi.SetBool("anim_marcher", false);
                animationsEnnemi.SetBool("anim_attaquer", true);
            }

            // différence de taille entre le joueur et l'ennemi supprimé, 
            // pour éviter que l'ennemi ou le joueur ne tombe à terre lorsqu'il y a une collision
            orientation.y = 0; 

            // fait pivoter l'ennemi vers le joueur grâce à la direction récupérée précédemment
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(orientation), .1f);   
        }

        else
        {
            animationsEnnemi.SetBool("anim_repos", true);
            animationsEnnemi.SetBool("anim_marcher", false);
            animationsEnnemi.SetBool("anim_attaquer", false);
        }
    }
}
