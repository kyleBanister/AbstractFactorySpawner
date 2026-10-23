using UnityEngine;


public class BlueFactory: FactoryInterface {
    public GameObject blueCubeTemplate;
    public GameObject blueCapsuleTemplate;
    public GameObject blueSphereTemplate;
    
    public BlueFactory(GameObject blueCube, GameObject blueCapsule, GameObject blueSphere) {
        blueCubeTemplate = blueCube;
        blueCapsuleTemplate = blueCapsule;
        blueSphereTemplate = blueSphere;
    }
    public CapsuleInterface GetCapsule() {
        CapsuleInterface blueCapsule = new BlueCapsule(blueCapsuleTemplate);
        return blueCapsule;
    }
    public CubeInterface GetCube() {
        CubeInterface blueCube = new BlueCube(blueCubeTemplate);
        return blueCube;
    }
    public SphereInterface GetSphere() {
        SphereInterface blueSphere = new BlueSphere(blueSphereTemplate);
        return blueSphere;
    }
}
