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
    [SerializeField]
    public GameObject WaterLevel;


    private Vector3 TerrainDefaultValues;
    private float WaterDefaultHeight;

    void Start()
    {
        ter = GetComponent<Terrain>();
        TerrainDefaultValues = ter.terrainData.size;
        print(TerrainDefaultValues.y);
        WaterDefaultHeight = WaterLevel.transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        //updating seed
        generator.setSead(seed);
        //changing terrain
        ter.terrainData.size = new Vector3(TerrainDefaultValues.x, TerrainDefaultValues.y*settings.terrainScale, TerrainDefaultValues.z);
        ter.terrainData.SetHeights(0, 0, generator.generateHeightMap(settings));

        //scaling water
        WaterLevel.transform.localPosition = new Vector3(500, ter.terrainData.size.y*.01f, 500);
    }
}
