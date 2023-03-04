using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat_Spawner : MonoBehaviour
{
    public GameObject rat;
    public float spawn_rate = .2f;
    private float timer = 0;
    public float max_spawn_distace = 5;
    public float min_spawn_distace = 3;
    // Update is called once per frame
    void Update()
    {
        if (timer >= spawn_rate)
        {
            int random = Random.Range(0, 4);
            if (random <= 1)
            {
                Instantiate(rat, new Vector2(transform.position.x + Random.Range(min_spawn_distace, max_spawn_distace), transform.position.y + Random.Range(min_spawn_distace, max_spawn_distace)), transform.rotation);
            }
            if (random <= 2)
            {
                Instantiate(rat, new Vector2(transform.position.x + Random.Range(-min_spawn_distace, -max_spawn_distace), transform.position.y + Random.Range(min_spawn_distace, max_spawn_distace)), transform.rotation);
            }
            if (random <= 3)
            {
                Instantiate(rat, new Vector2(transform.position.x + Random.Range(min_spawn_distace, max_spawn_distace), transform.position.y + Random.Range(-min_spawn_distace, -max_spawn_distace)), transform.rotation);
            }
            if (random <= 4)
            {
                Instantiate(rat, new Vector2(transform.position.x + Random.Range(-min_spawn_distace, -max_spawn_distace), transform.position.y + Random.Range(-min_spawn_distace, -max_spawn_distace)), transform.rotation);
            }
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
