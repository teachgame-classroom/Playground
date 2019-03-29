using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFromResourcesFolder : MonoBehaviour
{
    private GameObject asteroidPrefab;
    private AudioClip audioClip;
    private Sprite sprite;

    private Sprite[] sprites;

    private AudioSource audioSource;

    private GameObject ship;
    private int spriteIdx = 0;

    // Start is called before the first frame update
    void Start()
    {
        asteroidPrefab = Resources.Load<GameObject>("Asteroid1");
        Debug.Log("Prefab加载完毕");

        audioClip = Resources.Load<AudioClip>("explosion_player");
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;

        sprite = Resources.Load<Sprite>("Sprites/0_SpaceshipBlue");

        sprites = Resources.LoadAll<Sprite>("Sprites");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("按下了空格");
            Instantiate(asteroidPrefab, Random.insideUnitSphere * 5, Quaternion.identity);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            if(ship == null)
            {
                ship = new GameObject("SpaceShip");
                ship.AddComponent<SpriteRenderer>().sprite = sprites[spriteIdx];
            }
            else
            {
                spriteIdx = (spriteIdx + 1) % sprites.Length;
                ship.GetComponent<SpriteRenderer>().sprite = sprites[spriteIdx];
            }
        }
    }
}
