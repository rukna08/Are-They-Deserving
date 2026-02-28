using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetEnvironmentColor : MonoBehaviour {

    public Material planet_environment_material;

    public Color toxic_environment_color;
    public Color oxygen_environment_color;
    public Color radioactive_environment_color;
    
    void Start() {

        planet_environment_material.color = toxic_environment_color;
    }
}