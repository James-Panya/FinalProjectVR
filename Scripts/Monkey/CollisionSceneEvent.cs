using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneEvent : MonoBehaviour
{
    public string sceneName;
    public float delay = 0f;
    public AudioSource tickSource;
    private bool stop = false;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (stop == false)
            {
                stop = true;
                tickSource.Play();
                StartCoroutine(DelayLoadScene());
            }
        }
    }

    private IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
