using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanceHandeling : MonoBehaviour
{
    public GameObject lance;
    public Quaternion backUpLanceRotation;
    public float timerX;
    public float timerY;
    public float timerZ;
    public bool holdingW;
    public bool holdingS;
    public bool holdingA;
    public bool holdingD;

    void Start()
    {
        Debug.Log(lance.transform.rotation);
        backUpLanceRotation = lance.transform.rotation;
        timerX = backUpLanceRotation.x;
        timerY = backUpLanceRotation.y;
        timerZ = backUpLanceRotation.z;
        Debug.Log(lance.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        HoldingKeys();
        WhenHoldingKeys();
        lance.transform.rotation = Quaternion.Euler(timerX, timerY, timerZ);
    }

    void WhenHoldingKeys()
    {
        if (holdingW) { timerX += (Time.deltaTime / 10); } else { timerX -= (Time.deltaTime / 10); }
        //if (holdingS) { timerX -= (Time.deltaTime / 10); }
        //if (holdingA) { timerZ -= (Time.deltaTime / 10); }
        if (holdingD) { timerZ += (Time.deltaTime / 10); } else { timerZ -= (Time.deltaTime / 10); }
    }

    void HoldingKeys()
    {
        if (Input.GetKey(KeyCode.W)) { holdingW = true; } else { holdingW = false; }
        //if (Input.GetKey(KeyCode.S)) { holdingS = true; } else { holdingS = false; }
        //if (Input.GetKey(KeyCode.A)) { holdingA = true; } else { holdingA = false; }
        if (Input.GetKey(KeyCode.D)) { holdingD = true; } else { holdingD = false; }
    }
}
