using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poursuite : MonoBehaviour
{
    public GameObject Cible;
 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 C;
    Vector3 S;
    Vector3 SC;
    float v;
    float n;
    C=Cible.transform.position;
    S=this.transform.position;
    SC=C-S;
    n=SC.magnitude;
    }
}
