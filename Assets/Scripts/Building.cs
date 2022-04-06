using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [SerializeField]protected float TimeToSpawn;
    [SerializeField]protected float RadiusToSpawn;
    private int _countOfCreatedProducts = 0;
    [SerializeField] private GameObject _product;

    public void SpawnProduct()
    {
        Vector2 randomSpawnInCircle = Random.insideUnitCircle * RadiusToSpawn;
        Vector3 spawnProductPos = new Vector3(
            transform.position.x + randomSpawnInCircle.x,
            0,
            transform.position.z + randomSpawnInCircle.y);
        CreateProduct(spawnProductPos);
        AddProduct();
        SpeakToWorld();
    }

    private void CreateProduct(Vector3 spawnPos)
    {
        
        GameObject product = Instantiate(
            _product,
            spawnPos,
            Quaternion.identity);
    }

    private void AddProduct()
    {
        _countOfCreatedProducts++;
        //Debug.Log("Продукт произведен! Номер продукта: " + _countOfCreatedProducts);
    }
    public abstract void SpeakToWorld();
}
