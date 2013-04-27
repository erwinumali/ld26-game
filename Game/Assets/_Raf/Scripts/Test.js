#pragma strict
 function Start () {
        gameObject.AddComponent("MeshFilter");
        gameObject.AddComponent("MeshRenderer");
        var mesh : Mesh = GetComponent(MeshFilter).mesh;
        mesh.Clear();
        mesh.vertices = [Vector3(0,0,0), Vector3(0,1,0), Vector3(1, 1, 0)];
        mesh.uv = [Vector2 (0, 0), Vector2 (0, 1), Vector2 (1, 1)];
        mesh.triangles = [0, 1, 2];
    }

function Update () {

}