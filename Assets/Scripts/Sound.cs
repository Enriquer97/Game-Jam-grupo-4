using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioClip move;
    public AudioClip run;
    public AudioSource soundSource;
    public GameObject steps;
    public bool walk;
    // Start is called before the first frame update
    void Start()
    {
        steps.SetActive(false);
        walk = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            soundSource.clip = move;
            steps.SetActive(true);
        }
        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            steps.SetActive(false);

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
