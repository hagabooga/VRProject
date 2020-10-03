using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public AudioClip clip;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            GameObject sound = new GameObject();
            sound.transform.position = transform.position;
            AudioSource audio = sound.AddComponent<AudioSource>();
            audio.clip = clip;
            audio.Play();
            Destroy(collision.gameObject);
            Destroy(gameObject);
            UIController.Instance.TargetsHit++;
        }

    }
}
