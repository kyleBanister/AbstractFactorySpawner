using UnityEngine;


public class AbstractFactory: MonoBehaviour {
    public GameObject redCubeTemplate;
    public GameObject redCapsuleTemplate;
    public GameObject redSphereTemplate;

    public GameObject greenCubeTemplate;
    public GameObject greenCapsuleTemplate;
    public GameObject greenSphereTemplate;

    public GameObject blueCubeTemplate;
    public GameObject blueCapsuleTemplate;
    public GameObject blueSphereTemplate;

    public FactoryInterface GetFactory(Colors factoryType) {
        switch(factoryType) {
            case Colors.RED:
            FactoryInterface redFactory = new RedFactory(redCubeTemplate, redCapsuleTemplate, redSphereTemplate);
            return redFactory;
            case Colors.GREEN:
            FactoryInterface greenFactory = new GreenFactory(greenCubeTemplate, greenCapsuleTemplate, greenSphereTemplate);
            return greenFactory;
            case Colors.BLUE:
            FactoryInterface blueFactory = new BlueFactory(blueCubeTemplate, blueCapsuleTemplate, blueSphereTemplate);
            return blueFactory;
        }
        return null;
    }
}
