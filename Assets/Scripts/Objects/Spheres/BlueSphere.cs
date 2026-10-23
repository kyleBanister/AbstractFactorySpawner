using UnityEngine;

public class BlueSphere: SphereInterface {
    GameObject template;
    public BlueSphere(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}