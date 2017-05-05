using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300NolanDeutschLab02
{
    class Missile
    {
        //representing the origin or source of the missile 
            //( this will be the end of our tail )
        Point _origin;
        //3 double – representing angle, path length, height 
            //or altitute(Y) destination
        private double _angle;
        private double _pathLength;
        private double _altitude;
        //3 int – representing radius, alpha value, and speed
        private int _radius;
        private int _alpha;
        private int _speed;
        //representing whether it is friend(true) or foe(flase)
        private bool _allegiance;
        //Static CDrawer field, with a set only manual property
        static CDrawer _canvas;
        public static CDrawer Canvas { set { _canvas = value; } }
        //Static int field, with a set only manual property, representing 
            //the “explosion radius” for our missiles
        static int _explosionRadius;
        public static int ExplosionRadius{ set { _explosionRadius = value; } }
        //Static Random field, used during gameplay
        static Random _gen;
        //Static Constructor
        static Missile()
        {
            _explosionRadius = 50;
            _canvas = null;
            _gen = new Random();
        }
        //constructor for incoming ( foe ) missiles
        public Missile()
        {
            //Initialize the source point to a random location somewhere across the top of the drawer
            _origin = new Point((_gen.Next(0, _canvas.ScaledWidth - 1)), 0);
            //Initialize the angle to a random double between 3PI/4 and 5PI/4
            _angle = (_gen.NextDouble() * Math.PI/2) + (3 * Math.PI/4);
            //Default values
            _pathLength = 5;
            _radius = 5;
            _altitude = _canvas.ScaledHeight;
            _speed = 5;
            _allegiance = false;
            _alpha = 1;
        }
        //constructor for our outgoing missiles
        public Missile(Point destination)
        {
            //Initialize the source point to the center of the bottom of the drawer
            _origin = new Point(_canvas.ScaledWidth / 2, _canvas.ScaledHeight);
            //calculate and set the angle from our source to our destination point
            _angle = Math.Atan(-1.0 * (destination.X - _origin.X) / (destination.Y - _origin.Y));
            //Default values
            _radius = 10;
            _speed = 20;
            _allegiance = true;
            _alpha = 130;
            _altitude = destination.Y;
        }
        //calculate the missile location based on its angle and current length traveled - utility function
        public Point Where()
        {
            //Temp points x and y
            int x;
            int y;
            //The calculated end points
            x = (int)(Math.Sin(_angle) * _pathLength) + _origin.X;
            y = (int)(-1.0* Math.Cos(_angle) * _pathLength) + _origin.Y;
            //Return the end points as a point
            return new Point(x, y);
        }
        //evaluate, move and adjust our missile for every step of the game
        public void Move()
        {
            //If the _allegiance is false increment the pathlength by speed
            if (!_allegiance)
                _pathLength += _speed;
            //If the allegiance is true
            else 
            {
                //If the y pos of the missile is > the altitude
                if (Where().Y > _altitude)
                    _pathLength += _speed;  //increment the pathlength by the speed
                //If the y pos of the missile is <= altitude
                else if (Where().Y <= _altitude)
                {
                    //if the radius <= the explosion radius
                    if(_radius <= _explosionRadius)
                        _radius += 5;       //Increment the radius by 5
                    else
                    {
                        _alpha -= 10;       //Decrement the alpha value by 10
                        if (_alpha < 0)     //If alpha value is negative set it 
                            _alpha = 0;         //zero
                    }
                }
            }
        }
        //determine if our missiles are hitting our foes
        public override bool Equals(object obj)
        {
            if (!(obj is Missile))  //If the obj is not a missile return false
                return false;
            Missile temp = (Missile)obj;    //Make a temp Missile obj
            //determine if the missile circles overlap 
            return (Math.Pow((this.Where().X - temp.Where().X), 2)
                    + (Math.Pow((this.Where().Y - temp.Where().Y), 2))
                    <= Math.Pow((this._radius + temp._radius), 2));
        }
        public override int GetHashCode(){ return 1; }
        //Create a rendering method for the missile
        public void Rendering()
        {
            //Set a temp point to the current location
            Point temp = Where();
            if (!_allegiance)//Foe Missiles
            {
                //Add a line from the origin of the missile for the pathlength and angle given in red
                _canvas.AddLine(_origin, _pathLength, _angle, Color.Red, 1);
                //Add a circle at the end of the line to represent the missile in red
                _canvas.AddCenteredEllipse(temp.X, temp.Y, _radius * 2, _radius * 2, Color.Red);
            }
            else//Friend missiles
            {
                //Add a line from the origin of the missile for the pathlength and angle given in green
                _canvas.AddLine(_origin, _pathLength, _angle, Color.Green, 1);
                //Add a circle at the end of the line to represent the missile in green
                _canvas.AddCenteredEllipse(temp.X, temp.Y, _radius * 2, _radius * 2, Color.FromArgb(_alpha, Color.Green));
            }
        }
        //side boundary crossing checks
        public bool SideBoundary()
        {
            return (Where().X > _canvas.ScaledWidth || Where().X < 0);//Check Right And Left
        }
        ////bot boundary crossing checks
        public bool BotBoundary()
        {
            return (Where().Y > _canvas.ScaledHeight);
        }
        public bool AlphaCheck()
        {
            return (_alpha == 0);//Alpha value check
        }
    }
}
