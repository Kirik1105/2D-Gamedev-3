using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particleTrace;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag=="Ground")
        {
            particleTrace.Play();
        }
        
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag=="Ground")
        {
            particleTrace.Stop();
        }
    }
}
