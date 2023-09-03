using UnityEngine;

public class StarCollecting : MonoBehaviour
{
    private ParticleSystem _particleElement;

    void Start()
    {
        _particleElement = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<HeroMovement>() != null)
        {
            GetComponent<Animator>().Play("star_collect");
            _particleElement.Play();
        }
    }
}
