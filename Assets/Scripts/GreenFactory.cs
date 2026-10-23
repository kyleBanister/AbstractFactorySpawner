using UnityEngine;


public class GreenFactory: FactoryInterface {
    public GameObject greenCubeTemplate;
    public GameObject greenCapsuleTemplate;
    public GameObject greenSphereTemplate;

    public GreenFactory(GameObject greenCube, GameObject greenCapsule, GameObject greenSphere) {
        greenCubeTemplate = greenCube;
        greenCapsuleTemplate = greenCapsule;
        greenSphereTemplate = greenSphere;
        Debug.Log(greenSphereTemplate);
    }

    public CapsuleInterface GetCapsule() {
        CapsuleInterface greenCapsule = new GreenCapsule(greenCapsuleTemplate);
        return greenCapsule;
    }
    public CubeInterface GetCube() {
        CubeInterface greenCube = new GreenCube(greenCubeTemplate);
        return greenCube;
    }
    public SphereInterface GetSphere() {
        Debug.Log(greenSphereTemplate);
        SphereInterface greenSphere = new GreenSphere(greenSphereTemplate);
        return greenSphere;
    }
}
