using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public static UIController Instance { get; set; }


    int _targetsHit = 0;
    public int TargetsHit
    {
        get
        {
            return _targetsHit;
        }
        set
        {
            _targetsHit = value;
            score.text = "Score: " + _targetsHit;
        }
    }

    public Text score;

    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

}
