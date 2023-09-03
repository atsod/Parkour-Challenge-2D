using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerControllerScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 playerSpawnPosition;
     
    private void Start()
    {
        playerSpawnPosition = player.transform.position;    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
            collision.gameObject.transform.position = playerSpawnPosition;
    }
}
