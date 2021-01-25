using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitosis : MonoBehaviour
{
    public Transform firepoint;
    public GameObject cellPrefab;

    public int BiomassIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&BiomassIndex>=5)
        {
            ApplyMitosis();
            BiomassIndex -= 5;
        }
    }
    
    void ApplyMitosis()
    {
        GameObject cell = Instantiate(cellPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = cell.GetComponent<Rigidbody2D>(); 
    }

    public void UpdateBiomass()
    {
        BiomassIndex++;
        Debug.Log("Biomass Index is" + BiomassIndex);
    }
}
