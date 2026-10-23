using UnityEngine;

public class RedSphere: SphereInterface {
    GameObject template;
    public RedSphere(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}
