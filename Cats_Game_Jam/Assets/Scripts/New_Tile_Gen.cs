using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Tile_Gen : MonoBehaviour
{
    public Vector2 nextTileOffset = new Vector2(0,0);
    private Vector2 location;
    private Tile_Manager tm;
    private void Start()
    {
        //add getters setters and checkers for tile manager
        tm = GameObject.FindGameObjectWithTag("Util").GetComponent<Tile_Manager>();
        location = new Vector2(transform.parent.position.x + nextTileOffset.x, transform.parent.position.y + nextTileOffset.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!tm.tile_locations.Contains(location) && collision.gameObject.tag.Equals("Player"))
        {
            GameObject newtile = Instantiate(transform.parent.gameObject.GetComponent<Tile>().TilePrefab, location, Quaternion.Euler(new Vector3(0, 0, 0)));
            tm.tile_locations.Add(newtile.transform.position);
        }
    }
}
