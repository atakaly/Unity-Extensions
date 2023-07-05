# Unity-Extensions

Some useful Unity extensions methods that I collect and wrote over the time.

## Collider Extensions
#### GetRandomPointInsideCollider()
In a box collider, returns a random Vector3 point in world space.

## Float Extensions
#### Remap()
Remaps the value of given float with minimum and maximum value to target minumum and maximum value.
#### RotationNormalizedDeg()
Returns the normalized degree to given rotation.
#### RotationNormalizedRad()
Returns the normalized radian to given rotation.

## GameObject Extensions
#### GetOrAddComponent()
If the given component exists in a gameObject returns the component, if it's not, AddComponent and return later.
#### HasComponent()
Is given component exist on gameObject?
#### DestroyChildren()
In a given gameObject, destroys all children of it.

## Image Extensions
#### Fade()
Change the alpha value of the image.

## List Extensions
#### Shuffle()
Shuffle's the given list using Fisher-Yates algoritm
#### GetRandomElement()
Returns a random element in a list.

## Rigidbody Extensions
#### Freeze()
For both in 2D and 3D rigidbodies, freezes the object with setting it's velocities to zero and isKinematics' to true.

## Transform Extentions
#### ResetTransform()
Reset's the transforms position, rotation and scale.

## Vector Extensions
#### AddX(), AddY() and AddZ()
Only adds value to the vector's given axis for both Vector3 and Vector2 structs.

#### WithX(), WithY() and WithZ()
Only changes the vector's given axis for both Vector3 and Vector2 structs.



