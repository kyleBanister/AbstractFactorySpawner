using UnityEngine;

public class RedCapsule: CapsuleInterface {
    GameObject template;
    public RedCapsule(GameObject newTemplate) {
        template = newTemplate;
    }

    public GameObject GetTemplate() {return template;}
}