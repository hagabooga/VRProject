using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float liveDuration = 2;
    // Start is called before the first frame update

    void Start()
    {
        tag = "Projectile";
        Destroy(gameObject, liveDuration);
    }
}
