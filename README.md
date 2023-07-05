# Unity-Extensions

Here are some useful Unity extension methods that I have collected and written over time.

## Collider Extensions
#### GetRandomPointInsideCollider()
Returns a random Vector3 point in world space within a box collider.

## Float Extensions
#### Remap()
Remaps the value of a given float from a source range (minimum and maximum) to a target range (minimum and maximum).
#### RotationNormalizedDeg()
Returns the normalized degree value of a given rotation.
#### RotationNormalizedRad()
Returns the normalized radian value of a given rotation.

## GameObject Extensions
#### GetOrAddComponent()
Returns the component if it exists on the game object, or adds the component and returns it.
#### HasComponent()
Checks if a given component exists on the game object.
#### DestroyChildren()
Destroys all children of a given game object.

## Image Extensions
#### Fade()
Modifies the alpha value of the image to achieve a fade effect.

## List Extensions
#### Shuffle()
Shuffles the elements of a given list using the Fisher-Yates algorithm.
#### GetRandomElement()
Returns a random element in a list.

## Rigidbody Extensions
#### Freeze()
Freezes the object by setting its velocities to zero and enabling kinematic mode for both 2D and 3D rigidbodies.

## Transform Extentions
#### ResetTransform()
Reset's the transforms position, rotation and scale.

## Vector Extensions
#### AddX(), AddY() and AddZ()
Modifies the corresponding axis of a Vector3 or Vector2 struct while keeping the other axes unchanged.

#### WithX(), WithY() and WithZ()
Only changes the vector's given axis for both Vector3 and Vector2 structs.



