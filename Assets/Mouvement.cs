using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v;                     // On déclare v dans lequel on stock les coordonnées du Joueur
        v=this.transform.position;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * 0.01f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))        // Sprint : si la touche Shift est pressée le multiplicateur de translation est de 0.05, 0.01 sinon
            {
                transform.Translate(Vector3.back * 0.05f);
            }
            else
            {
                transform.Translate(Vector3.back * 0.01f);
            }
        }                                                    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 2);
        }
        if (Input.GetKey(KeyCode.Space) && v.y<1.0005)   // Saut : Si la touche espace est pressée et que le joueur est 
        {                                                // suffisamment proche du sol on effectue une translation selon Y
            transform.Translate(Vector3.up * 1f);
        }
    }
}
