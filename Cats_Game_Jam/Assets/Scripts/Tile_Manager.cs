using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Manager : MonoBehaviour
{
    public HashSet<Vector2> tile_locations = new HashSet<Vector2>();
    private void Start()
    {
        tile_locations.Add(new Vector2(0,0));
    }
}
