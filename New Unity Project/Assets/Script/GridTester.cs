using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTester : MonoBehaviour{
    GameObject grids;
    Ray ry;
    RaycastHit2D rch2d;

    private void Start() {
        grids = GameObject.Find("Grid");
        rch2d = Physics2D.Raycast(ry.origin,Vector2.zero);
    }
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ry = Camera.main.ScreenPointToRay(Input.mousePosition);
            int x = grids.GetComponent<Grid>().LocalToCell(ry.origin).x;
            int y = grids.GetComponent<Grid>().LocalToCell(ry.origin).y;
            Debug.Log(x+", "+y);
        }
    }
}
