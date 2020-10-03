using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject target;

    float timer = 1;
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = Random.Range(0.1f, 2);
            GameObject obj = Instantiate(target, transform);
            obj.transform.position += (Vector3.up * Random.Range(-2, 2.0f)) + (Vector3.left * Random.Range(-5.0f, 5.0f));
            Destroy(obj, Random.Range(1.0f, 4));
        }
    }
}
