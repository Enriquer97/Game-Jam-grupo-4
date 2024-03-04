using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radiacion : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 PlayerPosition;
    public GameObject Jugador;
    public bool Sol;


   
    void Start()
    {
        Jugador = GameObject.Find("Jugador");
        Sol = false;

    }


    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 6 | 1 << 7 | 1 << 8;
        PlayerPosition = Jugador.transform.position;
        Vector3 dir = Jugador.transform.position - transform.position;
        RaycastHit rayHit;
        Debug.DrawRay(transform.position, dir, Color.red, 0.1f, true);
        if (Physics.Raycast(transform.position, dir,out rayHit, 2000f))
        {
            if (rayHit.collider.gameObject.name == "Jugador")
            {
              OnRayHit();
            }
            else
            {
              OnNotRayHit();
            }
        }
    }
        void OnRayHit()
        {
            Sol = true;
            Debug.Log(Sol);
        }
        void OnNotRayHit()
        {
            Sol = false;
            Debug.Log(Sol);
        }

}

