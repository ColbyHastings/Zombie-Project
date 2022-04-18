// Written by Abbi MaKarrall
// 3/29/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    // Variables
    [SerializeField] private float mouseSensitivity;

    // References
    private Transform parent;


    private void Start()
    {
        parent = transform.parent;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        parent.Rotate(Vector3.up, mouseX);
    }

}
