using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitosis : MonoBehaviour
{
    public Transform firepoint;
    public GameObject cellPrefab;

    public float shootingForce = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ApplyMitosis();
        }


    }
    void ApplyMitosis()
    {
        GameObject cell = Instantiate(cellPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = cell.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * shootingForce, ForceMode2D.Impulse);
    }
}
