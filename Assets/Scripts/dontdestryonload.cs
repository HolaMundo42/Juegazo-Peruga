using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestryonload : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
