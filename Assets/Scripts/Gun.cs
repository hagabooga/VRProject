using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float rof = 1;
    public float shootSpeed = 20;
    public GameObject projectile;
    public bool automatic = false;
    public AudioClip clip;

    bool firing = false;
    Transform projectileLocation;
    float timer = 0;

    private void Start()
    {
        projectileLocation = transform.Find("Projectile Location").transform;
    }

    public void Shoot()
    {
        GameObject proj = Instantiate(projectile, projectileLocation.position, transform.rotation);
        proj.GetComponent<Rigidbody>().velocity = shootSpeed * projectileLocation.forward;
        timer = rof;
        GameObject sound = new GameObject();
        sound.transform.SetParent(transform);
        AudioSource audio = sound.AddComponent<AudioSource>();
        audio.clip = clip;
        audio.Play();
        if (!automatic)
        {
            firing = false;
        }
    }

    public void Fire()
    {
        if (timer <= 0)
        {
            firing = true;
        }
    }

    public void Release()
    {
        firing = false;
    }


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0 && firing)
        {
            Shoot();
        }
    }
}
