using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float despawn_distance = 50;
    public GameObject TilePrefab;
    private GameObject player;
    private Vector2 playerlocation;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerlocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerlocation = player.transform.position;
        if (Vector2.Distance(playerlocation, transform.position) > despawn_distance)
        {
            GameObject.FindGameObjectWithTag("Util").GetComponent<Tile_Manager>().tile_locations.Remove(transform.position);
            Destroy(gameObject);
        }
    }
}
