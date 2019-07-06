using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisable_nvp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindObjectsOfType<Camera>().Length > 1) this.gameObject.SetActive(false);
    }

}
