﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{

    private void Update()
    {
        transform.LookAt(transform.position + Vector3.forward);
    }
}
