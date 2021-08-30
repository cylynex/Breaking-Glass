using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakGlass : MonoBehaviour {

    [SerializeField] GameObject brokenGlass;
    [SerializeField] AudioClip breakSound;
    [SerializeField] AudioSource audio;

    private void OnMouseDown() {
        GameObject bg = Instantiate(brokenGlass, transform.position, transform.rotation);
        audio.Play();
        Destroy(gameObject);
    }

}
