using UnityEngine;

public class GreenCapsule: CapsuleInterface {
    GameObject template;
    public GreenCapsule(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}