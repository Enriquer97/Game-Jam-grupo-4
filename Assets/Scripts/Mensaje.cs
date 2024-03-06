using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensaje : MonoBehaviour
{
    [SerializeField] private GameObject mensaje;
    void Start()
    {
        Time.timeScale = 0f;
        mensaje.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Time.timeScale = 1f;
            mensaje.SetActive(false);
        }
    }
}
