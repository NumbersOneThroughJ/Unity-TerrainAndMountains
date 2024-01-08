using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_Value_Interpretor : MonoBehaviour
{
    //Updates the terrain object based on values
    Terrain ter;
    Terrain_Value_Generation generator = new Terrain_Value_Generation();


    [SerializeField]
    public Terrain_Setting settings = new Terrain_Setting();
    [SerializeField]
    public int seed;

    void Start()
    {
        ter = GetComponent<Terrain>();
    }

    // Update is called once per frame
    void Update()
    {
        generator.setSead(seed);
        
        ter.terrainData.SetHeights(0, 0, generator.generateHeightMap(settings));
    }
}
