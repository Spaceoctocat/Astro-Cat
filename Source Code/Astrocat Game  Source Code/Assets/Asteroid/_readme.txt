Each FBX hierarchy looks like this:

Asteroid_XX
    COLLIDER
    MESH Asteroid_XX
    MESH COLLIDER

The child mesh “COLLIDER” is to be used for ‘mesh collider’ purpose. 
Remove the ‘mesh renderer’ from the object before use. 
The material assigned to colliders are green colored. 
This will help make it visible in case you forgot to remove the collider renderer.

Feel free to leave a comment, if any help is required.