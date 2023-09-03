using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollectScript : MonoBehaviour
{
    private ParticleSystem particleElement;

    void Start()
    {
        particleElement = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<Animator>().Play("star_collect");
            particleElement.Play();
        }
    }
}
