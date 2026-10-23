using UnityEngine;

public class GreenCube: CubeInterface {
    GameObject template;
    public GreenCube(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}