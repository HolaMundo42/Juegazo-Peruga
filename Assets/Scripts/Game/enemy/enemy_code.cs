using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_code : MonoBehaviour
{
    [SerializeField] spawnMeteors meteors;
    AudioSource meteorHit;

    void Awake()
    {
        meteorHit = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.y < 0.5f)
        {
            spawnMeteors theMeteor = meteors.GetComponent<spawnMeteors>();
            theMeteor.SpawnMeteors();
            meteorHit.Play();
            Destroy(gameObject);

        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
