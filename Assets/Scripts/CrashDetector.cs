using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField]float crashDelay = 1f;

    [SerializeField] AudioClip AC;
    [SerializeField] ParticleSystem crashEffect;

    bool hasCrashed = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="Ground"&&!hasCrashed)
        {  
            hasCrashed=true;          
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(AC);
            Invoke("ReloadScene", crashDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
