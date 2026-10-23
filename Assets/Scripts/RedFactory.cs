using UnityEngine;



public class RedFactory: FactoryInterface {
    public GameObject redCubeTemplate;
    public GameObject redCapsuleTemplate;
    public GameObject redSphereTemplate;
    
    public RedFactory(GameObject redCube, GameObject redCapsule, GameObject redSphere) {
        redCubeTemplate = redCube;
        redCapsuleTemplate = redCapsule;
        redSphereTemplate = redSphere;
    }
    public CapsuleInterface GetCapsule() {
        CapsuleInterface redCapsule = new RedCapsule(redCapsuleTemplate);
        return redCapsule;
    }
    public CubeInterface GetCube() {
        CubeInterface redCube = new RedCube(redCubeTemplate);
        return redCube;
    }
    public SphereInterface GetSphere() {
        SphereInterface redSphere = new RedSphere(redSphereTemplate);
        return redSphere;
    }
}
