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
    public float max_rats = 15;
    public List<GameObject> rats;
    // Update is called once per frame
    void Update()
    {
        if (rats.Count < max_rats)
        {
            if (timer >= spawn_rate)
            {
                int random = Random.Range(0, 4);
                Vector2 location = new Vector2(transform.position.x + Random.Range(-max_spawn_distace, max_spawn_distace), transform.position.y + Random.Range(-max_spawn_distace, max_spawn_distace));
                while (Vector2.Distance(transform.position, location) < min_spawn_distace) 
                {
                    location = new Vector2(transform.position.x + Random.Range(-max_spawn_distace, max_spawn_distace), transform.position.y + Random.Range(-max_spawn_distace, max_spawn_distace));
                }
                rats.Add(Instantiate(rat, location, transform.rotation));
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }  
    }
}
