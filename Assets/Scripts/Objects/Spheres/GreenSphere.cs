using UnityEngine;

public class GreenSphere: SphereInterface {
    GameObject template;
    public GreenSphere(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}
