using UnityEngine;

public class CollectableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public ParticleSystem particleSyetem;
    public float timeToHide = 3f;
    public GameObject objectToHide;

    [Header("Audio")]
    public AudioSource collectSFX;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(compareTag))
        {
            Collect();

        }
    }

    protected virtual void Collect()
    {
        if(objectToHide != null)
        {
            objectToHide.SetActive(false);
        }
        Invoke("HideObject", timeToHide);
        OnCollect();

        if(collectSFX != null)
        {
            collectSFX.Play();
        }
    }

    protected virtual void OnCollect()
    {
        if(particleSyetem != null)
        {
            particleSyetem.Play();
        }
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }
}
