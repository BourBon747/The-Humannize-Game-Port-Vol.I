using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform CamaraTest;

    private void Update()
    {
        transform.position = new Vector3(CamaraTest.position.x, CamaraTest.position.y); 
    }
}
