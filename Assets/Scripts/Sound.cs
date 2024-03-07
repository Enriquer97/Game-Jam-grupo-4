using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioClip move;
    public AudioClip run;
    public AudioClip HurtSound;
    public GameObject Hurt;
    public AudioSource soundSource;
    public AudioSource soundSource2;
    public GameObject steps;
    public GameObject Radiacion;
    public Vector3 PlayerPosition;
    public bool walk;
    // Start is called before the first frame update
    void Start()
    {
        steps.SetActive(false);
        walk = true;
        Radiacion = GameObject.Find("Radiacion");
        soundSource2.clip = HurtSound;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = Radiacion.transform.position;
        Vector3 dir = Radiacion.transform.position - transform.position;
        RaycastHit rayHit;
        if (Physics.Raycast(transform.position, dir, out rayHit, 2000000f))
        {
            if (rayHit.collider.gameObject.name == "Radiacion")
            {
                OnRayHit();
            }
            else
            {
                OnNotRayHit();
            }
        }
            if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            soundSource.clip = move;
            steps.SetActive(true);
        }
        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            steps.SetActive(false);

        }
        void OnRayHit()
        {
            Hurt.SetActive(true);

        }
        void OnNotRayHit()
        {
            Hurt.SetActive(false);
        }

        /*
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            soundSource.clip = run;
            steps.SetActive(true);
        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            steps.SetActive(false);
        }*/
    }
}
