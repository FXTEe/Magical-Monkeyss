using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChange : MonoBehaviour
{
    public Material Skyboxthingy;
    public float lighting = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandTag"))
        {
            RenderSettings.skybox = Skyboxthingy;
            RenderSettings.ambientIntensity = lighting;
        }
    }
}
