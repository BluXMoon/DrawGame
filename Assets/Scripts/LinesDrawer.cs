using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesDrawer : MonoBehaviour
{
    public Line linePrefab;

    public Gradient lineColor;
    public float linePointsMinDistance, lineWidth;

    Camera cam;

    Line currentLine;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
         if (Input.GetMouseButtonDown(0))
         {
             BeginDraw();
         }

         if(currentLine != null)
         {
             Draw();
         }

         if (Input.GetMouseButtonUp(0))
         {
             EndDraw();
         }
    }

    void BeginDraw()
    {
        currentLine = Instantiate(linePrefab, this.transform).GetComponent<Line>();

        currentLine.UsePhysics(false);
        currentLine.SetLineColor(lineColor);
        currentLine.SetPointsDistance(linePointsMinDistance);
        currentLine.SetLineWidth(lineWidth);
    }

    void Draw()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        currentLine.AddPoint(mousePosition);
    }

    void EndDraw()
    {
       if(currentLine != null)
        {
            if(currentLine.pointsCount < 2)
            {
                Destroy(currentLine.gameObject);
            }
            else
            {
                currentLine.UsePhysics(true);
                currentLine = null;
            }
        }
        
    }
}
