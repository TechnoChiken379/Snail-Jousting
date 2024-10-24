using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockCursor : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; // Unlocks to cursor so you can click buttons and stuff
    }
}
