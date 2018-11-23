﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstalledObject{

    Tile _tile;
    string _objectType;
    float _movementCost;
    int _width;
    int _height;

    protected InstalledObject()
    {

    }

    public static InstalledObject CreatePrototype(string objectType, float movementCost = 1f, int width = 1, int height = 1)
    {
        InstalledObject obj = new InstalledObject();
        obj._objectType = objectType;
        obj._movementCost = movementCost;
        obj._width = width;
        obj._height = height;

        return obj;
    }

    public static InstalledObject PlaceInstance(InstalledObject proto, Tile tile)
    {
        InstalledObject obj = new InstalledObject();

        obj._objectType = proto._objectType;
        obj._movementCost = proto._movementCost;
        obj._width = proto._width;
        obj._height = proto._height;

        obj._tile = tile;
        if (!tile.AssignInstalledObject(obj))
        {
            return null;
        }

        return obj;
    }
}
