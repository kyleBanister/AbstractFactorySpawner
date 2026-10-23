using UnityEngine;

public class BlueCube: CubeInterface {
    GameObject template;
    public BlueCube(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}