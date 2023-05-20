using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject _rocket;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _spawnerLocation;

    [SerializeField] private float _minY = -1.5f, _max = 0.1f;  //player spawn postion change Y axis - between 
    [SerializeField] private float _minSpawnerTime = 3f, _maxSpawnerTime = 5f;      //player spawn Time change - between

    PlayerScript playerSc;
    GameObject newRocket;

    private float _randomY;
    private float _randomTimeToSpawn;
    private bool _isEnd;

    void Start()
    {
        _isEnd = false;
        StartCoroutine(RocketSpawner());
        playerSc = _player.GetComponent<PlayerScript>();    //access player's script
    }//Start

    private IEnumerator RocketSpawner(){
        while (!_isEnd) {
            _randomY = Random.Range(_minY, _max);
            _randomTimeToSpawn = Random.Range(_minSpawnerTime, _maxSpawnerTime);

            yield return new WaitForSeconds(_randomTimeToSpawn);

            newRocket =Instantiate(_rocket,new Vector2(_spawnerLocation.position.x,_randomY),Quaternion.identity);  //instatiate rocket assign to newRocket game object

            _isEnd = playerSc.isDead;
        } // spawn rockets until player is dead
    }//Rocket Spawner
}
