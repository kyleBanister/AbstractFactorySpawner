using UnityEngine;

public class BlueCapsule: CapsuleInterface {
    GameObject template;
    public BlueCapsule(GameObject newTemplate) {
        template = newTemplate;
    }
    public GameObject GetTemplate() {return template;}
}