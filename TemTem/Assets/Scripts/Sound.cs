using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Step;
    public AudioSource Gem;
    public AudioSource bossmusic;
    public AudioSource normalmusic;
    public AudioClip Gemsound;
void Start()
{
   
}
public void PlayStep()
{
    Step.Play ();
}
public void PlayGem()
{
    Gem.PlayOneShot(Gemsound, 1.0f);
}
public void Playbossmusic()
{
    bossmusic.Play ();
}
public void Playnormalmusic()
{
    normalmusic.Play ();
}
void OnTriggerEnter ()
{
    normalmusic.Stop ();
    bossmusic.Play ();
    
}
 void OnTriggerEnter(Collider other)
    { 
        if
            (other.gameObject.CompareTag ("Pickup"))
        {
            Gem.PlayOneShot(Gemsound, 1.0f);
        }
    }    
}
