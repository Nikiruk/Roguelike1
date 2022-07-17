using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapManager 
{
    public static Tile[,] map; // the 2-dimensional map with the information for all the tiles
}

[Serializable]
public class Tile { //Holds all the information for each tile on the map
    public int xPosition; // the position on the x axis
    public int yPosition; // the position on the y axis
    public string type;
    
[NonSerialized]
    public GameObject baseObject; // the map game object attached to that position: a floor, a wall, etc.
}

[Serializable]
public class Position { //отслеживание позиции
    public int x;
    public int y;
}

[Serializable]
public class Wall { //список позиций, направление(югсеверзападвосток), длина и существует ли созданный из неё элемент
    public List<Position> positions;
    public string direction;
    public int length;
    public bool hasFeature = false;
}

[Serializable]
public class Feature { //элемент имеет список всех позиций, массив стен, тип комната\коридор ширина-высота
    public List<Position> positions;
    public Wall[] walls;
    public string type;
    public int width;
    public int height;
}