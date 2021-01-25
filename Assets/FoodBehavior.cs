using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehavior : MonoBehaviour
{
    public GameObject foodPrefab;

    private FoodSpawn foodspawn;
    private Mitosis mitosis;

    void Awake()
    {
        foodspawn = GameObject.FindObjectOfType<FoodSpawn>();
        mitosis = GameObject.FindObjectOfType<Mitosis>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        foodspawn.UpdateFoodCount();
        Destroy(foodPrefab);
        mitosis.UpdateBiomass();
    }
}
