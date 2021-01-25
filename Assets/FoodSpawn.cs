using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject foodPrefab;
    public int maxFoodCount = 20;
    public int FoodCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(FoodCount < maxFoodCount)
        {
            Spawn();
        }    
    }

    void Spawn()
    {
        Instantiate(foodPrefab, new Vector2(Random.Range(-7.00f, 3.00f), Random.Range(4.00f, 13.00f)), Quaternion.identity);
        FoodCount++;
    }

    public void UpdateFoodCount()
    {
        FoodCount--;
    }
}
