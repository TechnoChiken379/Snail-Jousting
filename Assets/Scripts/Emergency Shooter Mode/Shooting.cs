using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;
    public AudioSource[] soundFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            soundFX[0].Play();
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    Destroy(hit.collider.gameObject);
                    soundFX[1].Play();
                }

                else
                {
                    return;
                }
            }
        }
    }
}
