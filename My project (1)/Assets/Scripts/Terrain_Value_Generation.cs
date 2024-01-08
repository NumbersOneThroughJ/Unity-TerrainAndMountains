using SimplexNoise;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_Value_Generation : MonoBehaviour
{

    [SerializeField]
    private int map_Size_X = 512, map_Size_Z = 512;

    [SerializeField]
    public int seed = 9;

    // Start is called before the first frame update
    void Update()
    {
        Noise.Seed = seed;
    }

    public void setSead(int s)
    {
        seed = s;
    }

    //tool used to generate a point based on setting's values
    private float generatePointValue(int x, int y, Terrain_Setting sets)
    {
        float roughness = sets.baseRoughness;
        float curPer = 1;

        float curHeight = 0f;

        for(int i = 0;i<sets.numLayers; i++) 
        {
            curHeight += Noise.CalcPixel2D(x, y, roughness*.1f) * curPer * sets.strength;
            curPer *= sets.persistance;
            roughness *= sets.roughness;
        }

        return curHeight;
    }

    //generates a height map 2d array of floats. 
    public float[,] generateHeightMap(Terrain_Setting sets)
    {
        float[,] hmap = new float[map_Size_X, map_Size_Z];
        for(int z = 0; z<map_Size_Z; z++)
        {
            for (int x = 0; x < map_Size_X; x++)
            {
                hmap[x,z] = generatePointValue(x, z, sets);
            }
        }
        return hmap;
    }

}
