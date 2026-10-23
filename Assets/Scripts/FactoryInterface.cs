using UnityEngine;


public interface FactoryInterface {
    public CapsuleInterface GetCapsule();
    public CubeInterface GetCube();
    public SphereInterface GetSphere();
}
