using System;
using System.Collections.Generic;
using System.Text;

namespace kNN_Leo
{
    class Flor
    {
        public string type;
        public Vector2 sepala;
        public Vector2 petala;

        public Flor(string p_type, Vector2 p_sepala, Vector2 p_petala)
        {
            type = p_type;
            sepala = p_sepala;
            petala = p_petala;
        }
    }
}

public class Vector2
{
    public float x;
    public float y;

    public Vector2(float argx, float argy)
    {
        x = argx;
        y = argy;
    }
}
