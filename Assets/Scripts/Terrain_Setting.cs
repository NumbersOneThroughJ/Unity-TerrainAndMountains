using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain_Setting : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 2f)]
    public float strength = 1;
    [SerializeField]
    [Range(0f, 2f)]
    public float baseRoughness = 1;
    [SerializeField]
    [Range(0f, 10f)]
    public float roughness = 2;
    [SerializeField]
    [Range(0f, 1f)]
    public float persistance = .5f;
    [SerializeField]
    public int numLayers = 3;
    [SerializeField]
    [Range(0f, 1000f)]
    public float terrainScale = 1f;
}
