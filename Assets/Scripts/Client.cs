using UnityEngine;

public class Client : MonoBehaviour {
    public AbstractFactory baseFactory;
    FactoryInterface factory = null;
    ObjectInterface shape = null;

    void OnGUI() {
        if(factory == null) {
            if (GUILayout.Button("Red")) {
                factory = baseFactory.GetFactory(Colors.RED);
            }
            if (GUILayout.Button("Green")) {
                factory = baseFactory.GetFactory(Colors.GREEN);
            }
            if (GUILayout.Button("Blue")) {
                factory = baseFactory.GetFactory(Colors.BLUE);
            }
        } else if(shape == null) {
            if (GUILayout.Button("Cube")) {
                shape = factory.GetCube();
                Instantiate(shape.GetTemplate(),gameObject.transform);
            }
            if (GUILayout.Button("Capsule")) {
                shape = factory.GetCapsule();
                Instantiate(shape.GetTemplate(),gameObject.transform);
            }
            if (GUILayout.Button("Sphere")) {
                shape = factory.GetSphere();
                Instantiate(shape.GetTemplate(),gameObject.transform);
            }
        }
    }
}
