using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EntitySpawner : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private GameObject _entityToSpawn;
    [SerializeField] private BoxCollider2D _spawnArea;
    [SerializeField] private float _maxSpawnTime;
    [SerializeField] private float _minSpawnTime;




    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        if (_spawnArea == null) Debug.LogError("Spawning area not set!");

        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies(){

        while(true){
            yield return new WaitForSeconds(
                Random.Range(1f, _maxSpawnTime)
            );

            Vector3 spawnPosition = new Vector3(
                Random.Range(_spawnArea.bounds.min.x, _spawnArea.bounds.max.x),
                Random.Range(_spawnArea.bounds.min.y, _spawnArea.bounds.max.y),
                0
            );

            var entity = Instantiate(_entityToSpawn, spawnPosition, Quaternion.identity);
            entity.transform.parent = null;
        }

    }
}
