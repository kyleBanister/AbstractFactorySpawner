using UnityEngine;

public class RedCube: CubeInterface {
    GameObject template;
    public RedCube(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}
