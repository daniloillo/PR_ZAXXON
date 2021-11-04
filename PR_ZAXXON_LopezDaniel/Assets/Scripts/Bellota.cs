using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bellota : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float velocidadR = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(new Vector3(1f, 0f, 0f));
        rb.AddForce(new Vector3(0f, 0f, -1.5f));
    }
}
