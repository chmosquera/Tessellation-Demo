using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Rotate : MonoBehaviour
{

    [SerializeField] private Vector3 rotationSpeed = new Vector3(0f, 100f, 0f);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
